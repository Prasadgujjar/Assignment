//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace FinalAsignement
//{
//    class Tsest
//    {
//        static void Main(string[] args)
//        {

//            Person[] people = {
//                                new Person("Shyam", "Bangalore", "Karnataka", " fundamentals", 2010, 4500),
//                                new Student("Anand", "Bangalore"," Karnataka", "Delhi Public school", 35000.0),
//                                new Person("Umesh", "Bangalore", "Karnataka", "National Public school", 42000),
//                                new Staff("Suresh", "Hassan", "Karnataka", " fundamentals", 2012, 4750.0),
//                                new Person("Kiran", "Vasco", "Goa", "Reactjs", 2017, 12500)
//                                };
//            Console.ReadLine();
//        }
//    }

   
//    class Person
//    {
//        public string Name { get; set; }
//        public string city { get; set; }
//        public string state { get; set; }
//        public string Work { get; set; }
//        public int Year  { get; set; }
//        public double Salary { get; set; }

//        public Person(string Name, string Work, string city, string state, int year, double Salary)
//        {
//            this.Name = Name;
//            this.Work = Work;
//            this.city = city;
//            this.state = state;
//            this.Year = Year;
//            this.Salary = Salary;
//        }
        

//        public Person(string Name, string Work, string city, string state, int year,double Salary)
//        {

//        }



//        public Person(string Name, string Work, string city, string state, double Salary)
//        {

//        }
//    }

//    class Student
//    {
//        public Person test;
//        public double Fees { get; set; }
//        public string SchoolName { get; set; }
        

//        public Student(string Name, string Work, string city, string state, int year,int Salary)
//        {
//            this.Fees = Fees;
//            this.SchoolName = SchoolName;
//            test = new Person(Name,Work,city,state,year,Salary);
            
//        }

//        public Student(string Name, string SchoolName, string city, string state, int year, double Fees)
//        {
           
           

//        }




//    }
    
//}
