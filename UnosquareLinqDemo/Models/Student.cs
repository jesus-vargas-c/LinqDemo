using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UnosquareLinqDemo.Models
{
    public class Student
    {
        public string First { get; set; }
        public string Last { get; set; }
        public int ID { get; set; }
        public string Street { get; set; }
        public string City { get; set; }

        public List<int> Scores;

        public List<Student> students { get; set; }

        public Student()
        {
          
        }

        public List<Student> GetStudents()
        {
            // Create the first data source.
            students = new List<Student>()
        {
            new Student {First="Svetlana",
                Last="Omelchenko",
                ID=111,
                Street="123 Main Street",
                City="Seattle",
                Scores= new List<int> {97, 92, 81, 60}},
            new Student {First="Claire",
                Last="O’Donnell",
                ID=112,
                Street="124 Main Street",
                City="Redmond",
                Scores= new List<int> {75, 84, 91, 39}},
            new Student {First="Sven",
                Last="Mortensen",
                ID=113,
                Street="125 Main Street",
                City="Lake City",
                Scores= new List<int> {88, 94, 65, 91}},
        };
            return this.students;
        }
    }
}