using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise.ApartHotel.Rooms;

public record Bed
{
    private readonly Dictionary<BedType, ushort> _dictionary = new()
    {
        {BedType.Single, 1 },
        {BedType.Double, 2 },
        {BedType.Queen, 2 },
        {BedType.Murphy, 2 },
        {BedType.King, 2  }
    };


    public Bed(BedType bedType)
    {
        bool isFound = _dictionary.TryGetValue(bedType, out ushort numberOfPersons);
        Validate(bedType);
        NumberOfPersons = numberOfPersons;
        BedType = bedType;
    }

    public BedType BedType { get; }
    public ushort NumberOfPersons { get; }
    private void Validate(BedType bedType)
    {
        if (!_dictionary.ContainsKey(bedType))
        {
            throw new ArgumentException($"The type of {bedType} is not supported.", nameof(bedType));
        }
    }
}
public enum BedType
{
    Single,
    Double,
    Queen,
    Murphy,
    King
}



