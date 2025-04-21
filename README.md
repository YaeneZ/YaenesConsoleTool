# Yaenes Console Tool (YCT)

YCT is a tool to use your console at its full potential.

NOTE: YCT is still in early early development!
Many features are missing.

## Features
- Simple Text coloring with Styles

## Planed
- Easy to use Color for your Terminal - Styling for your text - Advanced Designs

## Examples

### YColor
YCT uses the ANSI escape sequence to color any Terminal.

There are 4 types of YColor:
-  3 bit
-  4 bit
-  8 bit
- 24 bit

ANSI 3:
ANSI 3 uses 3 bit for text and background colors.
So you get 8 text and 8 background colors.
```csharp
// Creates a green text color
YColor3 color3 = new(32);
```

ANSI 4:
ANSI 4 uses 4 bit for text and background colors.
So you get 16 text and 16 background colors.
```csharp
// creates a bright green Text color
YColor4 color4 = new(92);
```

ANSI 8:
With ANSI 8 you will get a whole byte for colors.
There are 16 individual base colors, 24 different gray scales and the other 216 bits are used for a color cube for a rgb spectrum.
```csharp
// Green standard color
YColor8 green8 = new(2);

// Gray
YColor8 gray8 = new(243);

// RGB example
YColor8 color8 = ColorCode.Ansi8.RGB(0, 255, 0);
```

ANSI 24:
With ANSI 24 you get a whole byte for each RGB value.
```csharp
// Create a green Color
YColor color = new(0, 255, 0);
```

To use Color you need to include Color in your script.
```csharp
using YCT.Color;
```

### Color Presets
Presets are pretty simple in YCT.
There are 4 types of presets, for each ANSY color one type.
```csharp
// Presets for ANSI 3 and 4
YColor3 foreground3 = ColorCode.Ansi3.Foreground.Red;
YColor4 background4 = ColorCode.Ansi4.Background.BrightBlue;

// Presets for ANSI 8
YColor8 standard = ColorCode.Ansi8.Standard.Magenta;
YColor8 highIntensity = ColorCode.Ansi8.HighIntensity.Cyan;

// Gray value must be between 0 and 24!
YColor8 gray = ColorCode.Ansi8.GrayScale(3);

// RGB values must each be between 0 and 5!
YColor8 blue = ColorCode.Ansi8.RGB(0, 0, 5);
```

There is no ColorCode Preset for ANSI 24.
The reason for that is, we dont use color codes.
If you want to use presets for ANSI 24 its more convenient:
```csharp
YColor red = YColor.Red;
```

As you can see are the Presets nested inside of the YColor class.
There are all default html rgb colors to select from.

### Style
To use YColors you need a Style.
The use of styles is pretty simple:
```csharp
using YCT.Color;
using YCT.Style;

YColor lime = YColor.Lime;
Style style = new();

style.SetTextColor(lime);
style.SetBackgroundColor(YColor.Teal);

// There are to ways to activate a style:
// 1. Add to string
Console.WriteLine($"{style}This is a colored Text!");

// 2. Apply
style.Apply();
Console.WriteLine("This Text is colored!");

// Reset the colrs:
style.ResetStyle();
Console.WriteLine("This Text is no mire colored...");
```

This example is recomended for complex color Handling.
Often something like this is enough:
```csharp
Style.ApplyTextColor(YColor.Red);
Style.ApplyBackgroundColor(YColor.Gray);

Console.WriteLine("This text is red with a gray background");

Style.Reset();
```

Another Example for more complex cases.
```csharp
Style defaultText = new();
Style redText = new();
Style greenText = new();
defaultText.SetTextColor(YColor.White);
redText.SetTextColor(YColor.Red);
greenText.SetTextColor(YColor.Green);

Console.WriteLine(
    $"{redText}This{defaultText} " +
     "is red Text and " +
    $"{greenText}this{defaultText} " +
     "is green Text"
)
```
