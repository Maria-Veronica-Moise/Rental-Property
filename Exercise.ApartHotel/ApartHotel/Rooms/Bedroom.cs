using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.ApartHotel.Rooms;

public class Bedroom : Room
{
    public Bedroom(
        bool hasAirConditioning,
        ushort numberOfWindows,
        bool hasTerrace,
        bool hasBalcony,
        double areaSquareMeters,
        List<Bed> beds) : base(RoomPrivacy.Private, hasAirConditioning, numberOfWindows, hasTerrace, hasBalcony, areaSquareMeters)
    {
        Validate(beds);
        Beds = beds;
    }
    public List<Bed> Beds { get; set; }
    private void Validate(List<Bed> beds)
    {
        if (beds is null || beds.Count == 0)
        {
            throw new ArgumentException("Cannot be empty", nameof(beds));
        }
    }
}
