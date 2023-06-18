using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{
    public class AbstractFactoryDesignPattern
    {
        static void Main(string[] args)
        {
            VehicleCompany teslaCarCompany = new TeslaCompanys();
            ICars teslaCar = teslaCarCompany.GetCar();
            IBikes teslaBikes = teslaCarCompany.GetBikes();

            VehicleCompany tataCarCompany = new TataCompanys();
            ICars tataCars = tataCarCompany.GetCar();
            IBikes tatBikes = tataCarCompany.GetBikes();
        }
    }
    public interface ICars
    {
        public void Manufacture();
    }
    public interface IBikes
    {
        public void Manufacture();
    }
    public class TataCars : ICars
    {
        public void Manufacture() { }
    }
    public class TataBikes : IBikes
    {
        public void Manufacture() { }
    }
    public class TeslaCars : ICars
    {
        public void Manufacture() { }
    }
    public class TeslaBikes : IBikes
    {
        public void Manufacture() { }
    }

    //This abstract factory which will return factory of similar objects.
    //Ex. Tata, Tesla, Maruti, Honda, Hundai, Ford.
    public abstract class VehicleCompany
    {
        public abstract ICars GetCar();
        public abstract IBikes GetBikes();
    }
    public class TeslaCompanys:VehicleCompany
    {
        public override ICars GetCar()
        {
            return new TeslaCars();
        }
        public override IBikes GetBikes()
        {
            return new TeslaBikes();
        }
    }
    public class TataCompanys : VehicleCompany
    {
        public override ICars GetCar()
        {
            return new TataCars();
        }
        public override IBikes GetBikes()
        {
            return new TataBikes();
        }
    }
}
