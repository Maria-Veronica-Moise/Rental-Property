namespace Exercise.ApartHotel;

public record Address
{
    public const ushort MaxNameLength = 100;
    public const ushort MaxNumberLength = 50;
    public string Street { get; }
    public string HouseNumber { get; }
    public string City { get; }
    public string State { get; }
    public string PostalCode { get; }
    public string Country { get; }

    public Address(string street, string houseNumber, string city, string state, string postalCode, string country)
    {
        Validate(street, houseNumber, city, state, postalCode, country);
        Street = street;
        HouseNumber = houseNumber;
        City = city;
        State = state;
        PostalCode = postalCode;
        Country = country;
    }

    private void Validate(string street, string houseNumber, string city, string state, string postalCode, string country)
    {
        if (string.IsNullOrWhiteSpace(street))
        {
            throw new ArgumentException("Cannot be empty", nameof(street));
        }
        if (string.IsNullOrWhiteSpace(houseNumber))
        {
            throw new ArgumentException("Cannot be empty", nameof(houseNumber));
        }
        if (string.IsNullOrWhiteSpace(city))
        {
            throw new ArgumentException("Cannot be empty", nameof(city));
        }
        if (string.IsNullOrWhiteSpace(state))
        {
            throw new ArgumentException("Cannot be empty", nameof(state));
        }
        if (string.IsNullOrWhiteSpace(postalCode))
        {
            throw new ArgumentException("Cannot be empty", nameof(postalCode));
        }
        if (string.IsNullOrWhiteSpace(country))
        {
            throw new ArgumentException("Cannot be empty", nameof(country));
        }
        if (street.Length > MaxNameLength)
        {
            throw new ArgumentException($"Cannot be longer than {MaxNameLength} characters", nameof(street));
        }
        if (houseNumber.Length > MaxNumberLength)
        {
            throw new ArgumentException($"Cannot be longer than {MaxNumberLength} characters", nameof(houseNumber));
        }
        if (city.Length > MaxNameLength)
        {
            throw new ArgumentException($"Cannot be longer than {MaxNameLength} characters", nameof(city));
        }
        if (state.Length > MaxNameLength)
        {
            throw new ArgumentException($"Cannot be longer than {MaxNameLength} characters", nameof(state));
        }
        if (postalCode.Length > MaxNumberLength)
        {
            throw new ArgumentException($"Cannot be longer than {MaxNumberLength} characters", nameof(postalCode));
        }
        if (country.Length > MaxNameLength)
        {
            throw new ArgumentException($"Cannot be longer than {MaxNameLength} characters", nameof(country));
        }
    }
}
