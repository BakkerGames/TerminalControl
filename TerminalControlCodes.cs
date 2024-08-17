namespace TerminalControl;

/// <summary>
/// This is a library of terminal control routines using ANSI escape codes for use in Console applications.
/// </summary>
public static class TerminalControlCodes
{
    private const string ESCB = "\u001B[";

    /// <summary>
    /// Clear the screen, leaving the cursor in the top left corner.
    /// </summary>
    public static void ClearScreen()
    {
        CursorAt(1, 1);
        Console.Write($"{ESCB}J");
    }

    /// <summary>
    /// Move the cursor to the specified position. (1,1) is top left.
    /// Cursor will stop at the right or bottom edges of the screen.
    /// </summary>
    /// <param name="row">1-based row number. Set to 1 if 0 or negative.</param>
    /// <param name="col">1=based column number. Set to 1 if 0 or negative.</param>
    public static void CursorAt(int row, int col)
    {
        if (row < 1) row = 1;
        if (col < 1) col = 1;
        Console.Write($"{ESCB}{row};{col}H");
    }

    /// <summary>
    /// Move the cursor up a number of rows, stopping at the top of the screen.
    /// </summary>
    /// <param name="rows">Number of rows. Defaults to 1.</param>
    public static void CursorUp(int rows = 1)
    {
        if (rows < 1) rows = 1;
        Console.Write($"{ESCB}{rows}A");
    }

    /// <summary>
    /// Move the cursor down a number of rows, stopping at the bottom of the screen.
    /// </summary>
    /// <param name="rows">Number of rows. Defaults to 1.</param>
    public static void CursorDown(int rows = 1)
    {
        if (rows < 1) rows = 1;
        Console.Write($"{ESCB}{rows}B");
    }

    /// <summary>
    /// Move the cursor right a number of columns, stopping at the right edge of the screen.
    /// </summary>
    /// <param name="cols">Number of columns. Defaults to 1.</param>
    public static void CursorRight(int cols = 1)
    {
        if (cols < 1) cols = 1;
        Console.Write($"{ESCB}{cols}C");
    }

    /// <summary>
    /// Move the cursor left a number of columns, stopping at the left edge of the screen.
    /// </summary>
    /// <param name="cols">Number of columns. Defaults to 1.</param>
    public static void CursorLeft(int cols = 1)
    {
        if (cols < 1) cols = 1;
        Console.Write($"{ESCB}{cols}D");
    }

    /// <summary>
    /// Clear all attributes back to default, such as colors.
    /// </summary>
    public static void ClearAttributes()
    {
        Console.Write($"{ESCB}0m");
    }

    /// <summary>
    /// Set the foreground color.
    /// </summary>
    /// <param name="red">Red value, 0-255.</param>
    /// <param name="green">Green value, 0-255.</param>
    /// <param name="blue">Blue value, 0-255.</param>
    public static void SetFGColor(int red, int green, int blue)
    {
        if (red < 0) red = 0;
        if (red > 255) red = 255;
        if (green < 0) green = 0;
        if (green > 255) green = 255;
        if (blue < 0) blue = 0;
        if (blue > 255) blue = 255;
        Console.Write($"{ESCB}38;2;{red};{green};{blue}m");
    }

    /// <summary>
    /// Set the background color.
    /// </summary>
    /// <param name="red">Red value, 0-255.</param>
    /// <param name="green">Green value, 0-255.</param>
    /// <param name="blue">Blue value, 0-255.</param>
    public static void SetBGColor(int red, int green, int blue)
    {
        if (red < 0) red = 0;
        if (red > 255) red = 255;
        if (green < 0) green = 0;
        if (green > 255) green = 255;
        if (blue < 0) blue = 0;
        if (blue > 255) blue = 255;
        Console.Write($"{ESCB}48;2;{red};{green};{blue}m");
    }
}
