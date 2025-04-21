using System.Reflection;

namespace YCT.Color;

// 3 bit
// 4 bit
// 8 bit
// 24 bit -> default
public class YColor3
{
    public byte color;

    public YColor3(byte color)
    {
        this.color = color;
    }
}

public class YColor4
{
    public byte color;

    public YColor4(byte color)
    {
        this.color = color;
    }
}

public class YColor8
{
    public byte color;

    public YColor8()
    {
        color = 0;
    }

    public YColor8(byte color)
    {
        this.color = color;
    }
}

public class YColor
{
    public byte red;
    public byte green;
    public byte blue;

    public YColor(byte red, byte green, byte blue)
    {
        this.red = red;
        this.green = green;
        this.blue = blue;
    }

    public static class VGA
    {
        public static YColor Black => new(0, 0, 0);
        public static YColor Red => new(170, 0, 0);
        public static YColor Green => new(0, 170, 0);
        public static YColor Yellow => new(170, 85, 0);
        public static YColor Blue => new(0, 0, 170);
        public static YColor Magenta => new(170, 0, 170);
        public static YColor Cyan => new(0, 170, 170);
        public static YColor White => new(170, 170, 170);
        public static YColor BrightBlack => new(85, 85, 85);
        public static YColor BrightRed => new(255, 85, 85);
        public static YColor BrightGreen => new(85, 255, 85);
        public static YColor BrightYellow => new(255, 255, 0);
        public static YColor BrightBlue => new(0, 0, 255);
        public static YColor BrightMagenta => new(255, 0, 255);
        public static YColor BrightCyan => new(0, 255, 255);
        public static YColor BrightWhite => new(255, 255, 255);
    }
    public static class WinXP
    {
        public static YColor Black => new(0, 0, 0);
        public static YColor Red => new(128, 0, 0);
        public static YColor Green => new(0, 128, 0);
        public static YColor Yellow => new(128, 128, 0);
        public static YColor Blue => new(0, 0, 128);
        public static YColor Magenta => new(128, 0, 128);
        public static YColor Cyan => new(0, 128, 128);
        public static YColor White => new(192, 192, 192);
        public static YColor BrightBlack => new(128, 128, 128);
        public static YColor BrightRed => new(255, 0, 0);
        public static YColor BrightGreen => new(0, 255, 0);
        public static YColor BrightYellow => new(255, 255, 0);
        public static YColor BrightBlue => new(0, 0, 255);
        public static YColor BrightMagenta => new(255, 0, 255);
        public static YColor BrightCyan => new(0, 255, 255);
        public static YColor BrightWhite => new(255, 255, 255);
    }
    public static class WinPS
    {
        public static YColor Black => new(0, 0, 0);
        public static YColor Red => new(128, 0, 0);
        public static YColor Green => new(0, 128, 0);
        public static YColor Yellow => new(238, 237, 240);
        public static YColor Blue => new(0, 0, 128);
        public static YColor Magenta => new(1, 36, 86);
        public static YColor Cyan => new(0, 128, 128);
        public static YColor White => new(192, 192, 192);
        public static YColor BrightBlack => new(128, 128, 128);
        public static YColor BrightRed => new(255, 0, 0);
        public static YColor BrightGreen => new(0, 255, 0);
        public static YColor BrightYellow => new(255, 255, 0);
        public static YColor BrightBlue => new(0, 0, 255);
        public static YColor BrightMagenta => new(255, 0, 255);
        public static YColor BrightCyan => new(0, 255, 255);
        public static YColor BrightWhite => new(255, 255, 255);
    }
    public static class VSCode
    {
        public static YColor Black => new(0, 0, 0);
        public static YColor Red => new(205, 49, 49);
        public static YColor Green => new(13, 188, 121);
        public static YColor Yellow => new(229, 229, 16);
        public static YColor Blue => new(36, 114, 200);
        public static YColor Magenta => new(188, 63, 188);
        public static YColor Cyan => new(17, 168, 205);
        public static YColor White => new(229, 229, 229);
        public static YColor BrightBlack => new(102, 102, 102);
        public static YColor BrightRed => new(241, 76, 76);
        public static YColor BrightGreen => new(35, 209, 139);
        public static YColor BrightYellow => new(245, 245, 67);
        public static YColor BrightBlue => new(59, 142, 234);
        public static YColor BrightMagenta => new(214, 112, 214);
        public static YColor BrightCyan => new(41, 184, 219);
        public static YColor BrightWhite => new(229, 229, 229);
    }
    public static class Win10
    {
        public static YColor Black => new(12, 12, 12);
        public static YColor Red => new(197, 15, 31);
        public static YColor Green => new(19, 161, 14);
        public static YColor Yellow => new(193, 156, 0);
        public static YColor Blue => new(0, 55, 218);
        public static YColor Magenta => new(136, 23, 152);
        public static YColor Cyan => new(58, 150, 221);
        public static YColor White => new(204, 204, 204);
        public static YColor BrightBlack => new(118, 118, 118);
        public static YColor BrightRed => new(231, 72, 86);
        public static YColor BrightGreen => new(22, 198, 12);
        public static YColor BrightYellow => new(249, 241, 165);
        public static YColor BrightBlue => new(59, 120, 255);
        public static YColor BrightMagenta => new(180, 0, 158);
        public static YColor BrightCyan => new(97, 214, 214);
        public static YColor BrightWhite => new(242, 242, 242);
    }
    public static class TermApp
    {
        public static YColor Black => new(0, 0, 0);
        public static YColor Red => new(153, 0, 0);
        public static YColor Green => new(0, 166, 0);
        public static YColor Yellow => new(153, 153, 0);
        public static YColor Blue => new(0, 0, 178);
        public static YColor Magenta => new(178, 0, 178);
        public static YColor Cyan => new(0, 166, 178);
        public static YColor White => new(191, 191, 191);
        public static YColor BrightBlack => new(102, 102, 102);
        public static YColor BrightRed => new(230, 0, 0);
        public static YColor BrightGreen => new(0, 217, 0);
        public static YColor BrightYellow => new(230, 230, 0);
        public static YColor BrightBlue => new(0, 0, 255);
        public static YColor BrightMagenta => new(230, 0, 230);
        public static YColor BrightCyan => new(0, 230, 230);
        public static YColor BrightWhite => new(230, 230, 230);
    }
    public static class PuTTY
    {
        public static YColor Black => new(0, 0, 0);
        public static YColor Red => new(187, 0, 0);
        public static YColor Green => new(0, 187, 0);
        public static YColor Yellow => new(187, 187, 0);
        public static YColor Blue => new(0, 0, 187);
        public static YColor Magenta => new(187, 0, 187);
        public static YColor Cyan => new(0, 187, 187);
        public static YColor White => new(187, 187, 187);
        public static YColor BrightBlack => new(85, 85, 85);
        public static YColor BrightRed => new(255, 85, 85);
        public static YColor BrightGreen => new(85, 255, 85);
        public static YColor BrightYellow => new(255, 255, 85);
        public static YColor BrightBlue => new(85, 85, 255);
        public static YColor BrightMagenta => new(255, 85, 255);
        public static YColor BrightCyan => new(85, 255, 255);
        public static YColor BrightWhite => new(255, 255, 255);
    }
    public static class mIRC
    {
        public static YColor Black => new(0, 0, 0);
        public static YColor Red => new(127, 0, 0);
        public static YColor Green => new(0, 147, 0);
        public static YColor Yellow => new(252, 127, 0);
        public static YColor Blue => new(0, 0, 127);
        public static YColor Magenta => new(156, 0, 156);
        public static YColor Cyan => new(0, 147, 147);
        public static YColor White => new(210, 210, 210);
        public static YColor BrightBlack => new(127, 127, 127);
        public static YColor BrightRed => new(255, 0, 0);
        public static YColor BrightGreen => new(0, 252, 0);
        public static YColor BrightYellow => new(255, 255, 0);
        public static YColor BrightBlue => new(0, 0, 255);
        public static YColor BrightMagenta => new(255, 0, 255);
        public static YColor BrightCyan => new(0, 255, 255);
        public static YColor BrightWhite => new(255, 255, 255);
    }
    public static class xterm
    {
        public static YColor Black => new(0, 0, 0);
        public static YColor Red => new(205, 0, 0);
        public static YColor Green => new(0, 205, 0);
        public static YColor Yellow => new(205, 205, 0);
        public static YColor Blue => new(0, 0, 238);
        public static YColor Magenta => new(205, 0, 205);
        public static YColor Cyan => new(0, 205, 205);
        public static YColor White => new(229, 229, 229);
        public static YColor BrightBlack => new(127, 127, 127);
        public static YColor BrightRed => new(255, 0, 0);
        public static YColor BrightGreen => new(0, 255, 0);
        public static YColor BrightYellow => new(255, 255, 0);
        public static YColor BrightBlue => new(92, 92, 255);
        public static YColor BrightMagenta => new(255, 0, 255);
        public static YColor BrightCyan => new(0, 255, 255);
        public static YColor BrightWhite => new(255, 255, 255);
    }
    public static class Ubuntu
    {
        public static YColor Black => new(1, 1, 1);
        public static YColor Red => new(222, 56, 43);
        public static YColor Green => new(57, 181, 75);
        public static YColor Yellow => new(255, 199, 6);
        public static YColor Blue => new(0, 111, 184);
        public static YColor Magenta => new(118, 38, 113);
        public static YColor Cyan => new(44, 181, 233);
        public static YColor White => new(204, 204, 204);
        public static YColor BrightBlack => new(128, 128, 128);
        public static YColor BrightRed => new(255, 0, 0);
        public static YColor BrightGreen => new(0, 255, 0);
        public static YColor BrightYellow => new(255, 255, 0);
        public static YColor BrightBlue => new(0, 0, 255);
        public static YColor BrightMagenta => new(255, 0, 255);
        public static YColor BrightCyan => new(0, 255, 255);
        public static YColor BrightWhite => new(255, 255, 255);
    }
    public static class Eclipse
    {
        public static YColor Black => new(0, 0, 0);
        public static YColor Red => new(205, 0, 0);
        public static YColor Green => new(0, 205, 0);
        public static YColor Yellow => new(205, 205, 0);
        public static YColor Blue => new(0, 0, 238);
        public static YColor Magenta => new(205, 0, 205);
        public static YColor Cyan => new(0, 205, 205);
        public static YColor White => new(229, 229, 229);
        public static YColor BrightBlack => new(0, 0, 0);
        public static YColor BrightRed => new(255, 0, 0);
        public static YColor BrightGreen => new(0, 255, 0);
        public static YColor BrightYellow => new(255, 255, 0);
        public static YColor BrightBlue => new(92, 92, 255);
        public static YColor BrightMagenta => new(255, 0, 255);
        public static YColor BrightCyan => new(0, 255, 255);
        public static YColor BrightWhite => new(255, 255, 255);
    }

