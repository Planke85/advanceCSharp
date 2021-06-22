using System.Collections.Generic;


namespace Models
{
    public static class DbVehicles
    {
        public static List<Vehicle> Vehicles;
        static DbVehicles()
        {
            Vehicles = new List<Vehicle>
            {
                new Car("Audi", "A7", Enums.EngineEnum.Diesel, 3000, 280, Enums.TransmissionEnum.Manual, 70000),
                new Truck("Volvo","FH", Enums.EngineEnum.Diesel, 5000, 540, Enums.TransmissionEnum.Automatic, 120000, 2, true),
                new Van("Ford", "Transit", Enums.EngineEnum.Diesel, 2000, 140, Enums.TransmissionEnum.Manual, 35000, 4000),
                new Car("Opel", "Insignia", Enums.EngineEnum.Petrol, 2000, 180, Enums.TransmissionEnum.Manual, 37000),
                new Car("Volvo", "XC-60", Enums.EngineEnum.Petrol, 20000, 220, Enums.TransmissionEnum.Manual, 85000)
            };
        }
    }
}
