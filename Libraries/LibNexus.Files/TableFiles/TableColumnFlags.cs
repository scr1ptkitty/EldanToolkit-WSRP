using System;

namespace LibNexus.Files.TableFiles;

// Flags
// 0x08 => Set on everything except
//         CharacterCreationPreset.*
//         Creature2DisplayGroupEntry.*
//         DailyLoginReward.*
//         SoundBank.*
//         SoundEnvironment.*
//         SoundEvent.*
//         SoundParameter.*
//         SoundStates.*
//         SoundSwitch.*
// 0x10 => set on all non-strings
// 0x20 => set on all strings except
//         MiniMapMarker.luaName => 8
//         ModelAttachment.EnumName => 8
//         ModelBone.XSIName => 8
//         ModelCluster.EnumName => 8
//         ModelEvent.EnumName => 8
//         ModelMesh.EnumName => 8
//         Race.maleAssetPath => 8
//         Race.femaleAssetPath => 8
//         RandomPlayerName.nameFragment => 8
//         Spell4SpellTypes.typeName => 8
//         WorldWaterEnvironment.LandMapPath => 8
// 0x40 => set on all strings except
//         MiniMapMarker.luaName => 8
//         ModelAttachment.EnumName => 8
//         ModelBone.XSIName => 8
//         ModelCluster.EnumName => 8
//         ModelEvent.EnumName => 8
//         ModelMesh.EnumName => 8
//         Race.maleAssetPath => 8
//         Race.femaleAssetPath => 8
//         RandomPlayerName.nameFragment => 8
//         Spell4SpellTypes.typeName => 8
//         WorldWaterEnvironment.LandMapPath => 8
// Special cases:
//         HousingPlugItem.housingFeatureTypeFlags => 112  (0x10 + 0x20 + 0x40)
// Likely flags: 0x08 + 0x10 on non-string, 0x08 + 0x20 + 0x40 on string
[Flags]
public enum TableColumnFlags
{
	Unk1 = 0x08,
	Unk2 = 0x10,
	Unk3 = 0x20,
	Unk4 = 0x40
}