    // Red
    public static YColor IndianRed => new(205, 92, 92);
    public static YColor LightCoral => new(240, 128, 128);
    public static YColor Salmon => new(250, 128, 114);
    public static YColor DarkSalmon => new(233, 150, 122);
    public static YColor Crimson => new(220, 20, 60);
    public static YColor Red => new(255, 0, 0);
    public static YColor FireBrick => new(178, 34, 34);
    public static YColor DarkRed => new(139, 0, 0);

    // Pink
    public static YColor Pink => new(255, 192, 203);
    public static YColor LightPink => new(255, 182, 193);
    public static YColor HotPink => new(255, 105, 180);
    public static YColor DeepPink => new(255, 20, 147);
    public static YColor MediumVioletRed => new(199, 21, 133);
    public static YColor PaleVioletRed => new(219, 112, 147);

    // Orange
    public static YColor LightSalmon => new(255, 160, 122);
    public static YColor Coral => new(255, 127, 80);
    public static YColor Tomato => new(255, 99, 71);
    public static YColor OrangeRed => new(255, 69, 0);
    public static YColor DarkOrange => new(255, 140, 0);
    public static YColor Orange => new(255, 165, 0);

    // Yellow
    public static YColor Gold => new(255, 215, 0);
    public static YColor Yellow => new(255, 255, 0);
    public static YColor LightYellow => new(255, 255, 224);
    public static YColor LemonChiffon => new(255, 250, 205);
    public static YColor LightGoldenrodYellow => new(250, 250, 210);
    public static YColor PapayaWhip => new(255, 239, 213);
    public static YColor Moccasin => new(255, 228, 181);
    public static YColor PeachPuff => new(255, 218, 185);
    public static YColor PaleGoldenrod => new(238, 232, 170);
    public static YColor Khaki => new(240, 230, 140);
    public static YColor DarkKhaki => new(189, 183, 107);

