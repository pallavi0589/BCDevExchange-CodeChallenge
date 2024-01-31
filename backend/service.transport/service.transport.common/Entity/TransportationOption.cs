using System;
namespace service.transport.common.Entity;

public class TransportationOption
{
    public int Id { get; set; }
    public string Description { get; set; }
    public string ProviderName { get; set; }
    public string VehicleType { get; set; }
    public decimal Price { get; set; }
    public string Duration { get; set; }
    public string Origin { get; set; }
    public string Destination { get; set; }
    public string Date { get; set; }
    public string Time { get; set; }
}

