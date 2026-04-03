using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.ApartHotel.Rooms;

public class Room
{
    public Room(RoomPrivacy roomPrivacy, bool hasAirConditioning, int numberOfWindows, bool hasTerrace, bool hasBalcony, double areaSquareMeters)
    {
        RoomPrivacy = roomPrivacy;
        HasAirConditioning = hasAirConditioning;
        NumberOfWindows = numberOfWindows;
        HasTerrace = hasTerrace;
        HasBalcony = hasBalcony;
        AreaSquareMeters = areaSquareMeters;
    }

    public RoomPrivacy RoomPrivacy { get; set; }

    public bool HasAirConditioning { get; set; }

    public int NumberOfWindows { get; set; }

    public bool HasTerrace { get; set; }

    public bool HasBalcony { get; set; }

    public double AreaSquareMeters { get; set; }
}
public enum RoomPrivacy
{
    Shared,
    Private
}