    // Purple
    public static YColor Lavender => new(230, 230, 250);
    public static YColor Thistle => new(216, 191, 216);
    public static YColor Plum => new(221, 160, 221);
    public static YColor Violet => new(238, 130, 238);
    public static YColor Orchid => new(218, 112, 214);
    public static YColor Fuchsia => new(255, 0, 255);
    public static YColor Magenta => new(255, 0, 255);
    public static YColor MediumOrchid => new(186, 85, 211);
    public static YColor MediumPurple => new(147, 112, 219);
    public static YColor RebeccaPurple => new(102, 51, 153);
    public static YColor BlueViolet => new(138, 43, 226);
    public static YColor DarkViolet => new(148, 0, 211);
    public static YColor DarkOrchid => new(153, 50, 204);
    public static YColor DarkMagenta => new(139, 0, 139);
    public static YColor Purple => new(128, 0, 128);
    public static YColor Indigo => new(75, 0, 130);
    public static YColor SlateBlue => new(106, 90, 205);
    public static YColor DarkSlateBlue => new(72, 61, 139);
    public static YColor MediumSlateBlue => new(123, 104, 238);

    // Green
    public static YColor GreenYellow => new(173, 255, 47);
    public static YColor Chartreuse => new(127, 255, 0);
    public static YColor LawnGreen => new(124, 252, 0);
    public static YColor Lime => new(0, 255, 0);
    public static YColor LimeGreen => new(50, 205, 50);
    public static YColor PaleGreen => new(152, 251, 152);
    public static YColor LightGreen => new(144, 238, 144);
    public static YColor MediumSpringGreen => new(0, 250, 154);
    public static YColor SpringGreen => new(0, 255, 127);
    public static YColor MediumSeaGreen => new(60, 179, 113);
    public static YColor SeaGreen => new(46, 139, 87);
    public static YColor ForestGreen => new(34, 139, 34);
    public static YColor Green => new(0, 128, 0);
    public static YColor DarkGreen => new(0, 100, 0);
    public static YColor YellowGreen => new(154, 205, 50);
    public static YColor OliveDrab => new(107, 142, 35);
    public static YColor Olive => new(128, 128, 0);
    public static YColor DarkOliveGreen => new(85, 107, 47);
    public static YColor MediumAquamarine => new(102, 205, 170);
    public static YColor DarkSeaGreen => new(143, 188, 139);
    public static YColor LightSeaGreen => new(32, 178, 170);
    public static YColor DarkCyan => new(0, 139, 139);
    public static YColor Teal => new(0, 128, 128);

