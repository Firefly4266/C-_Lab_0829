//PolicyDefinitions.cs

using System;

interface IStructure
{
    string DwellingType { get; }
    string ParcelId { get; }
    int PostalCode { get; }
}
interface IWheels
{
    string Vin { get; }
    string VehicleType { get; }
}