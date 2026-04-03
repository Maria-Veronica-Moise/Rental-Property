namespace ConsoleApp1.ApartHotel.Rooms;

public record BathroomFixture
{
    public BathroomFixture(BathroomFixtureType type)
    {
        FixtureType = type;
    }

    public BathroomFixtureType FixtureType { get; }
}


public enum BathroomFixtureType
{
    Sink,
    Toilet,
    Shower,
    Bathtub,
    Bidet,
    Urinal
}