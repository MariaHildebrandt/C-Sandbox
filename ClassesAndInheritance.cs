using System;
namespace HousePropertyApplication
{
    class Output
    {
        static void Main(string[] args)
        {
            Console.WriteLine("App for Landlords.");
            //to end app with spacekey
            //Console.ReadKey();
            
            House house = new House(210.25, 1200, "Herne", "Mustermann", false);
            house.setRented(true);
            house.printHouseInforamtion();
            Console.WriteLine("Rent for this house is: {0} Euros", house.getRent());
            
            Person Max = new Person("Max" , "Mustermann", "male");
            Max.hello();
            
            //Resident Class inherits from Person:
            Resident Linda = new Resident("Linda", "Fielmann", "female", "Developer");
            //override function
            Linda.hello();
            //function from parent class
            Console.WriteLine("My Name is {0}", Linda.getName());
            //function from child class
            Console.WriteLine("I am working as a{0}", Linda.getOccupation());
            
            //Employee Class inherits from Resident:
            Employee Michael = new Employee("Michael", "Fielmann", "male", "Landlord", 3200);
            Michael.hello();
            Console.WriteLine("My Name is {0}. I am working as a {1} for {2} Euros a month", Michael.getName(),Michael.getOccupation(), Michael.getMonthlyIncome());
        }
    }
    
    
    /**************/
    /*  Classes  */
    /*************/
    
    
    public class House{
        //house variables
        private double squareMeters;
        private double rent;
        private String location;
        private String familyName;
        private bool rented = false;
        
        //Constructor
        public House( double squareMeters, double rent, String location, String familyName, bool rented){
            this.squareMeters = squareMeters;
            this.rent = rent;
            this.location = location;
            this.familyName = familyName;
            this.rented = rented;
            
            Console.WriteLine("House is being created at: , location = {0}", location);
        }
        
        //Destructor
        ~House(){
            Console.WriteLine("House is being deleted");
        }
        
        //Getters and Setters for variables
        
        //squareMeters
        public void setSquareMeters( double squareMeters ){
            this.squareMeters = squareMeters;
            
        }
        
        public double getSquareMeters(){
            return squareMeters;
            
        }
        
        //Rent
        public void setRent( double rent ){
            this.rent = rent;
            
        }
        public double getRent(){
            return rent;
            
        }
        
        //Location
        public void setLocation( String location ){
            this.location = location;
            
        }
        public String getLocation(){
            return location;
            
        }
        
        //familyName
        public void setFamilyName( String familyName ){
            this.familyName = familyName;
            
        }
        public string getFamilyName(){
            return familyName;
            
        }
        
        //rent
        public void setRented( bool status ){
            this.rented = status;
            
        }
        public string isRented(){
            if(rented){
                return "yes";
            }else{
                return "no";
            }
        }
        
        
        //output function
        public void printHouseInforamtion(){
            Console.WriteLine("Rent: {0}", rent);
            Console.WriteLine("Location: {0}", location);
            Console.WriteLine("SquareMeters: {0}",squareMeters);
            Console.WriteLine("Name of Family: {0}", familyName);
            Console.WriteLine("Rented: {0}", isRented());
        }
    }
    
    
    
    /**************/
    /*Inheritance*/
    /*************/
    
    
    
    public class Person
    {
        private String firstName;
        private String lastName;
        private String gender;
        
        public Person(String firstName, String lastName, String gender){
            this.firstName = firstName;
            this.lastName = lastName;
            this.gender = gender;
        }
        
        public String getName(){
            return firstName + " " + lastName;
        }
        
        public virtual void hello(){
            Console.WriteLine("Hello I am a Person");
        }
    }
    
    
    public class Resident : Person
    {
        private String occupation;
        
        //Constructor
        public Resident(String firstName, String lastName, String gender, String occupation) : base(firstName, lastName, gender){
            this.occupation = occupation;
        }
        
        public String getOccupation(){
            return occupation;
        }
        
        public override void hello(){
            //will print function of parent class: base.hello();
            Console.WriteLine("Hello I'm a Resident of your houses.");
        }
    }
    
    public class  Employee : Resident
    {
        private int monthlyIncome;
        
        //Constructor
        public Employee(String firstName, String lastName, String gender, String occupation, int monthlyIncome) : base(firstName, lastName, gender, occupation){
            this.monthlyIncome = monthlyIncome;
        }
        
        public int getMonthlyIncome(){
            return monthlyIncome;
        }
        
        public override void hello(){
            //will print function of parent class: base.hello();
            Console.WriteLine("Hello I'm an Employee.");
        }
    }
    
}


























