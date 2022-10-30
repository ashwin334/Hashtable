using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//namespace Hashtable
// {
//       public class GenericStudents
//       {
//          public class Student
//           {
//           public int Id { get; set; }
//           public string Name { get; set; }
//           }
//         public class Branch
//         {
//         public int Brid { get; set; }
//         public string BrName { get; set; }
//         public List<Student>students = new List<Student>();
//         }
//        public class Program
//        {
//         static void Main(string[] args)
//         {
//          List<Branch> branches = new List<Branch>()
//           {
//           new Branch
//              {
//               Brid=1            ,
//               BrName="computer science",
//               students =
//                   {
//                    new Student{Id=20345,Name="Akash"},
//                    new Student{Id=20346,Name="Prakash"},
//                    new Student{Id=20347,Name="pratish"},
//                    new Student{Id=20348,Name="Pranit"},
//                   }
//              },
//               new Branch
//                {
//                 Brid=2,
//                 BrName="imformation technologyt",
//                 students =
//                 {
//                   new Student{Id=20331,Name="Ak"},
//                   new Student{Id=20332,Name="pk"},
//                   new Student{Id=20333,Name="sk"},
//                   new Student{Id=20334,Name="mk"},
//                   new Student{Id=20335,Name="gk"},
//                 }
//              }
//           };
//              foreach(Branch item in branches)
//            {
//              Console.WriteLine(item.Brid+" "+item.BrName);
//                foreach(Student st in item.students)
//                {
//                  Console.WriteLine($"\t{st.Id}  {st.Name}");
//                }
//            }
//        }
//    }
// }