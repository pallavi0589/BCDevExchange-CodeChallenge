using Microsoft.EntityFrameworkCore;
using service.transport.common.Entity;

namespace service.transport.data;

public class TransportDbContext : DbContext
{
    public DbSet<TransportationOption> TransportationOptions { get; set; }
    public DbSet<Booking> Bookings { get; set; }

    public TransportDbContext(DbContextOptions<TransportDbContext> options)
        : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        Seed(modelBuilder);

        base.OnModelCreating(modelBuilder);
    }

    private void Seed(ModelBuilder modelBuilder)
    {
        // Seed data
        modelBuilder.Entity<TransportationOption>().HasData(
        new TransportationOption
        {
            Id = 1,
            Description = "Sample Option 1",
            ProviderName = "Provider 1",
            VehicleType = "Car",
            Price = 50.00m,
            Duration = "2 hours",
            Origin = "City A",
            Destination = "City B",
            Date = "2024-01-21",
            Time = "08:00:00"
        },
        new TransportationOption
        {
            Id = 2,
            Description = "Sample Option 2",
            ProviderName = "Provider 2",
            VehicleType = "Bus",
            Price = 30.00m,
            Duration = "3 hours",
            Origin = "City A",
            Destination = "City C",
            Date = "2024-01-21",
            Time = "08:00:00"
        },
        new TransportationOption
        {
            Id = 3,
            Description = "Sample Option 3",
            ProviderName = "Provider 3",
            VehicleType = "Train",
            Price = 75.00m,
            Duration = "1.5 hours",
            Origin = "City B",
            Destination = "City D",
            Date = "2024-01-21",
            Time = "08:00:00"
        },
        new TransportationOption
        {
            Id = 4,
            Description = "Sample Option 4",
            ProviderName = "Provider 4",
            VehicleType = "Airplane",
            Price = 150.00m,
            Duration = "1 hour",
            Origin = "City C",
            Destination = "City D",
            Date = "2024-01-21",
            Time = "08:00:00"
        },
        new TransportationOption
        {
            Id = 5,
            Description = "Sample Option 5",
            ProviderName = "Provider 5",
            VehicleType = "Boat",
            Price = 80.00m,
            Duration = "4 hours",
            Origin = "City D",
            Destination = "City A",
            Date = "2024-01-21",
            Time = "08:00:00"
        });

        //base.OnModelCreating(modelBuilder);
    }
}

