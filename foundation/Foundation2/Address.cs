using System;

public class Address
{
    private string _street;
    private string _city;
    private string _state_province;
    private string _country;

    public Address(string street, string city, string state_province, string country)
    {
        _street = street;
        _city = city;
        _state_province = state_province;
        _country = country;
    }

    public bool IsUSA()
    {
        if (_country == "USA")
        {
            return true;
        }
        return false;
    }

    public string GetAddress()
    {
        return $"{_street}\n{_city}, {_state_province}\n{_country}";
    }
}