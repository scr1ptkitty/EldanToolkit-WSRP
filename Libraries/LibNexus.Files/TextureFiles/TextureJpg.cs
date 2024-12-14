using System;
using System.Collections.Generic;

namespace LibNexus.Files.TextureFiles;

// TODO refactor
public static class TextureJpg
{
	private sealed class BitStream
	{
		private readonly byte[] _data;
		private int _position;

		public BitStream(byte[] data)
		{
			_data = data;
		}

		public byte ReadBit()
		{
			var bytePosition = _position / 8;
			var bitPosition = _position % 8;
			bitPosition = 7 - bitPosition;

			var ret = (byte)((_data[bytePosition] & (1 << bitPosition)) >> bitPosition);
			++_position;

			return ret;
		}

		public ushort ReadBits(byte numBits)
		{
			ushort ret = 0;

			for (byte i = 0; i < numBits; ++i)
			{
				ret <<= 1;
				ret |= ReadBit();
			}

			return ret;
		}
	}

	private static class Idct2
	{
		private const int Side = 8;
		private const int Size2 = Side * Side;

		private static readonly float[] Dct = GenerateDct();
		private static readonly float[] DctT = Transpose(GenerateDct());

		private static float[] GenerateDct()
		{
			var result = new float[Size2];

			for (int y = 0, o = 0; y < Side; y++)
			{
				for (var x = 0; x < Side; x++)
					result[o++] = (float)(Math.Sqrt(y == 0 ? .125f : .250f) * Math.Cos((2 * x + 1) * y * Math.PI * .0625f));
			}

			return result;
		}

		private static float[] Transpose(float[] m)
		{
			for (var y = 0; y < Side; y++)
			{
				for (var x = y + 1; x < Side; x++)
					(m[y * Side + x], m[x * Side + y]) = (m[x * Side + y], m[y * Side + x]);
			}

			return m;
		}

		private static float[] MatrixMultiply(float[] m1, float[] m2)
		{
			var result = new float[m1.Length];

			for (var y = 0; y < Side; y++)
			{
				for (var x = 0; x < Side; x++)
				{
					float sum = 0;

					for (var k = 0; k < Side; k++)
						sum += m1[y * Side + k] * m2[k * Side + x];

					result[y * Side + x] = sum;
				}
			}

			return result;
		}

		private static float[] ToFloat(short[] m)
		{
			var r = new float[m.Length];

			for (var i = 0; i < m.Length; i++)
				r[i] = m[i];

			return r;
		}

		public static void DoIdct(short[] m)
		{
			var source = ToFloat(m);

			source = MatrixMultiply(DctT, source);
			source = MatrixMultiply(source, Dct);

			for (var i = 0; i < m.Length; i++)
				m[i] = (short)Math.Round(source[i]);
		}
	}

	private const uint MaxAcdcLength = 16;

