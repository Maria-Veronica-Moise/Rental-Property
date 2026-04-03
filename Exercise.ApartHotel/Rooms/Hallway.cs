namespace Exercise.ApartHotel.Rooms;

public class Hallway : Room
{
    public Hallway(bool hasAirConditioning,
        ushort numberOfWindows,
        bool hasTerrace,
        bool hasBalcony,
        double areaSquareMeters,
        ushort numberOfDoors,
        bool hasElevatorAcces) : base(RoomPrivacy.Shared, hasAirConditioning, numberOfWindows, hasTerrace, hasBalcony, areaSquareMeters)
    {
        Validate(numberOfDoors);
        NumberOfDoors = numberOfDoors;
        HasElevatorAccess = hasElevatorAcces;
    }
    public ushort NumberOfDoors { get; set; }
    public bool HasElevatorAccess { get; set; }

    private void Validate(ushort numberOfDoors)
    {
        if (numberOfDoors > 20)
        {
            throw new ArgumentException("Cannot be greater than 20", nameof(numberOfDoors));
        }
    }
}
