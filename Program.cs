using System;

namespace Class2DZ
{   
    
    class Program
    {
        static void Main(string[] args)
        {
            
            BMW bmw = new BMW();
            bmw.PrintCar();
            Mercedes mercedes = new Mercedes();
            mercedes.PrintCar();
        }
    }
    
    public class Car
    {
        public string Model;
        public string Color;
        public int Year;
        private string Type;
        protected int HorsePower;
        public void PrintCar()
        {
            Console.WriteLine("{0} {1} {2} {3} {4}", Model, Color, Year, Type, HorsePower);
        }

        protected void SetType(string type)
        {
            Type = type;
        }
    }

    public class BMW : Car
    {
        public BMW()
        {
            Model = "M3 Sedan";
            Color = "Black";
            Year = 2022;
            SetType("Sedan"); 
            HorsePower = 473;
        }
        
    }
    public class Mercedes : Car
    {
        public Mercedes()
        {
            Model = "C-Class";
            Color = "White";
            Year = 2015;
            SetType("Sedan");
            HorsePower = 375;
        }
        
    }
}