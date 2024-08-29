using EFcoreUpDayG03.Context;
using Microsoft.EntityFrameworkCore;

namespace EFcoreUpDayG03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EfCore .. Dont Loading Navigational Property

            //using ApplicationLayer context = new ApplicationLayer();
            #region ExplicitLoading
            //var employee = context.Employees.FirstOrDefault(E => E.Id == 2);
            //context.Entry(employee).Reference("WorkFor").Load();
            //Console.WriteLine(employee?.Id ?? 0);
            //Console.WriteLine(employee?.Name ?? "NA");
            //Console.WriteLine(employee?.Address ?? "NA");
            //Console.WriteLine(employee?.Salary ?? 0);
            //Console.WriteLine(employee?.WorkFor?.Name ?? "NA");
            //var department = context.Departments.FirstOrDefault(D => D.Id == 1);
            //context.Entry(department).Collection("Employees").Load();
            //Console.WriteLine(department?.Id??0);
            //Console.WriteLine(department?.Name??"NA");
            //foreach (var item in department.Employees)
            //{
            //    Console.WriteLine(item.Name);
            //} 
            #endregion
            #region EagerLoading
            //var employee = context.Employees.Include("WorkFor").FirstOrDefault(E => E.Id == 2);
            //var employee = context.Employees.Include(E=>E.WorkFor).FirstOrDefault(E => E.Id == 2);
            //Console.WriteLine(employee?.Id ?? 0);
            //Console.WriteLine(employee?.Name ?? "NA");
            //Console.WriteLine(employee?.Address ?? "NA");
            //Console.WriteLine(employee?.Salary ?? 0);
            //Console.WriteLine(employee?.WorkFor?.Name ?? "NA");
            //var department = context.Departments.Include(D=>D.Employees).FirstOrDefault(D => D.Id == 1);
            //Console.WriteLine(department?.Id ?? 0);
            //Console.WriteLine(department?.Name ?? "NA");
            //foreach (var item in department.Employees)
            //{
            //    Console.WriteLine(item.Name);
            //} 
            #endregion

            //Loading to the Navigational Property 
            //1.Explicit Loading
            //2. Eager Loading
            ///3.Lazy Loading -> implicit Loading
            ///1.install -Package Proxies
            ///2.onConfiguring
            ///3.Make All The entites Public
            ///4.make all Navigational property Virtual
            #region JoinOperator
            // //join Operator
            // using ApplicationLayer context = new ApplicationLayer();
            //var Result = context.Employees.Join(context.Departments,
            //     E => E.Dept_Id,
            //     D => D.Id,
            //     (E, D) => new
            //     {
            //        EmpId= E.Id,
            //        EmpName = E.Name,
            //        DepId =D.Id,
            //        DepName= D.Name
            //     }
            //     );
            // Result = from E in context.Employees
            //          join D in context.Departments
            //          on E.Dept_Id equals D.Id
            //          select new
            //          {
            //              EmpId = E.Id,
            //              EmpName = E.Name,
            //              DepId = D.Id,
            //              DepName = D.Name

            //          };
            // foreach (var item in Result) 
            // {
            //     Console.WriteLine(item);
            // } 
            #endregion

            #region Tracking
            //Tracking vs NoTracking
            //Tracking [Default]

            //  using ApplicationLayer context = new ApplicationLayer();
            //var employee =  context.Employees.AsNoTracking().FirstOrDefault(E => E.Id == 2);
            //  Console.WriteLine(context.Entry(employee).State);//Detached
            //  employee.Name = "Hager";
            //  Console.WriteLine(context.Entry(employee).State);//Modified

            //  Console.WriteLine(employee.Name);
            //  Console.WriteLine(context.Entry(employee).State);//Local
            //  context.SaveChanges();//remotely 
            #endregion
            //Local Vs Remote
            using ApplicationLayer context = new ApplicationLayer();
            context.Employees.Load();
            //context.Employees.Local.Any();
            //context.Employees.Local.Any();
            //context.Employees.Local.Any();
            //context.Employees.Local.Any();
            //context.Employees.Local.Any();
            //context.Employees.Local.Any();




        }
    }
}
