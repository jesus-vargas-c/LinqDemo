using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using UnosquareLinqDemo.Models;

namespace UnosquareLinqDemo.Controllers
{
    public class BasicLinqQueriesController : Controller
    {

        
        public ActionResult Select()
        {
            //  1. Data source.
            int[] numbers = new int[7] { 0, 1, 2, 3, 4, 5, 6 };

            // 2. Query creation.
            // numQuery is an IEnumerable<int>
            var numQuery =
                from num in numbers
                where (num % 2) == 0
                select num;

            ViewBag.Result = Newtonsoft.Json.JsonConvert.SerializeObject(numQuery);

            return View();
        }

        public ActionResult Customers()
        {
            var customers = new Customer();
            var customer = from c in customers.GetCustomers()
                           where c.Name != string.Empty
                           select c;
            ViewBag.Result = Newtonsoft.Json.JsonConvert.SerializeObject(customer);

            return View();
        }

        public ActionResult Union()
        {
            var students = new Student();
            var teachers = new Teacher();
            // Create the query.
            var peopleInSeattle = (from student in students.GetStudents()
                                   where student.City == "Seattle"
                                   select student.Last)
                        .Concat(from teacher in teachers.GetTeachers()
                                where teacher.City == "Seattle"
                                select teacher.Last);
            ViewBag.Result = Newtonsoft.Json.JsonConvert.SerializeObject(peopleInSeattle);

            return View();
        }
    }
}
