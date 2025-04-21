using YCT.Color;

namespace YCT.Style;

// ESC -> \x1b
public class Style
{
    private string _foreground;
    private string _backGround;

    public string _escapeCode() => _foreground + _backGround;

    public Style()
    {
        _foreground = string.Empty;
        _backGround = string.Empty;
    }

    public void SetTextColor(YColor3 color)
    {
        _foreground = $"\x1b[{color.color}m";
    }
    public void SetTextColor(YColor4 color)
    {
        _foreground = $"\x1b[{color.color}m";
    }
    public void SetTextColor(YColor8 color)
    {
        _foreground = $"\x1b[38:5:{color.color}m";
    }
    public void SetTextColor(YColor color)
    {
        _foreground = $"\x1b[38;2;{color.red};{color.green};{color.blue}m";
    }

    public void SetBackgroundColor(YColor3 color)
    {
        _backGround = $"\x1b[{color.color}m";
    }
    public void SetBackgroundColor(YColor4 color)
    {
        _backGround = $"\x1b[{color.color}m";
    }
    public void SetBackgroundColor(YColor8 color)
    {
        _backGround = $"\x1b[48:5:{color.color}m";
    }
    public void SetBackgroundColor(YColor color)
    {
        _backGround = $"\x1b[48;2;{color.red};{color.green};{color.blue}m";
    }

    public void Apply()
    {
        Console.Write(_escapeCode());
    }

    public void ResetStyle()
    {
        Console.WriteLine("\x1b[m");
        Console.SetCursorPosition(0, Console.CursorTop - 1);
        Console.Write("\x1b[2K");
    }

    public override string ToString() => _escapeCode();

    // Static Methods
    public static void ApplyTextColor(YColor color)
    {
        Console.Write($"\x1b[38;2;{color.red};{color.green};{color.blue}m");
    }

    public static void ApplyBackgroundColor(YColor color)
    {
        Console.Write($"\x1b[48;2;{color.red};{color.green};{color.blue}m");
    }
    public static void Reset()
    {
        Console.WriteLine("\x1b[m");
        Console.SetCursorPosition(0, Console.CursorTop - 1);
        Console.Write("\x1b[2K");
    }
}
