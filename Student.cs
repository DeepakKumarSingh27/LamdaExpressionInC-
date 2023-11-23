using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamdaExpression
{
    public class Student
    {
        public int Id;
        public string Name;
        public long phoneNumber;
        public string Address;
        public int Age;
        public int TotalMarks { get; set; }
        public Student(int Id,string Name,long phoneNumber,string Address,int Age,int marks)
        {
            this.Id = Id;
            this.Name = Name;
            this.phoneNumber = phoneNumber;
            this.Address = Address;
            this.Age = Age; 
            this.TotalMarks = marks;
        }
        
    }
}
