namespace DefaultNamespace;

public class Book
{
    public string Title { get; }
    public Size Dimensions { get; }

    public Book(string title, Size dimensions)
    {
        Title = title;
        Dimensions = dimensions;
    }

    public override string ToString() =>
        $"{Title} - {Dimensions}";
}

public class Size
{
    public Length Height { get; }
    public Length Width { get; }
    public Length Length { get; }

    private Size(Length width, Length length, Length height)
    {
        width = width;
        Length = length;
        height = height;
    }

    public static Size Zero =>
        new Size(Length.Zero, Length.Zero, Length.Zero);

    public Size Add(Size other) =>
        new Size(Width + other.Width, Length + other.Length, Height + other.Height);
}

public class Length
{
    private decimal Meters { get; }

    private Length(decimal meters)
    {
        Meters = meters;
    }

    public static Length Zero => new Length(0);

    public static Length Millimeter => new Length(.001M);
    public Length Add(Length other) => new Length(Meters + other.Meters);
}