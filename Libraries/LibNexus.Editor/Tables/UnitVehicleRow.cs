using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class UnitVehicleRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("vehicleTypeEnum")]
	public uint VehicleTypeEnum { get; set; }

	[TableColumn("numberPilots")]
	public uint NumberPilots { get; set; }

	[TableColumn("pilotPosture00")]
	public uint PilotPosture00 { get; set; }

	[TableColumn("pilotPosture01")]
	public uint PilotPosture01 { get; set; }

	[TableColumn("numberPassengers")]
	public uint NumberPassengers { get; set; }

	[TableColumn("passengerPosture00")]
	public uint PassengerPosture00 { get; set; }

	[TableColumn("passengerPosture01")]
	public uint PassengerPosture01 { get; set; }

	[TableColumn("passengerPosture02")]
	public uint PassengerPosture02 { get; set; }

	[TableColumn("passengerPosture03")]
	public uint PassengerPosture03 { get; set; }

	[TableColumn("passengerPosture04")]
	public uint PassengerPosture04 { get; set; }

	[TableColumn("passengerPosture05")]
	public uint PassengerPosture05 { get; set; }

	[TableColumn("numberGunners")]
	public uint NumberGunners { get; set; }

	[TableColumn("gunnerPosture00")]
	public uint GunnerPosture00 { get; set; }

	[TableColumn("gunnerPosture01")]
	public uint GunnerPosture01 { get; set; }

	[TableColumn("gunnerPosture02")]
	public uint GunnerPosture02 { get; set; }

	[TableColumn("gunnerPosture03")]
	public uint GunnerPosture03 { get; set; }

	[TableColumn("gunnerPosture04")]
	public uint GunnerPosture04 { get; set; }

	[TableColumn("gunnerPosture05")]
	public uint GunnerPosture05 { get; set; }

	[TableColumn("vendorItemPrice")]
	public uint VendorItemPrice { get; set; }

	[TableColumn("localizedTextIdName")]
	public uint LocalizedTextIdName { get; set; }

	[TableColumn("localizedTextIdTooltip")]
	public uint LocalizedTextIdTooltip { get; set; }

	[TableColumn("buttonIcon")]
	public string ButtonIcon { get; set; } = string.Empty;

	[TableColumn("flags")]
	public uint Flags { get; set; }

	[TableColumn("soundEventIdTakeoff")]
	public uint SoundEventIdTakeoff { get; set; }

	[TableColumn("soundEventIdLanding")]
	public uint SoundEventIdLanding { get; set; }

	[TableColumn("waterSurfaceEffectIdMoving")]
	public uint WaterSurfaceEffectIdMoving { get; set; }

	[TableColumn("waterSurfaceEffectIdStanding")]
	public uint WaterSurfaceEffectIdStanding { get; set; }

	[TableColumn("waterSurfaceEffectIdJumpIn")]
	public uint WaterSurfaceEffectIdJumpIn { get; set; }

	[TableColumn("waterSurfaceEffectIdJumpOut")]
	public uint WaterSurfaceEffectIdJumpOut { get; set; }
}
