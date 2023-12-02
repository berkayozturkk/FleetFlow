using FleetFlow.Domain.Abstraction;

namespace FleetFlow.Domain.Entities;

public class Car : Entity<Guid>
{
    public Guid BrandID { get; set; }
    public Brand Brand { get; set; }
    public string Model { get; set; }
    public string CoverImageUrl { get; set; }
    public int Km { get; set; }
    public string Transmission { get; set; }
    public byte Seat { get; set; }
    public byte Luggage { get; set; }
    public string Fuel { get; set; }
    public string BigImageUrl { get; set; }
    public List<CarFeature> CarFeatures { get; set; }
    public List<CarDescription> CarDescriptions { get; set; }
    public List<CarPricing> CarPricings { get; set; }

    public Car() {}
    public Car(Guid id, Guid brandId, string model, 
        string coverImageUrl, int km, string transmission, 
        byte seat, byte luggage, string fuel, string bigImageUrl) : base(id)
    {
        BrandID = brandId;
        Model = model;
        CoverImageUrl = coverImageUrl;
        Km = km;
        Transmission = transmission;
        Seat = seat;
        Luggage = luggage;
        Fuel = fuel;
        BigImageUrl = bigImageUrl;
    }
}
