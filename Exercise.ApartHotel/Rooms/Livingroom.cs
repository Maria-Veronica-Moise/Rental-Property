namespace Exercise.ApartHotel.Rooms;

public class LivingRoom : Room
{
    public LivingRoom(
        bool hasAirConditioning,
        ushort numberOfWindows,
        bool hasTerrace,
        bool hasBalcony,
        double areaSquareMeters,
        List<Seating> seatings,
        bool hasTv,
        bool hasDiningTable)
        : base(RoomPrivacy.Shared, hasAirConditioning, numberOfWindows, hasTerrace, hasBalcony, areaSquareMeters)
    {
        Validate(seatings);
        Seatings = seatings;
        HasTv = hasTv;
        HasDiningTable = hasDiningTable;
    }

    public List<Seating> Seatings { get; set; }
    public bool HasTv { get; set; }
    public bool HasDiningTable { get; set; }

    private void Validate(List<Seating> seatings)
    {
        if (seatings is null || seatings.Count == 0)
        {
            throw new ArgumentException("Cannot be empty", nameof(seatings));
        }
    }
}