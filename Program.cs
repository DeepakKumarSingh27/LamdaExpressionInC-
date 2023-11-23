using System;
using System.Collections.Generic;
using System.Linq;

namespace LamdaExpression
{
   // public delegate int MyDelegate(int num);
    public class Program
    {
       
        public static void AddRecords(List<Persons> listPersonsCity)
        {
            listPersonsCity.Add(new Persons("123","John","12 Main,Ny",15));

            listPersonsCity.Add(new Persons("124", "Jonny", "13 Main,Ny", 16));
            listPersonsCity.Add(new Persons("125", "Jockey", "14 Main,Ny", 17));
            listPersonsCity.Add(new Persons("126", "John", "15 Main,Ny", 45));
            listPersonsCity.Add(new Persons("127", "Joker", "16 Main,Ny", 34));
            listPersonsCity.Add(new Persons("128", "Jug", "17 Main,Ny", 12));
          
        }
        public static void Retrieving_TopTwoRecord(List<Persons> listPersonsInCity)
        {
            foreach (Persons persons in listPersonsInCity.FindAll(e => (e.Age < 60 )).Take(2).ToList())
            {
                Console.WriteLine("Name: "+ persons.Name +"\t\tAge: " + persons.Age);
            }
        }
        public static void CheckForTeenagerPerson(List<Persons> listPersonsInCity)
        {
            if(listPersonsInCity.Any(e => (e.Age >= 13 && e.Age <= 19)))
            {
                Console.WriteLine("Yes, we have some teen -agers in the list");
            }
        }
       public static void AddRecords1(List<Student> list)
        {
            list.Add(new Student(1, "Deepak", 1234567899, "Bettiah", 13,78));
            list.Add(new Student(2, "Deepanshu",1223456789, "BTM", 15,87));
            list.Add(new Student(3, "Deepu", 3488484894, "Micolayout", 22,89));
            list.Add(new Student(4, "Deewakar",1233445566 , "HSR", 24,99));
        }

        public static void CheckStudentAge(List<Student> listStudentAge)
        {
            if (listStudentAge.Any(e => (e.Age >= 12 && e.Age <= 18)))
            {
                foreach (Student s in listStudentAge)
                {
                    Console.WriteLine("Id: " + s.Id + "\n" + "Name: " + s.Name +
                        "\n" + "Phone: " + s.phoneNumber +
                        "\n" + "Address: " + s.Address +
                        "\n" + "Age: " + s.Age);
                }
            }
        }
        public  static void display_Student_Details(List<Student> students)
        {
            foreach (Student s in students)
            {
                Console.WriteLine("Id: "+s.Id +"\n"+"Name: "+s.Name+
                    "\n"+"Phone: "+s.phoneNumber+
                    "\n"+"Address: "+s.Address+
                    "\n"+"Age: "+s.Age);
            }
        }
       
        public static void Retrieving_TopThreeRecord(List<Student> students)
        {
           
             
            foreach (Student s in students.FindAll(e => (e.Age < 60)).Take(3).ToList())
            {
                Console.WriteLine("Id: " + s.Id + "\n" + "Name: " + s.Name +
                   "\n" + "Phone: " + s.phoneNumber +
                   "\n" + "Address: " + s.Address +
                   "\n" + "Age: " + s.Age);
            }

        }
        public static void searchName(List<Student> students,string name)
        {
            foreach (Student s in students)
            {
                if(s.Name == name)
                {
                    Console.WriteLine("Yes Name is Present: "+name);
                }
            }
        }
        public static void marks_Sort(List<Student> students)
        {
            var sortedStudents = students.OrderByDescending(student => student.TotalMarks);

            Console.WriteLine("Students sorted by TotalMarks in descending order:");
            foreach (var student in sortedStudents)
            {
                Console.WriteLine($"Name: {student.Name}, TotalMarks: {student.TotalMarks}");
            }
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number");
            int x = Convert.ToInt32(Console.ReadLine());
            switch (x)
            {
                case 1:
                  List<Persons> listPersonsCity = new List<Persons>();
                    AddRecords(listPersonsCity);
                    Retrieving_TopTwoRecord(listPersonsCity);
                    CheckForTeenagerPerson(listPersonsCity);

                break;
                case 2:
                    List<Student>  ls = new List<Student>();
                    AddRecords1(ls);
                    display_Student_Details(ls);
                    Console.WriteLine("======================");
                    CheckStudentAge(ls);
                    Console.WriteLine("======================");
                    Retrieving_TopThreeRecord(ls);
                    Console.WriteLine("======================");
                    Console.WriteLine("Enter the Name you want to search");
                    string name = Console.ReadLine();
                     searchName(ls, name);
                    Console.WriteLine("======================");
                    marks_Sort(ls);
                    break;

                default:
                    Console.WriteLine("case don't match");
                break;

            }
            Console.ReadLine();
        }
    }
}
