using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{
    public class FactoryMethodDesignPattern
    {
        static void Main1(string[] args)
        {
            CarCompany teslaCompany = new TeslaCompany();
            IVehicle teslCar = teslaCompany.ProduceVehicle("Car");
            IVehicle teslaBike = teslaCompany.ProduceVehicle("Bike");

            CarCompany tataCompany = new TataCompany();
            IVehicle tataCar = tataCompany.ProduceVehicle("Car");
            IVehicle tataBike = tataCompany.ProduceVehicle("Bike");
        }
    }
    public interface IVehicle
    {
        public void Manufacture();
    }
    public class TataCar:IVehicle
    {
        public void Manufacture() { }
    }
    public class TataBike : IVehicle
    {
        public void Manufacture() { }
    }
    public class TeslaCar : IVehicle
    {
        public void Manufacture() { }
    }
    public class TeslaBike : IVehicle
    {
        public void Manufacture() { }
    }
    public abstract class CarCompany
    {
        public IVehicle ProduceVehicle(string vehicleType)
        {
            IVehicle vehicle = ManufactureVehicle(vehicleType);
            vehicle.Manufacture();
            return vehicle;
        }
        protected abstract IVehicle ManufactureVehicle(string vehicleType);
    }
    public class TeslaCompany:CarCompany
    {
        protected override IVehicle ManufactureVehicle(string vehicleType)
        {
            if (vehicleType == "Car")
            {
                return new TeslaCar();
            }
            else
                return new TeslaBike();
        }
    }
    public class TataCompany : CarCompany
    {
        protected override IVehicle ManufactureVehicle(string vehicleType)
        {
            if (vehicleType == "Car")
            {
                return new TataCar();
            }
            else
                return new TataBike();
        }
    }
}
