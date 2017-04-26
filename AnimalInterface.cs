//consider an interface as a contract 
//a class that implements it is required to implement all of the methods and properties

//C# does not allow multiple inheritence but allows implementation of multiple interfaces

// no:(public, private, protected etc.)--  because  not allowed in an interface

using System;
using System.Collections.Generic;

namespace Interfaces
{
    
    class Programm
    {
        
        static void Main( string[] args )
        {
            List<Bird> birds = new List<Bird>();
            birds.Add( new Bird("Fabian"));
            birds.Add( new Bird("Frodo"));
            birds.Add( new Bird("Adam"));
            //how does the list know how to sort birds?-> Bird class has a CompareTo method.
            birds.Sort();
            
            foreach( Bird bird in birds ){
                Console.WriteLine(bird.Describe());
            }
            Console.ReadKey();
        }
    }
    
    interface IAnimal
    {
        string Describe();
        
        string Name
        {
            get;
            set;
        }
    }
    
    //.NET IComparable interface
    class Bird : IAnimal, IComparable
    {
        private string name;
        
        //Constructor
        public Bird( string name)
        {
            this.Name = name;
        }
        
        public string Describe()
        {
            return "Hello, I'm a bird and my name is " + this.Name;
        }
        
        public int CompareTo(object obj)
        {
            if(obj is IAnimal){
                return this.Name.CompareTo((obj as IAnimal).Name);
            }
            return 0;
        }
        
        public string Name
        {
            get { return name;}
            set { name = value;}
        }
    }
}