    // Blue
    public static YColor Aqua => new(0, 255, 255);
    public static YColor Cyan => new(0, 255, 255);
    public static YColor LightCyan => new(224, 255, 255);
    public static YColor PaleTurquoise => new(175, 238, 238);
    public static YColor Aquamarine => new(127, 255, 212);
    public static YColor Turquoise => new(64, 224, 208);
    public static YColor MediumTurquoise => new(72, 209, 204);
    public static YColor DarkTurquoise => new(0, 206, 209);
    public static YColor CadetBlue => new(95, 158, 160);
    public static YColor SteelBlue => new(70, 130, 180);
    public static YColor LightSteelBlue => new(176, 196, 222);
    public static YColor PowderBlue => new(176, 224, 230);
    public static YColor LightBlue => new(173, 216, 230);
    public static YColor SkyBlue => new(135, 206, 235);
    public static YColor LightSkyBlue => new(135, 206, 250);
    public static YColor DeepSkyBlue => new(0, 191, 255);
    public static YColor DodgerBlue => new(30, 144, 255);
    public static YColor CornflowerBlue => new(100, 149, 237);
    public static YColor RoyalBlue => new(65, 105, 225);
    public static YColor Blue => new(0, 0, 255);
    public static YColor MediumBlue => new(0, 0, 205);
    public static YColor DarkBlue => new(0, 0, 139);
    public static YColor Navy => new(0, 0, 128);
    public static YColor MidnightBlue => new(25, 25, 112);

