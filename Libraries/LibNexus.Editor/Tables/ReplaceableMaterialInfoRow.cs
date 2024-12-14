using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class ReplaceableMaterialInfoRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("type")]
	public uint Type { get; set; }

	[TableColumn("flags")]
	public uint Flags { get; set; }

	[TableColumn("op")]
	public uint Op { get; set; }

	[TableColumn("blend")]
	public uint Blend { get; set; }

	[TableColumn("shaderNum00")]
	public uint ShaderNum00 { get; set; }

	[TableColumn("shaderNum01")]
	public uint ShaderNum01 { get; set; }

	[TableColumn("numLayers")]
	public uint NumLayers { get; set; }

	[TableColumn("colorIndex01")]
	public uint ColorIndex01 { get; set; }

	[TableColumn("colorIndex00")]
	public uint ColorIndex00 { get; set; }

	[TableColumn("colorIndex02")]
	public uint ColorIndex02 { get; set; }

	[TableColumn("colorIndex03")]
	public uint ColorIndex03 { get; set; }

	[TableColumn("normalIndex00")]
	public uint NormalIndex00 { get; set; }

	[TableColumn("normalIndex01")]
	public uint NormalIndex01 { get; set; }

	[TableColumn("normalIndex02")]
	public uint NormalIndex02 { get; set; }

	[TableColumn("normalIndex03")]
	public uint NormalIndex03 { get; set; }

	[TableColumn("heightSource00")]
	public uint HeightSource00 { get; set; }

	[TableColumn("heightSource01")]
	public uint HeightSource01 { get; set; }

	[TableColumn("heightSource02")]
	public uint HeightSource02 { get; set; }

	[TableColumn("heightSource03")]
	public uint HeightSource03 { get; set; }

	[TableColumn("opacitySource00")]
	public uint OpacitySource00 { get; set; }

	[TableColumn("opacitySource01")]
	public uint OpacitySource01 { get; set; }

	[TableColumn("opacitySource02")]
	public uint OpacitySource02 { get; set; }

	[TableColumn("opacitySource03")]
	public uint OpacitySource03 { get; set; }

	[TableColumn("glossSource00")]
	public uint GlossSource00 { get; set; }

	[TableColumn("glossSource01")]
	public uint GlossSource01 { get; set; }

	[TableColumn("glossSource02")]
	public uint GlossSource02 { get; set; }

	[TableColumn("glossSource03")]
	public uint GlossSource03 { get; set; }

	[TableColumn("glowSource00")]
	public uint GlowSource00 { get; set; }

	[TableColumn("glowSource01")]
	public uint GlowSource01 { get; set; }

	[TableColumn("glowSource02")]
	public uint GlowSource02 { get; set; }

	[TableColumn("glowSource03")]
	public uint GlowSource03 { get; set; }

	[TableColumn("shaderSource00")]
	public uint ShaderSource00 { get; set; }

	[TableColumn("shaderSource01")]
	public uint ShaderSource01 { get; set; }

	[TableColumn("shaderSource02")]
	public uint ShaderSource02 { get; set; }

	[TableColumn("shaderSource03")]
	public uint ShaderSource03 { get; set; }

	[TableColumn("heightValue00")]
	public float HeightValue00 { get; set; }

	[TableColumn("heightValue01")]
	public float HeightValue01 { get; set; }

	[TableColumn("heightValue02")]
	public float HeightValue02 { get; set; }

	[TableColumn("heightValue03")]
	public float HeightValue03 { get; set; }

	[TableColumn("opacityValue00")]
	public float OpacityValue00 { get; set; }

	[TableColumn("opacityValue01")]
	public float OpacityValue01 { get; set; }

	[TableColumn("opacityValue02")]
	public float OpacityValue02 { get; set; }

	[TableColumn("opacityValue03")]
	public float OpacityValue03 { get; set; }

	[TableColumn("glossValue00")]
	public float GlossValue00 { get; set; }

	[TableColumn("glossValue01")]
	public float GlossValue01 { get; set; }

	[TableColumn("glossValue02")]
	public float GlossValue02 { get; set; }

	[TableColumn("glossValue03")]
	public float GlossValue03 { get; set; }

	[TableColumn("glowValue00")]
	public float GlowValue00 { get; set; }

	[TableColumn("glowValue01")]
	public float GlowValue01 { get; set; }

	[TableColumn("glowValue02")]
	public float GlowValue02 { get; set; }

	[TableColumn("glowValue03")]
	public float GlowValue03 { get; set; }

	[TableColumn("shaderValue00")]
	public float ShaderValue00 { get; set; }

	[TableColumn("shaderValue01")]
	public float ShaderValue01 { get; set; }

	[TableColumn("shaderValue02")]
	public float ShaderValue02 { get; set; }

	[TableColumn("shaderValue03")]
	public float ShaderValue03 { get; set; }

	[TableColumn("heightScale00")]
	public float HeightScale00 { get; set; }

	[TableColumn("heightScale01")]
	public float HeightScale01 { get; set; }

	[TableColumn("heightScale02")]
	public float HeightScale02 { get; set; }

	[TableColumn("heightScale03")]
	public float HeightScale03 { get; set; }

	[TableColumn("heightOffset00")]
	public float HeightOffset00 { get; set; }

	[TableColumn("heightOffset01")]
	public float HeightOffset01 { get; set; }

	[TableColumn("heightOffset02")]
	public float HeightOffset02 { get; set; }

	[TableColumn("heightOffset03")]
	public float HeightOffset03 { get; set; }

	[TableColumn("parallaxScale00")]
	public float ParallaxScale00 { get; set; }

	[TableColumn("parallaxScale01")]
	public float ParallaxScale01 { get; set; }

	[TableColumn("parallaxScale02")]
	public float ParallaxScale02 { get; set; }

	[TableColumn("parallaxScale03")]
	public float ParallaxScale03 { get; set; }

	[TableColumn("parallaxOffset00")]
	public float ParallaxOffset00 { get; set; }

	[TableColumn("parallaxOffset01")]
	public float ParallaxOffset01 { get; set; }

	[TableColumn("parallaxOffset02")]
	public float ParallaxOffset02 { get; set; }

	[TableColumn("parallaxOffset03")]
	public float ParallaxOffset03 { get; set; }

	[TableColumn("textureTiles00")]
	public uint TextureTiles00 { get; set; }

	[TableColumn("textureTiles01")]
	public uint TextureTiles01 { get; set; }

	[TableColumn("textureTiles02")]
	public uint TextureTiles02 { get; set; }

	[TableColumn("textureTiles03")]
	public uint TextureTiles03 { get; set; }

	[TableColumn("colorModX00")]
	public float ColorModX00 { get; set; }

	[TableColumn("colorModX01")]
	public float ColorModX01 { get; set; }

	[TableColumn("colorModX02")]
	public float ColorModX02 { get; set; }

	[TableColumn("colorModX03")]
	public float ColorModX03 { get; set; }

	[TableColumn("colorModY00")]
	public float ColorModY00 { get; set; }

	[TableColumn("colorModY01")]
	public float ColorModY01 { get; set; }

	[TableColumn("colorModY02")]
	public float ColorModY02 { get; set; }

	[TableColumn("colorModY03")]
	public float ColorModY03 { get; set; }

	[TableColumn("colorModZ00")]
	public float ColorModZ00 { get; set; }

	[TableColumn("colorModZ01")]
	public float ColorModZ01 { get; set; }

	[TableColumn("colorModZ02")]
	public float ColorModZ02 { get; set; }

	[TableColumn("colorModZ03")]
	public float ColorModZ03 { get; set; }

	[TableColumn("materialTypeId00")]
	public uint MaterialTypeId00 { get; set; }

	[TableColumn("materialTypeId01")]
	public uint MaterialTypeId01 { get; set; }

	[TableColumn("materialTypeId02")]
	public uint MaterialTypeId02 { get; set; }

	[TableColumn("materialTypeId03")]
	public uint MaterialTypeId03 { get; set; }

	[TableColumn("colorTexture00")]
	public string ColorTexture00 { get; set; } = string.Empty;

	[TableColumn("colorTexture01")]
	public string ColorTexture01 { get; set; } = string.Empty;

	[TableColumn("colorTexture02")]
	public string ColorTexture02 { get; set; } = string.Empty;

	[TableColumn("colorTexture03")]
	public string ColorTexture03 { get; set; } = string.Empty;

	[TableColumn("normalTexture00")]
	public string NormalTexture00 { get; set; } = string.Empty;

	[TableColumn("normalTexture01")]
	public string NormalTexture01 { get; set; } = string.Empty;

	[TableColumn("normalTexture02")]
	public string NormalTexture02 { get; set; } = string.Empty;

	[TableColumn("normalTexture03")]
	public string NormalTexture03 { get; set; } = string.Empty;
}
