using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkW2.ConsoleApp
{//Interface Segregation Principle
    //ISP ye göre ilgili üst ınterface, kalıtım yapılacak tüm sınıfların ortak özelliklerini tanımlamalı
    //Buna göre Bizim Taşıt interface'imizde Genel Anlamda tüm araçarda olabilecek proplar yazılır
    public interface IVehicle
    {
        public string Name { get; set; }
        public string EngineType { get; set; }
        public string EngineVolume { get; set; }
        public string InternalVolume { get; set; }
        public int TotalPassenger { get; set; }
    }
    //Sınıflarda o araçlara özel olan Propertyler eklenir
    public class Automobile : IVehicle
    {
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string EngineType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string EngineVolume { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string InternalVolume { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int TotalPassenger { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        //__________________________________________________
        public string AutomobileType { get; set; }
        public string NumberOfDoors { get; set; }
        public bool IsHaveSunroof { get; set; }
    }
    public class Caravan : IVehicle
    {
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string EngineType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string EngineVolume { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string InternalVolume { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int TotalPassenger { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        //-----------------------------------------
        public string furniture { get; set; }
        public int CleanWaterTankVolume { get; set; }
        public string BedSize { get; set; }
    }
    public class truck : IVehicle
    {
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string EngineType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string EngineVolume { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string InternalVolume { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int TotalPassenger { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        ///-------------------------------------------
        public int LoadCarryingCapacity { get; set; }
        public int WheelNumber { get; set; }
        public bool IsHaveDamper { get; set; }
    }
}
