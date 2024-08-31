internal class Program
{
    private static void Main(string[] args)
    {
        
        // Efcore Dont Loading  Navigational Property

       // using Contexts.AppContext context = new Contexts.AppContext();

        //var emp =   context.employees.FirstOrDefault(E => E.id == 2);

        //Console.WriteLine(emp?.id ?? 0);
        //Console.WriteLine(emp?.name ?? "NA");
        //Console.WriteLine(emp?.Salary ?? 0);
        //Console.WriteLine(emp?.age ?? 0);
        //Console.WriteLine(emp?.WorkFor?.name ?? "NA");

        //var DEP = context.departments.FirstOrDefault(e => e.id == 1);


        //Console.WriteLine(DEP?.id ?? 0);
        //Console.WriteLine(DEP?.name ?? "NA");

        //foreach (var ITEM in DEP.employees)
        //{
        //    Console.WriteLine(ITEM.name);
        //}

        // Loading To Navigational Property
        //  1. Explicit Loading
        //  2. Eager Loading
        //  3. Lazy Loading [Implicit]

        #region //1. Explicit Loading

        //  1. Explicit Loading
        // Two Request : 1 .Select EMP
        //               2 .Loading Navgaition prop


        //var emp = context.employees.FirstOrDefault(E => E.id == 2);

        // Reference : ONE
        //context.Entry(emp).Reference(E => E.WorkFor).Load(); // Loading Navgaitional property Explicitly


        //Console.WriteLine(emp?.id ?? 0);
        //Console.WriteLine(emp?.name ?? "NA");
        //Console.WriteLine(emp?.Salary ?? 0);
        //Console.WriteLine(emp?.age ?? 0);
        //Console.WriteLine(emp?.WorkFor?.name ?? "NA");



        //var DEP = context.departments.FirstOrDefault(e => e.id == 1);

        //// Collection : Many

        //context.Entry(DEP).Collection(E => E.employees).Load();

        //Console.WriteLine(DEP?.id ?? 0);
        //Console.WriteLine(DEP?.name ?? "NA");

        //foreach (var ITEM in DEP.employees)
        //{
        //    Console.WriteLine(ITEM.name);
        //}

        #endregion

        #region //2.Eager Loading

        //  2.Eager Loading
        // One Request

        //var emp = context.employees.Include(e => e.WorkFor).FirstOrDefault(E => E.id == 2);

        //Console.WriteLine(emp?.id ?? 0);
        //Console.WriteLine(emp?.name ?? "NA");
        //Console.WriteLine(emp?.Salary ?? 0);
        //Console.WriteLine(emp?.age ?? 0);
        //Console.WriteLine(emp?.WorkFor?.name ?? "NA");


        //var DEP = context.departments.Include(e => e.employees).FirstOrDefault(e => e.id == 1);


        //Console.WriteLine(DEP?.id ?? 0);
        //Console.WriteLine(DEP?.name ?? "NA");

        //foreach (var ITEM in DEP.employees)
        //{
        //    Console.WriteLine(ITEM.name);
        //}

        #endregion

        #region// 3. Lazy Loading [Implicit]

        // 3. Lazy Loading [Implicit]
        // 1. install - Package Proxies
        // 2. UseLazyLoadingProxies() in OnConfiguring
        // 3. Make All The Entites Public
        // 4. Make All The Navigational Property Virtual

        #endregion

        #region// Join Operators

        // join Operators : Join

        // Fluent Syntax

        //var result =  context.employees.Join(context.departments,
        //      E => E.DepartmentId,
        //      D => D.id,
        //      (E, D) => new
        //  {
        //    EmpName =  E.name,
        //    EmpId   = E.id,
        //    DepName = D.name,
        //    DepId =  D.id
        //  });


        //  result = from E in context.employees
        //           join D in context.departments
        //           on E.DepartmentId equals D.id
        //           select new
        //           {
        //               EmpName = E.name,
        //               EmpId = E.id,
        //               DepName = D.name,
        //               DepId = D.id
        //           };


        //  foreach (var item in result)
        //  {
        //      Console.WriteLine(item);
        //  }

        #endregion

        #region //Tracking Vs NoTracking

        // Tracking Vs NoTracking
        // Tracking [Default]

        //var Employee =  context.employees.AsNoTracking().FirstOrDefault(E => E.id == 2);

        //Console.WriteLine(context.Entry(Employee).State); // Unchanged  <<  //Detached

        //Employee.name = "Ahmed"; // Local

        //Console.WriteLine(context.Entry(Employee).State); // Local : Mermory

        //context.SaveChanges(); // Remotly : Db 
        //                       // Console.WriteLine(Employee.name);

        #endregion

        #region// Remote Vs Local

        // Remote Vs Local

        ////context.employees.Load();

        ////context.employees.Local.Any();
        ////context.employees.Local.Any();
        ////context.employees.Local.Any();
        ////context.employees.Local.Any();
        ////context.employees.Local.Any();
        ////context.employees.Local.Any();
        ////context.employees.Local.Any();
        ////context.employees.Local.Any();
        ////context.employees.Local.Any();
        ////context.employees.Local.Any();
        ////context.employees.Local.Any();
        ////context.employees.Local.Any();

        #endregion
    }
}