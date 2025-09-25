using System;
public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool IsInUSA()
    {
        return string.Equals(_country, "USA", StringComparison.OrdinalIgnoreCase) ||
               string.Equals(_country, "United States", StringComparison.OrdinalIgnoreCase) ||
               string.Equals(_country, "United States of America", StringComparison.OrdinalIgnoreCase);
    }

    public string GetFullAddress()
    {
        return $"{_street}\n{_city}, {_state}\n{_country}";
    }
}