    // Brown
    public static YColor Cornsilk => new(255, 248, 220);
    public static YColor BlanchedAlmond => new(255, 235, 205);
    public static YColor Bisque => new(255, 228, 196);
    public static YColor NavajoWhite => new(255, 222, 173);
    public static YColor Wheat => new(245, 222, 179);
    public static YColor BurlyWood => new(222, 184, 135);
    public static YColor Tan => new(210, 180, 140);
    public static YColor RosyBrown => new(188, 143, 143);
    public static YColor SandyBrown => new(244, 164, 96);
    public static YColor Goldenrod => new(218, 165, 32);
    public static YColor DarkGoldenrod => new(184, 134, 11);
    public static YColor Peru => new(205, 133, 63);
    public static YColor Chocolate => new(210, 105, 30);
    public static YColor SaddleBrown => new(139, 69, 19);
    public static YColor Sienna => new(160, 82, 45);
    public static YColor Brown => new(165, 42, 42);
    public static YColor Maroon => new(128, 0, 0);

    // White
    public static YColor White => new(255, 255, 255);
    public static YColor Snow => new(255, 250, 250);
    public static YColor HoneyDew => new(240, 255, 240);
    public static YColor MintCream => new(245, 255, 250);
    public static YColor Azure => new(240, 255, 255);
    public static YColor AliceBlue => new(240, 248, 255);
    public static YColor GhostWhite => new(248, 248, 255);
    public static YColor WhiteSmoke => new(245, 245, 245);
    public static YColor SeaShell => new(255, 245, 238);
    public static YColor Beige => new(245, 245, 220);
    public static YColor OldLace => new(253, 245, 230);
    public static YColor FloralWhite => new(255, 250, 240);
    public static YColor Ivory => new(255, 255, 240);
    public static YColor AntiqueWhite => new(250, 235, 215);
    public static YColor Linen => new(250, 240, 230);
    public static YColor LavenderBlush => new(255, 240, 245);
    public static YColor MistyRose => new(255, 228, 225);

    // Gray
    public static YColor Gainsboro => new(220, 220, 220);
    public static YColor LightGray => new(211, 211, 211);
    public static YColor Silver => new(192, 192, 192);
    public static YColor DarkGray => new(169, 169, 169);
    public static YColor Gray => new(128, 128, 128);
    public static YColor DimGray => new(105, 105, 105);
    public static YColor LightSlateGray => new(119, 136, 153);
    public static YColor SlateGray => new(112, 128, 144);
    public static YColor DarkSlateGray => new(47, 79, 79);
    public static YColor Black => new(0, 0, 0);
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

        private static readonly int[] Map = initMap();

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

        public static int FromYColor3(YColor3 color) => Map[color.color];
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

        private static readonly int[] Map = initMap();

        private static int[] initMap()
        {
            var fgFields = typeof(ColorCode.Ansi4.Foreground)
                .GetFields(BindingFlags.Public | BindingFlags.Static)
                .OrderBy(f => f.MetadataToken)
                .Select(f => (int)f.GetRawConstantValue());

            var bgFields = typeof(ColorCode.Ansi4.Foreground)
                .GetFields(BindingFlags.Public | BindingFlags.Static)
                .OrderBy(f => f.MetadataToken)
                .Select(f => (int)f.GetRawConstantValue());

            return fgFields.Concat(bgFields).ToArray();
        }

        public static int FromYColor4(YColor4 color) => Map[color.color];
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

