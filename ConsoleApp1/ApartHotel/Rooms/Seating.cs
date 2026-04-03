namespace ConsoleApp1.ApartHotel.Rooms;

public record Seating
{
    private readonly Dictionary<SeatingType, ushort> _dictionary = new()
    {
        { SeatingType.Armchair, 1 },
        { SeatingType.Loveseat, 2 },
        { SeatingType.Sofa, 3 },
        { SeatingType.Sectional, 5 }
    };

    public Seating(SeatingType seatingType)
    {
        Validate(seatingType);
        _dictionary.TryGetValue(seatingType, out ushort capacity);
        Capacity = capacity;
        SeatingType = seatingType;
    }

    public SeatingType SeatingType { get; }
    public ushort Capacity { get; }

    private void Validate(SeatingType seatingType)
    {
        if (!_dictionary.ContainsKey(seatingType))
        {
            throw new ArgumentException($"The type of {seatingType} is not supported.", nameof(seatingType));
        }
    }
}

public enum SeatingType
{
    Armchair,
    Loveseat,
    Sofa,
    Sectional
}
