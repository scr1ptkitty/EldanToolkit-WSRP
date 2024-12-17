using System.Linq;

namespace EldanToolkit.Shared
{
	public enum GameTableName
	{
		CharacterCustomization,
		CharacterCustomizationLabel,
		CharacterCustomizationSelection,
		ColorShift,
		Creature2,
		Creature2DisplayGroupEntry,
		Creature2DisplayInfo,
		Creature2OutfitGroupEntry,
		Creature2OutfitInfo,
		DyeColorRamp,
		Emotes,
		HookAsset,
		HousingDecorInfo,
		HousingDecorType,
		HousingPlugItem,
		HousingWallpaperInfo,
		Item2,
		ItemColorSet,
		ItemDisplay,
		ItemSpecial,
		Spell4,
		Spell4Base,
		Spell4Effects,
		UnitVehicle,
		WorldLayer,
		enUS,
		frFR,
		deDE
	}

	public static class GameTableUtil
	{
		private static GameTableName[] LocalizationTables =
		{
			GameTableName.enUS,
			GameTableName.frFR,
			GameTableName.deDE,
		};

		public static bool IsLocalization(GameTableName name)
		{
			return LocalizationTables.Contains(name);
		}

		public static string GetDefaultFilePath(GameTableName name)
		{
			switch(name)
			{
				case GameTableName.enUS: return "en-US.bin";
				case GameTableName.frFR: return "fr-FR.bin";
				case GameTableName.deDE: return "de-DE.bin";
				default: return $"DB/{name.ToString()}.tbl";
			}
		}
	}
}
