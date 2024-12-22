using EldanToolkit.Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Reactive.Subjects;

public class LogSystem
{
	public Project project { get; private set; }
	public int MaxTransientMessages = 100;
	private List<LogMessage> TransientMessages = new();
	private List<PersistentLogMessage> PersistentMessages = new();

	private readonly BehaviorSubject<IEnumerable<LogMessage>> TransientMessagesSubject;
	private readonly BehaviorSubject<IEnumerable<PersistentLogMessage>> PersistentMessagesSubject;

	public IObservable<IEnumerable<LogMessage>> TransientMessagesStream => TransientMessagesSubject.AsObservable();
	public IObservable<IEnumerable<PersistentLogMessage>> PersistentMessagesStream => PersistentMessagesSubject.AsObservable();

	public LogSystem(Project project)
	{
		this.project = project;

		// Initialize Rx subjects
		TransientMessagesSubject = new BehaviorSubject<IEnumerable<LogMessage>>(TransientMessages);
		PersistentMessagesSubject = new BehaviorSubject<IEnumerable<PersistentLogMessage>>(PersistentMessages);
	}

	// Methods for transient messages
	public void AddTransientMessage(LogMessage.MessageType type, string message)
	{
		TransientMessages.Add(new LogMessage(type, message));
		TransientMessages = TransientMessages.Take(MaxTransientMessages).ToList();
		TransientMessagesSubject.OnNext(TransientMessages); // Emit updated list
	}

	// Methods for persistent messages
	public PersistentLogMessage AddPersistentMessage(LogMessage.MessageType type, string message, object owner)
	{
		var msg = new PersistentLogMessage(type, message, owner);
		PersistentMessages.Add(msg);
		PersistentMessagesSubject.OnNext(PersistentMessages); // Emit updated list
		return msg;
	}

	public void RemovePersistentMessage(PersistentLogMessage message)
	{
		TransientMessages.Remove(message);
		PersistentMessagesSubject.OnNext(PersistentMessages);
	}

	public void RemovePersistentMessagesFromOwner(object owner)
	{
		PersistentMessages.RemoveAll(msg =>
			msg.Owner.TryGetTarget(out var target) &&
			ReferenceEquals(target, owner));
		PersistentMessagesSubject.OnNext(PersistentMessages); // Emit updated list
	}

	public void CleanupStalePersistentMessages()
	{
		PersistentMessages.RemoveAll(msg => !msg.Owner.TryGetTarget(out _));
		PersistentMessagesSubject.OnNext(PersistentMessages); // Emit updated list
	}
}

public class LogMessage
{
	public LogMessage(MessageType type, string message)
	{
		Type = type;
		Message = message;
	}

	public string Message { get; private set; }

	public enum MessageType
	{
		Info,
		Warning,
		Error,
	}

	public MessageType Type { get; private set; } = MessageType.Info;
}

public class PersistentLogMessage : LogMessage
{
	public PersistentLogMessage(MessageType type, string message, object owner) : base(type, message)
	{
		Owner = new WeakReference<object>(owner);
	}

	public WeakReference<object> Owner { get; private set; }
}