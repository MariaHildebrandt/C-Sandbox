//lightweight alternative to a class
//new instances of a class is placed on the heap, where newly instantiated structs are placed on the stack
//struct can not inherit from other classes or structs, and classes can't inherit from structs.
//structs can implement custom interfaces


using System;

namespace Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car;

            car = new Car("Daimler AG", "Mercedes-Benz C-Class" ,"1993-present");
            Console.WriteLine(car.Describe());

            car = new Car("Daimler AG", "Mercedes-Benz C-Class (W204)" ,"2007-2014");
            Console.WriteLine(car.Describe());

            Console.ReadKey();
        }
    }

    struct Car
    {
        //can't have initializers like
        //private string color = "Blue";
        private string manufacturer;
        private string line;
        private string production;

        public Car(string manufacturer, string line, string production)
        {
            this.manufacturer = manufacturer;
            this.production = production;
            this.line = line;
        }

        public string Describe()
        {
            return "The " + line + " was made by " + manufacturer + " and was produced in " + production;
        }

        public string Manufacturer
        {
            get { return manufacturer; }
            set { manufacturer = value; }
        }
        
        public string Production
        {
            get { return production; }
            set { production = value; }
        }
        
        public string Line
        {
            get { return line; }
            set { line = value; }
        }
    }
}

