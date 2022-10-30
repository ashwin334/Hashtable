using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashtable
{
    internal class GenericCourse
    {
        public class Customer 
        {
            public string Name { get; set; } 
            public double Hloan { get; set; }
            public double Ploan { get; set; }
            public double Cloan { get; set; } 
            public double Bloan { get; set; } 
        }
        public class Acount 
        {
            public string Acount_Type { get; set; } 
            public List<Customer> Customers = new List<Customer>(); 
        }
        public class Program
        {
            static void Main(string[] args)
            {
                List<Acount> list = new List<Acount>();
                {
                    new Acount 
                    {
                        Acount_Type = "saving account",
                        Customers =
                        { 
                            new Customer { Name = "akash", Hloan = 5000000, Cloan = 600000 }, 
                            new Customer { Name = "prakash", Hloan = 4500000 },
                            new Customer { Name = "sunil", Cloan = 340000, Ploan = 6500000 }, 
                            new Customer { Name = "sumit", Ploan = 450000 },
                        } 
                    }; 
                    new Acount
                    {
                        Acount_Type = "current account",
                        Customers =          
                        {
                            new Customer{Name="akash",Bloan=4500000},             
                            new Customer{Name="prakash",Bloan=6700000},
                        }
                    };
                }
                foreach (Acount a in list)
                {
                    Console.WriteLine(a.Acount_Type); 
                    foreach (Customer c in a.Customers) 
                    {
                        Console.WriteLine($"\t{c.Name}{c.Hloan}{c.Cloan}{c.Ploan}{c.Bloan}"); } }
            }
        }
    }
}
