using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{
    public interface ICar
    {
        void Start();
    }
    public class SixSeaterCar : ICar
    {
        public void Start() { Console.WriteLine("Six Seater Car"); }
    }
    public class FourSeaterCar : ICar
    {
        public void Start() { Console.WriteLine("Four Seater Car"); }
    }
    public class CarFactory
    {
        public ICar GetCar(string carType)
        {
            switch(carType)
            {
                case "SixSeater":
                    return new SixSeaterCar();
                case "FourSeater":
                    return new FourSeaterCar();
                    default : return null;
            }
        }
    }
    public class FactoryDesignPattern
    {
        static void Main1(string[] args)
        {
            CarFactory carFactory = new CarFactory();

            ICar sixSeater = carFactory.GetCar("SixSeater");
            sixSeater.Start();
            ICar fourSeater = carFactory.GetCar("FourSeater");
            fourSeater.Start();
            Console.ReadLine();
        }
    }
    
}
