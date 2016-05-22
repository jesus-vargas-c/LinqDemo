using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UnosquareLinqDemo.Models
{
    public class Customer
    {
        
            public string Name { get; set; }
            public string City { get; set; }
            public int Age { get; set; }
            public decimal Score { get; set; }
            public List<Customer> customers { get; set; }

        

            public List<Customer> GetCustomers()
            {
                customers = new List<Customer>()
                            {
                                new Customer{ Name = "Jessica", City="Bunder", Age = 22, Score = 123.5M  },
                                new Customer{ Name = "Frank", City="Novolugovoye", Age = 26, Score = 448.5M  },
                                new Customer{ Name = "Susan", City="Metu", Age = 33, Score = 9871.5M  },
                                new Customer{ Name = "Fred", City="Azteca", Age =45, Score = 98.5M  },
                                new Customer{ Name = "Andrew", City="New York City", Age = 76, Score = 535.5M  },
                                new Customer{ Name = "Juan", City="Lapuz", Age = 12, Score = 871.5M  },
                                new Customer{ Name = "Rebeca", City="Taipa", Age = 19, Score = 761.5M  },
                                new Customer{ Name = "Jerry", City="Dijon", Age = 64, Score = 097.5M  },
                                new Customer{ Name = "Howard", City="Lazaro Cardenas", Age = 98, Score = 356.5M  },
                                new Customer{ Name = "Amy", City="Acomayo", Age = 90, Score = 786.5M  },
                            };
                return this.customers;
            }
        }
    }
