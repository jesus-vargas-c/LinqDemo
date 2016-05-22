using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UnosquareLinqDemo.Models
{
    /// <summary>
    /// Class teacher
    /// </summary>
    public class Teacher
    {
        public string First { get; set; }
        public string Last { get; set; }
        public int ID { get; set; }
        public string City { get; set; }

        public List<Teacher> teachers { get; set; }
        public Teacher()
        {
                  
        }
        //function to get the teachers
        public List<Teacher> GetTeachers()
        {
            // Create the second data source.
            teachers = new List<Teacher>()
        {
            new Teacher {First="Ann", Last="Beebe", ID=945, City = "Seattle"},
            new Teacher {First="Alex", Last="Robinson", ID=956, City = "Redmond"},
            new Teacher {First="Michiyo", Last="Sato", ID=972, City = "Tacoma"}
        };
            return this.teachers;
        }
    }
}