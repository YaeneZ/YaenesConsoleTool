using System.Reflection;

namespace YCT.Color;

// 3 bit
// 4 bit
// 8 bit
// 24 bit -> default
public class YColor3
{
    public byte color;
}

public class YColor4
{
    public byte color;
}

public class YColor8
{
    public byte color;
}

public class YColor
{
    public byte Red;
    public byte Green;
    public byte Blue;

    public YColor(byte red, byte green, byte blue)
    {
        Red = red;
        Green = green;
        Blue = blue;
    }
}

// std FG/BG
public static class ColorCode
{
    public static class Ansi3
    {
        public static class Foreground
        {
            public const int Black = 30;
            public const int Red = 31;
            public const int Green = 32;
            public const int Yellow = 33;
            public const int Blue = 34;
            public const int Magenta = 35;
            public const int Cyan = 36;
            public const int White = 37;
        }

        public static class Background
        {
            public const int Black = 40;
            public const int Red = 41;
            public const int Green = 42;
            public const int Yellow = 43;
            public const int Blue = 44;
            public const int Magenta = 45;
            public const int Cyan = 46;
            public const int White = 47;
        }

        public static readonly int[] Map = initMap();

        private static int[] initMap()
        {
            var fgFields = typeof(ColorCode.Ansi3.Foreground)
                .GetFields(BindingFlags.Public | BindingFlags.Static)
                .OrderBy(f => f.MetadataToken)
                .Select(f => (int)f.GetRawConstantValue());

            var bgFields = typeof(ColorCode.Ansi3.Background)
                .GetFields(BindingFlags.Public | BindingFlags.Static)
                .OrderBy(f => f.MetadataToken)
                .Select(f => (int)f.GetRawConstantValue());

            return fgFields.Concat(bgFields).ToArray();
        }

        public static int FromYColor3(YColor3 color)
        {
            return Map[color.color];
        }
    }

    public static class Ansi4
    {
        public static class Foreground
        {
            public const int Black = 30;
            public const int Red = 31;
            public const int Green = 32;
            public const int Yellow = 33;
            public const int Blue = 34;
            public const int Magenta = 35;
            public const int Cyan = 36;
            public const int White = 37;

            public const int BrightBlack = 90;
            public const int BrightRed = 91;
            public const int BrightGreen = 92;
            public const int BrightYellow = 93;
            public const int BrightBlue = 94;
            public const int BrightMagenta = 95;
            public const int BrightCyan = 96;
            public const int BrightWhite = 97;
        }

        public static class Background
        {
            public const int Black = 40;
            public const int Red = 41;
            public const int Green = 42;
            public const int Yellow = 43;
            public const int Blue = 44;
            public const int Magenta = 45;
            public const int Cyan = 46;
            public const int White = 47;

            public const int BrightBlack = 100;
            public const int BrightRed = 101;
            public const int BrightGreen = 102;
            public const int BrightYellow = 103;
            public const int BrightBlue = 104;
            public const int BrightMagenta = 105;
            public const int BrightCyan = 106;
            public const int BrightWhite = 107;

        }
    }

    public static class Ansi8
    {
        public static class Standard
        {
            public const int Black = 0;
            public const int Red = 1;
            public const int Green = 2;
            public const int Yellow = 3;
            public const int Blue = 4;
            public const int Magenta = 5;
            public const int Cyan = 6;
            public const int White = 7;
        }

        public static class HighIntensity
        {
            public const int Black = 8;
            public const int Red = 9;
            public const int Green = 10;
            public const int Yellow = 11;
            public const int Blue = 12;
            public const int Magenta = 13;
            public const int Cyan = 14;
            public const int White = 15;
        }

        public static int RGB(int r, int g, int b)
        {
            if (r < 0 || r > 5 ||
                g < 0 || g > 5 ||
                b < 0 || b > 5)
                throw new Exception("Error: Values must be between 0 - 5");

            return 16 + 36 * r + 6 * g + b;
        }

        public static int GrayScale(int brightness)
        {
            if (brightness < 0 ||
                brightness > 24)
                throw new Exception("Error: GrayScale must be between 0 - 24");

            return 232 + brightness;
        }
    }

    public static class Ansi24
    {

    }
}