	private static readonly byte[] DcLuminanceLengths = [0, 1, 5, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0];
	private static readonly byte[] AcLuminanceLengths = [0, 2, 1, 3, 3, 2, 4, 3, 5, 5, 4, 4, 0, 0, 1, 125];
	private static readonly byte[] DcChrominanceLengths = [0, 3, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0];
	private static readonly byte[] AcChrominanceLengths = [0, 2, 1, 2, 4, 4, 3, 4, 7, 5, 4, 4, 0, 1, 2, 119];
	private static readonly byte[] DcLuminanceValues = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11];

	private static readonly byte[] AcLuminanceValues =
	[
		//// @formatter:off
		0x01, 0x02, 0x03, 0x00, 0x04, 0x11, 0x05, 0x12, 0x21, 0x31, 0x41, 0x06, 0x13, 0x51,
		0x61, 0x07, 0x22, 0x71, 0x14, 0x32, 0x81, 0x91, 0xA1, 0x08, 0x23, 0x42, 0xB1, 0xC1,
		0x15, 0x52, 0xD1, 0xf0, 0x24, 0x33, 0x62, 0x72, 0x82, 0x09, 0x0A, 0x16, 0x17, 0x18,
		0x19, 0x1A, 0x25, 0x26, 0x27, 0x28, 0x29, 0x2A, 0x34, 0x35, 0x36, 0x37, 0x38, 0x39,
		0x3A, 0x43, 0x44, 0x45, 0x46, 0x47, 0x48, 0x49, 0x4A, 0x53, 0x54, 0x55, 0x56, 0x57,
		0x58, 0x59, 0x5A, 0x63, 0x64, 0x65, 0x66, 0x67, 0x68, 0x69, 0x6A, 0x73, 0x74, 0x75,
		0x76, 0x77, 0x78, 0x79, 0x7A, 0x83, 0x84, 0x85, 0x86, 0x87, 0x88, 0x89, 0x8A, 0x92,
		0x93, 0x94, 0x95, 0x96, 0x97, 0x98, 0x99, 0x9A, 0xA2, 0xA3, 0xA4, 0xa5, 0xA6, 0xA7,
		0xA8, 0xA9, 0xAA, 0xB2, 0xB3, 0xB4, 0xB5, 0xB6, 0xB7, 0xB8, 0xB9, 0xBA, 0xC2, 0xC3,
		0xC4, 0xC5, 0xC6, 0xC7, 0xC8, 0xC9, 0xCA, 0xD2, 0xD3, 0xD4, 0xD5, 0xD6, 0xD7, 0xD8,
		0xD9, 0xDA, 0xE1, 0xE2, 0xE3, 0xE4, 0xE5, 0xE6, 0xE7, 0xE8, 0xE9, 0xEa, 0xF1, 0xF2,
		0xF3, 0xF4, 0xF5, 0xF6, 0xF7, 0xF8, 0xF9, 0xFa
		//// @formatter:on
	];

	private static readonly byte[] DcChrominanceValues = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11];

	private static readonly byte[] AcChrominanceValues =
	[
		//// @formatter:off
		0x00, 0x01, 0x02, 0x03, 0x11, 0x04, 0x05, 0x21, 0x31, 0x06, 0x12, 0x41, 0x51, 0x07,
		0x61, 0x71, 0x13, 0x22, 0x32, 0x81, 0x08, 0x14, 0x42, 0x91, 0xA1, 0xB1, 0xC1, 0x09,
		0x23, 0x33, 0x52, 0xF0, 0x15, 0x62, 0x72, 0xD1, 0x0A, 0x16, 0x24, 0x34, 0xE1, 0x25,
		0xF1, 0x17, 0x18, 0x19, 0x1A, 0x26, 0x27, 0x28, 0x29, 0x2A, 0x35, 0x36, 0x37, 0x38,
		0x39, 0x3A, 0x43, 0x44, 0x45, 0x46, 0x47, 0x48, 0x49, 0x4A, 0x53, 0x54, 0x55, 0x56,
		0x57, 0x58, 0x59, 0x5a, 0x63, 0x64, 0x65, 0x66, 0x67, 0x68, 0x69, 0x6A, 0x73, 0x74,
		0x75, 0x76, 0x77, 0x78, 0x79, 0x7a, 0x82, 0x83, 0x84, 0x85, 0x86, 0x87, 0x88, 0x89,
		0x8A, 0x92, 0x93, 0x94, 0x95, 0x96, 0x97, 0x98, 0x99, 0x9A, 0xa2, 0xA3, 0xA4, 0xA5,
		0xA6, 0xA7, 0xA8, 0xA9, 0xAA, 0xB2, 0xB3, 0xB4, 0xB5, 0xB6, 0xB7, 0xB8, 0xB9, 0xBA,
		0xC2, 0xC3, 0xC4, 0xC5, 0xC6, 0xC7, 0xC8, 0xC9, 0xCA, 0xD2, 0xD3, 0xD4, 0xD5, 0xD6,
		0xD7, 0xD8, 0xD9, 0xDA, 0xE2, 0xE3, 0xE4, 0xE5, 0xE6, 0xE7, 0xE8, 0xE9, 0xEA, 0xF2,
		0xF3, 0xF4, 0xF5, 0xF6, 0xF7, 0xF8, 0xF9, 0xFA
		//// @formatter:on
	];

	private static readonly byte[] ZigzagMapping =
	[
		//// @formatter:off
		0, 1, 5, 6, 14, 15, 27, 28,
		2, 4, 7, 13, 16, 26, 29, 42,
		3, 8, 12, 17, 25, 30, 41, 43,
		9, 11, 18, 24, 31, 40, 44, 53,
		10, 19, 23, 32, 39, 45, 52, 54,
		20, 22, 33, 38, 46, 51, 55, 60,
		21, 34, 37, 47, 50, 56, 59, 61,
		35, 36, 48, 49, 57, 58, 62, 63
		//// @formatter:on
	];

	private static readonly byte[] LumQuantizationTemplate =
	[
		//// @formatter:off
		16, 11, 10, 16, 24, 40, 51, 61, 12, 12, 14, 19, 26, 58, 60, 55,
		14, 13, 16, 24, 40, 57, 69, 56, 14, 17, 22, 29, 51, 87, 80, 62,
		18, 22, 37, 56, 68, 109, 103, 77, 24, 35, 55, 64, 81, 104, 113, 92,
		49, 64, 78, 87, 103, 121, 120, 101, 72, 92, 95, 98, 112, 100, 103, 99
		//// @formatter:on
	];

	private static readonly byte[] ChromaQuantizationTemplate =
	[
		//// @formatter:off
		17, 18, 24, 47, 99, 99, 99, 99, 18, 21, 26, 66, 99, 99, 99, 99,
		24, 26, 56, 99, 99, 99, 99, 99, 47, 66, 99, 99, 99, 99, 99, 99,
		99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99,
		99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99
		//// @formatter:on
	];

	private static readonly float[][] LuminanceQuantizationTables = new float[100][];
	private static readonly float[][] ChrominanceQuantizationTables = new float[100][];

	private static readonly Dictionary<long, byte> DcLuminanceTable;
	private static readonly Dictionary<long, byte> AcLuminanceTable;
	private static readonly Dictionary<long, byte> DcChrominanceTable;
	private static readonly Dictionary<long, byte> AcChrominanceTable;

	static TextureJpg()
	{
		DcLuminanceTable = GenerateHuffmanTable(DcLuminanceLengths, MaxAcdcLength, DcLuminanceValues);
		AcLuminanceTable = GenerateHuffmanTable(AcLuminanceLengths, MaxAcdcLength, AcLuminanceValues);
		DcChrominanceTable = GenerateHuffmanTable(DcChrominanceLengths, MaxAcdcLength, DcChrominanceValues);
		AcChrominanceTable = GenerateHuffmanTable(AcChrominanceLengths, MaxAcdcLength, AcChrominanceValues);

		for (byte i = 0; i < 100; i++)
		{
			LuminanceQuantizationTables[i] = GenerateQuantizationTable(i, LumQuantizationTemplate);
			ChrominanceQuantizationTables[i] = GenerateQuantizationTable(i, ChromaQuantizationTemplate);
		}
	}

	private static Dictionary<long, byte> GenerateHuffmanTable(byte[] lengths, uint numLengths, byte[] values)
	{
		var table = new Dictionary<long, byte>();
		uint curIndex = 0;
		ushort code = 0;

		for (uint length = 0; length < numLengths; length++)
		{
			uint numValues = lengths[length];

			for (uint i = 0; i < numValues; i++)
			{
				var mixed = ((long)(length + 1) << 32) | code;
				table[mixed] = values[curIndex++];
				code++;
			}

			code <<= 1;
		}

		return table;
	}

	private static float[] GenerateQuantizationTable(byte qualityFactor, byte[] quantTemplate)
	{
		var table = new float[64];
		var multiplier = (200.0f - qualityFactor * 2.0f) * 0.01f;

		for (var i = 0; i < 64; i++)
			table[i] = quantTemplate[i] * multiplier;

		return table;
	}

	public static byte[] Read(byte[] data, uint width, uint height, uint format, TextureJpgLayer[] layers)
	{
		var luminanceQuantizationTable = new float[4][];
		var chrominanceQuantizationTable = new float[4][];

		byte[] qualityLevels = [layers[0].Quality, layers[1].Quality, layers[2].Quality, layers[3].Quality];

		for (var i = 0u; i < 4; i++)
		{
			luminanceQuantizationTable[i] = LuminanceQuantizationTables[qualityLevels[i]];
			chrominanceQuantizationTable[i] = ChrominanceQuantizationTables[qualityLevels[i]];
		}

		var bitStream = new BitStream(data);

		return format switch
		{
			0 => DecompressFormat0((int)width, (int)height, bitStream, luminanceQuantizationTable, chrominanceQuantizationTable),
			1 => DecompressFormat1((int)width, (int)height, bitStream, layers, luminanceQuantizationTable),
			2 => DecompressFormat2((int)width, (int)height, bitStream, layers, luminanceQuantizationTable, chrominanceQuantizationTable),
			_ => throw new FileFormatException(typeof(Texture), nameof(TextureHeader.JpgFormat))
		};
	}

	private static byte[] DecompressFormat0(int width, int height, BitStream stream, float[][] luminosityQuantization, float[][] chrominanceQuantization)
	{
		var luminance0 = new short[4][];
		var luminance1 = new short[4][];

		var mipWidth = (width + 15) / 16 * 16;
		var mipHeight = (height + 15) / 16 * 16;
		var data = new byte[mipWidth * mipHeight * 4];
		var pixels = new byte[width * height * 4];

		var previousDc = new short[4];

		for (var y = 0; y < mipHeight / 16; y++)
		{
			for (var x = 0; x < mipWidth / 16; x++)
			{
				for (var i = 0; i < luminance0.Length; i++)
				{
					previousDc[0] = ProcessBlock(
						previousDc[0],
						stream,
						DcLuminanceTable,
						AcLuminanceTable,
						luminosityQuantization[0],
						true,
						out luminance0[i]
					);
				}

				previousDc[1] = ProcessBlock(
					previousDc[1],
					stream,
					DcChrominanceTable,
					AcChrominanceTable,
					chrominanceQuantization[1],
					false,
					out var chrominance0
				);

				previousDc[2] = ProcessBlock(
					previousDc[2],
					stream,
					DcChrominanceTable,
					AcChrominanceTable,
					chrominanceQuantization[2],
					false,
					out var chrominance1
				);

				for (var i = 0; i < luminance1.Length; i++)
				{
					previousDc[3] = ProcessBlock(
						previousDc[3],
						stream,
						DcLuminanceTable,
						AcLuminanceTable,
						luminosityQuantization[3],
						true,
						out luminance1[i]
					);
				}

				var colors = DecodeColorBlockFormat0(luminance0, luminance1, chrominance0, chrominance1);

				for (var row = 0; row < 16; row++)
				{
					if (y * 16 + row >= height || x * 16 >= width)
						continue;

					var numPixels = Math.Min(16u, width - x * 16);

					for (var i = 0; i < numPixels; i++)
					{
						data[(y * 16 + row) * width * 4 + x * 16 * 4 + i * 4 + 0] = colors[row * 16 + i][2];
						data[(y * 16 + row) * width * 4 + x * 16 * 4 + i * 4 + 1] = colors[row * 16 + i][1];
						data[(y * 16 + row) * width * 4 + x * 16 * 4 + i * 4 + 2] = colors[row * 16 + i][0];
						data[(y * 16 + row) * width * 4 + x * 16 * 4 + i * 4 + 3] = colors[row * 16 + i][3];
					}
				}
			}
		}

		for (var y = 0; y < height; y++)
			Array.Copy(data, y * mipWidth * 4, pixels, y * width * 4, width * 4);

		return pixels;
	}

	private static byte[] DecompressFormat1(int width, int height, BitStream stream, TextureJpgLayer[] layerInfo, float[][] luminosityQuantization)
	{
		var luminance = new short[4][];

		var mipWidth = (width + 7) / 8 * 8;
		var mipHeight = (height + 7) / 8 * 8;
		var data = new byte[mipWidth * mipHeight * 4];
		var pixels = new byte[width * height * 4];

		var previousDc = new short[4];

		for (var y = 0; y < mipHeight / 8; y++)
		{
			for (var x = 0; x < mipWidth / 8; x++)
			{
				previousDc[0] = ProcessBlock(previousDc[0], stream, DcLuminanceTable, AcLuminanceTable, luminosityQuantization[0], true, out luminance[0]);
				previousDc[1] = ProcessBlock(previousDc[1], stream, DcLuminanceTable, AcLuminanceTable, luminosityQuantization[1], true, out luminance[1]);

				if (layerInfo[2].HasReplacement == 0)
				{
					previousDc[2] = ProcessBlock(
						previousDc[2],
						stream,
						DcLuminanceTable,
						AcLuminanceTable,
						luminosityQuantization[2],
						true,
						out luminance[2]
					);
				}

				if (layerInfo[3].HasReplacement == 0)
				{
					previousDc[3] = ProcessBlock(
						previousDc[3],
						stream,
						DcLuminanceTable,
						AcLuminanceTable,
						luminosityQuantization[3],
						true,
						out luminance[3]
					);
				}

				for (var iy = 0; iy < 8; iy++)
				{
					for (var ix = 0; ix < 8; ix++)
					{
						var r = (byte)luminance[0][iy * 8 + ix];
						var g = (byte)luminance[1][iy * 8 + ix];
						var b = (byte)255;

						if (layerInfo[2].HasReplacement == 0)
							b = (byte)luminance[2][iy * 8 + ix];

						var a = (byte)255;

						if (layerInfo[3].HasReplacement == 0)
							a = (byte)luminance[3][iy * 8 + ix];

						data[((y * 8 + iy) * width + x * 8 + ix) * 4 + 0] = r;
						data[((y * 8 + iy) * width + x * 8 + ix) * 4 + 1] = g;
						data[((y * 8 + iy) * width + x * 8 + ix) * 4 + 2] = b;
						data[((y * 8 + iy) * width + x * 8 + ix) * 4 + 3] = a;
					}
				}
			}
		}

		for (var y = 0; y < height; y++)
			Array.Copy(data, y * mipWidth * 4, pixels, y * width * 4, width * 4);

		return pixels;
	}

	private static byte[] DecompressFormat2(
		int width,
		int height,
		BitStream stream,
		TextureJpgLayer[] layerInfo,
		float[][] luminosityQuantization,
		float[][] chrominanceQuantization
	)
	{
		var mipWidth = (width + 7) / 8 * 8;
		var mipHeight = (height + 7) / 8 * 8;
		var data = new byte[mipWidth * mipHeight * 4];
		var pixels = new byte[width * height * 4];

		var previousDc = new short[4];

		for (var y = 0; y < mipHeight / 8; y++)
		{
			for (var x = 0; x < mipWidth / 8; x++)
			{
				previousDc[0] = ProcessBlock(previousDc[0], stream, DcLuminanceTable, AcLuminanceTable, luminosityQuantization[0], true, out var luminance0);

				previousDc[1] = ProcessBlock(
					previousDc[1],
					stream,
					DcChrominanceTable,
					AcChrominanceTable,
					chrominanceQuantization[1],
					false,
					out var chrominance0
				);

				previousDc[2] = ProcessBlock(
					previousDc[2],
					stream,
					DcChrominanceTable,
					AcChrominanceTable,
					chrominanceQuantization[2],
					false,
					out var chrominance1
				);

				short[] luminance1 = null;

				if (layerInfo[3].HasReplacement == 0)
					previousDc[3] = ProcessBlock(previousDc[3], stream, DcLuminanceTable, AcLuminanceTable, luminosityQuantization[3], true, out luminance1);

				var colors = DecodeColorBlockFormat2(luminance0, luminance1, chrominance0, chrominance1);

				for (var row = 0; row < 8; row++)
				{
					if (y * 8 + row >= height)
						continue;

					if (x * 8 >= width)
						continue;

					var numPixels = Math.Min(8u, width - x * 8);

					for (var i = 0; i < numPixels; i++)
					{
						data[(y * 8 + row) * width * 4 + x * 8 * 4 + i * 4 + 0] = colors[row * 8 + i][2];
						data[(y * 8 + row) * width * 4 + x * 8 * 4 + i * 4 + 1] = colors[row * 8 + i][1];
						data[(y * 8 + row) * width * 4 + x * 8 * 4 + i * 4 + 2] = colors[row * 8 + i][1];
						data[(y * 8 + row) * width * 4 + x * 8 * 4 + i * 4 + 3] = colors[row * 8 + i][3];
					}
				}
			}
		}

		for (var y = 0; y < height; y++)
			Array.Copy(data, y * mipWidth * 4, pixels, y * width * 4, width * 4);

		return pixels;
	}

	private static byte[][] DecodeColorBlockFormat0(short[][] lum0, short[][] lum1, short[] chrom0, short[] chrom1)
	{
		var colors = new byte[16 * 16][];

		for (uint y = 0; y < 16; y++)
		{
			for (uint x = 0; x < 16; x++)
			{
				var cy = y >= 8 ? 1u : 0u;
				var cx = x >= 8 ? 1u : 0u;
				var by = y % 8;
				var bx = x % 8;

				var block = cy * 2 + cx;
				var lumIdx = by * 8 + bx;
				var crmIdx = y / 2 * 8 + x / 2;
				colors[y * 16 + x] = YCbCrToColor32(lum0[block][lumIdx], lum1[block][lumIdx], chrom0[crmIdx], chrom1[crmIdx]);
			}
		}

		return colors;
	}

	private static byte[][] DecodeColorBlockFormat2(short[] lum0, short[]lum1, short[] chrom0, short[] chrom1)
	{
		var colors = new byte[8 * 8][];

		for (uint y = 0; y < 8; y++)
		{
			for (uint x = 0; x < 8; x++)
			{
				var idx = y * 8 + x;
				short alpha = 1;

				if (lum1 != null)
					alpha = lum1[idx];

				colors[idx] = YCbCrToColor32(lum0[idx], alpha, chrom0[idx], chrom1[idx]);
			}
		}

		return colors;
	}

	private static byte[] YCbCrToColor32(int y, int lum1, int cb, int cr)
	{
		var a = y - (cr >> 1);
		var beta = (byte)Clamp(a + cr, 0, 0xFF);
		var gamma = (byte)Clamp(a - (cb >> 1), 0, 0xFF);
		var delta = (byte)Clamp(gamma + cb, 0, 0xFF);
		var alpha = (byte)Clamp(lum1, 0, 0xFF);

		return [gamma, beta, delta, alpha];
	}

	private static short ProcessBlock(
		short previousDc,
		BitStream stream,
		Dictionary<long, byte> dcTable,
		Dictionary<long, byte> acTable,
		float[] quantizationTable,
		bool isLuminance,
		out short[] output
	)
	{
		output = new short[64];
		var bufferBlock = new short[64];

		var currentDc = DecodeBlock(stream, bufferBlock, dcTable, acTable, previousDc);
		UnZigZag(bufferBlock);
		Dequantize(bufferBlock, quantizationTable);

		Idct2.DoIdct(bufferBlock);

		for (var i = 0; i < 64; i++)
		{
			var value = bufferBlock[i];

			if (isLuminance)
				value = (short)Clamp(value + 128, 0, 255);
			else
				value = (short)Clamp(value, -256, 255);

			output[i] = value;
		}

		return currentDc;
	}

	private static short DecodeBlock(BitStream stream, short[] block, Dictionary<long, byte> dcTable, Dictionary<long, byte> acTable, short previousDc = 0)
	{
		var dcLength = DecodeValue(stream, dcTable);
		var epsilon = stream.ReadBits(dcLength);
		var deltaDc = Extend(epsilon, dcLength);
		var currentDc = (short)(deltaDc + previousDc);

		block[0] = currentDc;

		for (var idx = 1; idx < 64;)
		{
			var acCodedValue = DecodeValue(stream, acTable);

			if (acCodedValue == 0)
				break;

			if (acCodedValue == 0xF0)
			{
				idx += 16;

				continue;
			}

			idx += (acCodedValue >> 4) & 0xF;
			var acLength = (byte)(acCodedValue & 0xF);
			epsilon = stream.ReadBits(acLength);
			var acValue = Extend(epsilon, acLength);
			block[idx] = acValue;
			idx++;
		}

		return currentDc;
	}

	private static byte DecodeValue(BitStream stream, Dictionary<long, byte> table)
	{
		ushort word = 0;
		byte wordLength = 0;

		do
		{
			try
			{
				word <<= 1;
				word |= stream.ReadBit();
				wordLength++;

				var mixed = ((long)wordLength << 32) | word;

				if (table.TryGetValue(mixed, out var itr))
					return itr;
			}
			catch (Exception)
			{
				return 0;
			}
		}
		while (wordLength < 16);

		return 0;
	}

	private static short Extend(ushort value, ushort length)
	{
		return value < 1 << (length - 1) ? (short)(value + (-1 << length) + 1) : (short)value;
	}

	private static void UnZigZag(short[] block)
	{
		var buffer = new short[64];

		for (var i = 0; i < 64; i++)
			buffer[i] = block[ZigzagMapping[i]];

		Array.Copy(buffer, block, 64);
	}

	private static void Dequantize(short[] block, float[] quantizationTable)
	{
		for (var i = 0; i < 64; i++)
			block[i] = (short)(block[i] * quantizationTable[i]);
	}

	private static int Clamp(int value, int min, int max)
	{
		return value < min ? min :
			value > max ? max : value;
	}
}
