using Inheritance.Contexts;
using Inheritance.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        
        // 1. Tpc
       
        // 2. TPH
     
        
        // 3. TPCC

        using Applicationcontext context = new Applicationcontext();

        FullTimeEmployee fullTime = new FullTimeEmployee()
        {
            Name = "NNN",
            Salary = 1000,
            Address = "ALEX",
            Email = "ahmed@"
        };

        PartTimeEmployee partTime = new PartTimeEmployee()
        {
            Name = "MMM",
            HourRate = 10000,
            Address = "CAIRO",
            Email = "ahmed@",
            NumberOfHours = 10,
        };
        #region  ////context.FullTimeEmployees.Add(fullTime);

        ////context.FullTimeEmployees.Add(fullTime);
        ////context.PartTimeEmployees.Add(partTime);

        ////context.SaveChanges(); 
        #endregion


        context.Employees.OfType<FullTimeEmployee>();

        foreach (var employee in context.Employees)
        {
            Console.WriteLine(employee.Name);
        }

    }
}
    