namespace LibNexus.Files.TextureFiles;

// TODO why is Replacement unused?!
// TODO why is layer 0 never used but only 2 and 3?!
public sealed record TextureJpgLayer(byte Quality, byte HasReplacement, byte Replacement);
