namespace ConsoleApp1.ApartHotel;

public class RentalProperty
{
    public const ushort MaxNameLength = 200;
    public RentalProperty(
            string name,
            Address address,
            List<PropertyFloor> floors)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentNullException(nameof(name), "Cannot be empty");
        }
        if (name.Length > MaxNameLength)
        {
            throw new ArgumentException($"Cannot be longer than {MaxNameLength} characters", nameof(name));
        }
        if (address is null)
        {
            throw new ArgumentNullException(nameof(address));
        }
        if (floors is null || floors.Count == 0)
        {
            throw new ArgumentException("There should be at least one floor.", nameof(floors));
        }

        Name = name;
        Address = address;
        Floors = floors;
    }

    public string Name { get; set; }
    public Address Address { get; set; }
    public List<PropertyFloor> Floors { get; set; }
    public int TotalFloors => Floors.Count;
    public int TotalApartments => Floors.Sum(f => f.TotalApartments);
}
