using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashtable
{
    internal class Generic
    {
        // dept  --> employess  -> show list of dept & working emp from that dept
        public class Emp
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
        public class Dept
        {
            public int Did { get; set; }
            public string DName { get; set; }
            public List<Emp> Employees = new List<Emp>();
        }
        public class Program
        {
            static void Main(string[] args)
            {
                List<Dept> deptList = new List<Dept>()
            {
                new Dept
                {
                    Did = 101,
                    DName = "HR",
                    Employees =
                    {
                        new Emp{Id=1,Name="user1"},
                        new Emp{Id=2,Name="user2"},
                    }
                },
                new Dept
                {
                    Did = 102,
                    DName = "Development",
                    Employees =
                    {
                        new Emp{Id=3,Name="user3"},
                        new Emp{Id=4,Name="user4"},
                        new Emp{Id=5,Name="user5"},
                        new Emp{Id=6,Name="user6"},
                    }
                },
                new Dept
                {
                    Did = 104,
                    DName = "Development",
                    Employees =
                    {
                        new Emp{Id=7,Name="user33"},
                        new Emp{Id=8,Name="user43"},
                        new Emp{Id=9,Name="user56"},
                        new Emp{Id=10,Name="user67"},
                    }
                }
            };


                foreach (Dept d in deptList)
                {
                    Console.WriteLine(d.Did + "  " + d.DName);
                    foreach (Emp e in d.Employees)
                    {
                        Console.WriteLine($"\t {e.Id} {e.Name}");
                    }
                }


            }


        }

    }

}