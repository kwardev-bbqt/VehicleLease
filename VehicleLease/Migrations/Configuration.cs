namespace VehicleLease.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using VehicleLease.Models.Context;
    using VehicleLease.Models.Domain;

    internal sealed class Configuration : DbMigrationsConfiguration<VehicleLease.Models.Context.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(VehicleLease.Models.Context.ApplicationDbContext context)
        {
            // -------- Suppliers --------
            var supplier1 = new Supplier { Name = "FleetCorp" };
            var supplier2 = new Supplier { Name = "AutoKing" };
            var supplier3 = new Supplier { Name = "DriveMax Rentals" };

            context.Suppliers.AddOrUpdate(s => s.Name, supplier1, supplier2, supplier3);

            // -------- Clients --------
            var client1 = new Client { CompanyName = "Rosond Ltd." };
            var client2 = new Client { CompanyName = "MediTrans Logistics" };
            var client3 = new Client { CompanyName = "Greenfield Mining" };

            context.Clients.AddOrUpdate(c => c.CompanyName, client1, client2, client3);

            // -------- Drivers --------
            var driver1 = new Driver { FullName = "Thabo Mokoena", LicenseNumber = "GP123456" };
            var driver2 = new Driver { FullName = "Zanele Khumalo", LicenseNumber = "KZN654321" };
            var driver3 = new Driver { FullName = "Johan Botha", LicenseNumber = "WC111222" };

            context.Drivers.AddOrUpdate(d => d.LicenseNumber, driver1, driver2, driver3);

            // -------- Branches  --------
            var branch1 = new Branch { Location = "Johannesburg", Region = "Gauteng" };
            var branch2 = new Branch { Location = "Durban", Region = "KwaZulu-Natal" };
            var branch3 = new Branch { Location = "Cape Town", Region = "Western Cape" };

            context.Branches.AddOrUpdate(b => b.Location, branch1, branch2, branch3);

            context.SaveChanges();

            // -------- Vehicles --------
            context.Vehicles.AddOrUpdate(v => new { v.Make, v.Model },
                new Vehicle
                {
                    Make = "Toyota",
                    Model = "Hilux",
                    SupplierId = supplier1.SupplierId,
                    BranchId = branch1.BranchId,
                    ClientId = client1.ClientId,
                    DriverId = driver1.DriverId
                },
                new Vehicle
                {
                    Make = "Ford",
                    Model = "Ranger",
                    SupplierId = supplier2.SupplierId,
                    BranchId = branch2.BranchId,
                    ClientId = client2.ClientId,
                    DriverId = driver2.DriverId
                },
                new Vehicle
                {
                    Make = "Isuzu",
                    Model = "D-Max",
                    SupplierId = supplier3.SupplierId,
                    BranchId = branch3.BranchId,
                    ClientId = client3.ClientId,
                    DriverId = driver3.DriverId
                },
                new Vehicle
                {
                    Make = "Nissan",
                    Model = "Navara",
                    SupplierId = supplier1.SupplierId,
                    BranchId = branch1.BranchId,
                    ClientId = client2.ClientId,
                    DriverId = driver2.DriverId
                },
                new Vehicle
                {
                    Make = "Volkswagen",
                    Model = "Amarok",
                    SupplierId = supplier2.SupplierId,
                    BranchId = branch3.BranchId,
                    ClientId = client1.ClientId,
                    DriverId = driver1.DriverId
                }
            );

            context.SaveChanges();

            context.Branches.AddOrUpdate(b => b.Location,
                new Branch { Location = "Polokwane", Region = "Limpopo" },
                new Branch { Location = "Bloemfontein", Region = "Free State" },
                new Branch { Location = "Pretoria", Region = "Gauteng" },
                new Branch { Location = "Pietermaritzburg", Region = "KwaZulu-Natal" },
                new Branch { Location = "George", Region = "Western Cape" },
                new Branch { Location = "Nelspruit", Region = "Mpumalanga" },
                new Branch { Location = "Kimberley", Region = "Northern Cape" }
            );

            context.SaveChanges();
        }



    }
}
