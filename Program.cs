using YCT.Style;
using YCT.Color;

foreach (int i in ColorCode.Ansi3.Map)
{
    Console.Write($"\x1b[{i}mHello\x1b[0m ");
}
