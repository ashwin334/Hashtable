using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Hashtable
{
    public class Employee
    {
        private string v1;
        private int v2;

        public Employee(string v1, int v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        static void Main(string[] args)
        {
            List<int> ilist = new List<int>();

            ilist.Add(10);
            ilist.Add(20);
            ilist.Add(30);

            ilist.Insert(2, 15);


            List<string> slist = new List<string>();

            slist.Add("C#");
            slist.Add("MVC");

            Employee e1 = new Employee("test2", 22000);
            Employee e2 = new Employee("test3", 22000);
            List<Employee> emplist = new List<Employee>();

            emplist.Add(new Employee("test1", 32000));
            emplist.Add(new Employee("test4", 32000));
            foreach (Employee emp in emplist)
            {
                Console.WriteLine(emp);
            }

            List<Product> prodlist = new List<Product>()
                {
                new Product{Id=1,Name="mouse",Price=999},
                 new Product{Id=1,Name="mouse",Price=999},
                  new Product{Id=1,Name="mouse",Price=999},
                   new Product{Id=1,Name="mouse",Price=999},
                   new Product{Id=1,Name="mouse",Price=999},
                };

            foreach (Product item in prodlist)
            {
                Console.WriteLine($"{item.Id} {item.Name} {item.Price}");
            }

            foreach (int item in ilist)
            {
                Console.WriteLine(item);
            }
        }
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
    }

     static void Main(string[] args)
    {
        Dictionary<int, string> Dictionary = new Dictionary<int, string>();
        Dictionary.Add(91, "IND");
        foreach (KeyValuePair<int, string> item in Dictionary)
        {
            Console.WriteLine(item.Key + item.Value);
        }
    }
}