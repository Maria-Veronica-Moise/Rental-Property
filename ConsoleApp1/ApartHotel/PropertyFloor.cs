namespace ConsoleApp1.ApartHotel;

public class PropertyFloor
{
    public const ushort MaxFloorNumber = 200;
    public const short MinFloorNumber = -100;
    public FloorType FloorType { get; set; }

    public short FloorNumber { get; set; }


    public PropertyFloor(FloorType floortype, short floorNumber)
    {
        Validate(floortype, floorNumber);
        FloorType = floortype;
        FloorNumber = floorNumber;
    }

    public List<ApartmentUnit> Apartments { get; set; } = new List<ApartmentUnit>();

    public int TotalApartments => Apartments.Count;

    private void Validate(FloorType floorType, short floorNumber)
    {
        if (floorNumber > MaxFloorNumber)
        {
            throw new ArgumentOutOfRangeException(nameof(floorNumber), $"{nameof(floorNumber)} cannot be greater than {MaxFloorNumber}");
        }
        if (floorNumber < MinFloorNumber)
        {
            throw new ArgumentOutOfRangeException(nameof(floorNumber), $"{nameof(floorNumber)} cannot be smaller than {MinFloorNumber}");
        }
        if (floorType == FloorType.Basement && floorNumber >= 0)
        {
            throw new ArgumentException($"{nameof(floorType)} is {FloorType.Basement} and {nameof(floorNumber)} is => 0");
        }
        if (floorType == FloorType.Attic && floorNumber <= 0)
        {
            throw new ArgumentException($"{nameof(floorType)} is {FloorType.Attic} and {nameof(floorNumber)} is <= 0");
        }
        if (floorType == FloorType.Normal && floorNumber > 0)
        {
            throw new ArgumentException($"{nameof(floorType)} is {FloorType.Normal} and {nameof(floorNumber)} is > 0");
        }
    }
}
public enum FloorType
{
    Basement,
    Normal,
    Attic
}
