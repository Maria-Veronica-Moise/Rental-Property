using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise.ApartHotel.Rooms;

public class Bathroom : Room
{
    public Bathroom(
        bool hasAirConditioning,
        ushort numberOfWindows,
        bool hasTerrace,
        bool hasBalcony,
        double areaSquareMeters,
        BathroomType bathroomType,
        List<BathroomFixture> fixtures,
        ushort numberOfSinks)
        : base(GetPrivacy(bathroomType), hasAirConditioning, numberOfWindows, hasTerrace, hasBalcony, areaSquareMeters)
    {
        Validate(fixtures, numberOfSinks);
        BathroomType = bathroomType;
        Fixtures = fixtures;
        NumberOfSinks = numberOfSinks;
    }

    public BathroomType BathroomType { get; set; }
    public List<BathroomFixture> Fixtures { get; set; }
    public ushort NumberOfSinks { get; set; }

    private static RoomPrivacy GetPrivacy(BathroomType type)
    {
        if (type == BathroomType.Ensuite)
        {
            return RoomPrivacy.Private;
        }

        return RoomPrivacy.Shared;
    }

    private void Validate(List<BathroomFixture> fixtures, ushort sinks)
    {
        if (fixtures is null || fixtures.Count == 0)
        {
            throw new ArgumentException("Bathroom must contain at least one fixture.", nameof(fixtures));
        }
    }
}
public enum BathroomType
{
    Ensuite,
    Shared,
    Guest
}
