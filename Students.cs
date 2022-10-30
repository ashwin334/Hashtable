using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashtable
{
     public class Student   
 //  {       
 //     public int Id { get; set; }
 //      public string Name { get; set; }
 //   }  
 //    public class Branch
 //    {         
 //       public int Brid { get; set; }      
 //       public string BrName { get; set; }
 //       public List<Student>students = new List<Student>();   
 //        }
 //       public class Program   
 //       {
 //       static void Main(string[] args)
 //       {
 //       List<Branch> branches = new List<Branch>()
 //        {   
 //        new Branch
 //          {  
 //            Brid=1,
 //            BrName="computer science",
 //           students =
 //             {
 //               new Student{Id=20345,Name="Akash"},
 //               new Student{Id=20346,Name="Prakash"},
 //               new Student{Id=20347,Name="pratish"},                
 //               new Student{Id=20348,Name="Pranit"},
//              }
//           },
//           new Branch
//           {
//            Brid=2,
//            BrName="imformation technologyt",
//            students =
//                   {                     
//                   new
//                   Student{Id=20331,Name="Ak"}
//                   new
//                   Student{Id=20332,Name="pk"},
//                   new
//                   Student{Id=20333,Name="sk"},
//                   new
//                   Student{Id=20334,Name="mk"},
//                   new
//                   Student{Id=20335,Name="gk"},
//                 
//                      }//               }
//           };//            foreach(Branch item in branches)
//           
//           {//                Console.WriteLine(item.Brid+" "+item.BrName);
//                foreach(Student st in item.students)//             
//             {//                   
//             Console.WriteLine($"\t{st.Id}  {st.Name}");
//                }//           
//               }
//        }// 
//          }[10/28, 9:01 AM] TqAkash Kuchankar: public class Customer       
//          {public string Name { get; set; }           
//          public double Hloan { get; set; }           
//          public double Ploan { get; set; }           
//          public double Cloan { get; set; }           
//          public double Bloan { get; set; }          
//          }       
//          public class Acount       
//          {public string Acount_Type { get; set; }           
//          public List<Customer> Customers=new List<Customer>();       
//          }
//                  public class Program       
//                  {           
//                  static void Main(string[] args)           
//                  {               
//                  List<Acount> list = new List<Acount>();               
//                  {                 
//                    new Acount                   
//                    {                       
//                    Acount_Type = "saving account",                       
//                    Customers =                       
//                    {                           
//                    new Customer{Name="akash",Hloan=5000000,Cloan=600000},         
//                    new Customer{Name="prakash",Hloan=4500000},                           
//                   new Customer{Name="sunil",Cloan=340000,Ploan=6500000},                         
//                 new Customer{Name="sumit",Ploan=450000},                     
//                                          }                   
//                                          };                   
//                                          new Acount                   
//                                          {                   
//                                              Acount_Type = "current account",                   
//                                                  Customers =                     
//                                                    {                           
//                                              new Customer{Name="akash",Bloan=4500000},                           
//                                              new Customer{Name="prakash",Bloan=6700000},
                        }
};                }                foreach (Acount a in list) 
{ 
    Console.WriteLine(a.Acount_Type); 
    foreach (Customer c in a.Customers)
    {
        Console.WriteLine($"\t{c.Name}{c.Hloan}{c.Cloan}{c.Ploan}{c.Bloan}");
    } 
}
            }        }
    }
}
