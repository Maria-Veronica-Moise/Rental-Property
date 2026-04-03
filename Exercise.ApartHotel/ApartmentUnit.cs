using Exercise.ApartHotel.Rooms;
using System.ComponentModel.DataAnnotations;

namespace Exercise.ApartHotel;

public class ApartmentUnit
{
    public const ushort MaxNameLength = 200;
    public const ushort MaxNumberLength = 5;
    public ApartmentUnit(List<Room> rooms, string apartmentName, string apartmentNumber)
    {
        // learn topics: exceptions until chapter 5, linq until chapter 8, validating strings (use chatgpt)
        // after create a private void method called Validate, pass all parameters from the constructor and move validation logic there:
        // private void Validate(List<Room> rooms, string apartmentName, string apartmentNumber){...}
        Validate(rooms, apartmentName, apartmentNumber);
        Rooms = rooms;
        ApartmentName = apartmentName;
        ApartmentNumber = apartmentNumber;
    }

    List <Room> Rooms { get; set; }
    public string ApartmentName { get; set; }
    public string ApartmentNumber { get; set; }
    public double AreaSquareMeters => Rooms.Sum(x => x.AreaSquareMeters);

    private void Validate(List<Room> rooms, string apartmentName, string apartmentNumber)
    {
        if (rooms is null || rooms.Count == 0)
        {
            throw new ArgumentException("Cannot be empty", nameof(rooms));
        }
        // special syntax to check concrete type with inheritance.
        if (!rooms.Any(x => x is Bedroom))
        {
            throw new ArgumentException("There should be at least one bedroom", nameof(rooms));
        }
        if (string.IsNullOrWhiteSpace(apartmentName))
        {
            throw new ArgumentException("Cannot be empty", nameof(apartmentName));
        }
        if (apartmentName.Length > MaxNameLength)
        {
            throw new ArgumentException($"Cannot be longer than {MaxNameLength} characters", nameof(apartmentName));
        }
        if (string.IsNullOrWhiteSpace(apartmentNumber))
        {
            throw new ArgumentException("Cannot be empty", nameof(apartmentNumber));
        }
        if (apartmentNumber.Length > MaxNumberLength)
        {
            throw new ArgumentException($"Cannot be longer than {MaxNumberLength}", nameof(apartmentNumber));
        }
    }
}