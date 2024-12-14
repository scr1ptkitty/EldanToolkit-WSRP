using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class GuildPerkRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("localizedTextIdTitle")]
	public uint LocalizedTextIdTitle { get; set; }

	[TableColumn("localizedTextIdDescription")]
	public uint LocalizedTextIdDescription { get; set; }

	[TableColumn("luaSprite")]
	public string LuaSprite { get; set; } = string.Empty;

	[TableColumn("luaName")]
	public string LuaName { get; set; } = string.Empty;

	[TableColumn("purchaseInfluenceCost")]
	public uint PurchaseInfluenceCost { get; set; }

	[TableColumn("activateInfluenceCost")]
	public uint ActivateInfluenceCost { get; set; }

	[TableColumn("spell4IdActivate")]
	public uint Spell4IdActivate { get; set; }

	[TableColumn("guildPerkIdRequired00")]
	public uint GuildPerkIdRequired00 { get; set; }

	[TableColumn("guildPerkIdRequired01")]
	public uint GuildPerkIdRequired01 { get; set; }

	[TableColumn("guildPerkIdRequired02")]
	public uint GuildPerkIdRequired02 { get; set; }

	[TableColumn("achievementIdRequired")]
	public uint AchievementIdRequired { get; set; }
}
