using Inheritance.cs.Context;
using Inheritance.cs.Entites;

namespace Inheritance.cs
{
    internal class Program
    {
        static void Main()
        {
            //1.Tpc
            //2.Tph
            //3.TPcc
            using ApplicationLayer context = new ApplicationLayer();
            ///Tpc
             FullTimeEmployee fullTimeEmployee = new FullTimeEmployee()
            {
             Name = "Yaseen Mohamed",
             Email = "Yasoo@yahoo.com",
             Address = "Alex",
             Salary = 10000
            };
            PartTimeEmployee partTimeEmployee = new PartTimeEmployee()
            {
                Name = "Khalid ashraf",
                Email = "Ali@gmail.com",
                Address = "Giza",
                NumberofHour = 100,
                HourRate = 100
            };
            ///context.FullTimeEmployees.Add(fullTimeEmployee);
            ///context.PartTimeEmployees.Add(partTimeEmployee);
            ///context.SaveChanges();

            ///TpH
            // context.SaveChanges();
            //context.Employees.Add(fullTimeEmployee);
            //var Result = context.Employees.OfType<FullTimeEmployee>(); // oftype -> independent internal on Discriminator
           // foreach (var item in Result)
           // {
           //     Console.WriteLine(item.Name);
           // }
           ///TPCC
           
        }
    }
}
