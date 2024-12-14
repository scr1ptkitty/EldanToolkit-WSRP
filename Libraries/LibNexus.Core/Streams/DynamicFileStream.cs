using System;
using System.IO;

namespace LibNexus.Core.Streams;

public class DynamicFileStream : Stream
{
	public override bool CanRead => _stream is { CanRead: true };
	public override bool CanSeek => _stream is { CanSeek: true };
	public override bool CanWrite => _stream is { CanWrite: true };

	public override long Length
	{
		get
		{
			ObjectDisposedException.ThrowIf(_stream == null, "The file is not open");

			return _stream.Length;
		}
	}

	public override long Position
	{
		get
		{
			ObjectDisposedException.ThrowIf(_stream == null, "The file is not open");

			return _stream.Position;
		}

		set
		{
			ObjectDisposedException.ThrowIf(_stream == null, "The file is not open");

			_stream.Position = value;
		}
	}

	private readonly string _path;
	private Stream _stream;

	public bool IsOpen => _stream != null;

	public DynamicFileStream(string path)
	{
		_path = path;
	}

	public void Open(FileMode mode, FileAccess access, FileShare share = FileShare.None)
	{
		_stream ??= File.Open(_path, mode, access, share);
	}

	public override void Close()
	{
		_stream?.Dispose();
		_stream = null;
	}

	public override void Flush()
	{
		ObjectDisposedException.ThrowIf(_stream == null, "The file is not open");

		_stream.Flush();
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		ObjectDisposedException.ThrowIf(_stream == null, "The file is not open");

		return _stream.Read(buffer, offset, count);
	}

	public override long Seek(long offset, SeekOrigin origin)
	{
		ObjectDisposedException.ThrowIf(_stream == null, "The file is not open");

		return _stream.Seek(offset, origin);
	}

	public override void SetLength(long value)
	{
		ObjectDisposedException.ThrowIf(_stream == null, "The file is not open");

		_stream.SetLength(value);
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
		ObjectDisposedException.ThrowIf(_stream == null, "The file is not open");

		_stream.Write(buffer, offset, count);
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);

		if (disposing)
			_stream?.Dispose();
	}
}
