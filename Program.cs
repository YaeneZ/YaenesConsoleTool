using YCT.Style;
using YCT.Color;

Style style = new();
YColor color = YColor.Lime;
style.SetTextColor(color);

style.Apply();
Console.WriteLine("Hello");
style.ResetStyle();

Style.ApplyTextColor(YColor.BlueViolet);
Console.WriteLine("Test");
Style.ApplyBackgroundColor(YColor.Maroon);
Console.WriteLine("Test");
Style.Reset();

YColor8 color8 = new();
ColorCode.Ansi8.RGB(0, 255, 0);
