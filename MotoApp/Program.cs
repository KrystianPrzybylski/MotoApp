using Microsoft.Extensions.DependencyInjection;
using MotoApp;
using MotoApp.Entities;
using MotoApp.Repositories;

var services = new ServiceCollection();
services.AddSingleton<IApp,App>();
services.AddSingleton<IRepository<Employee>, ListRepository<Employee>>();
services.AddSingleton<IRepository<Car>, ListRepository<Car>>();
services.AddSingleton<ICarsProvider,CarsProviderBasic>();

var serviceProvider= services.BuildServiceProvider();
var app = serviceProvider.GetService<IApp>()!;

app.Run();
Console.ReadKey();
//using MotoApp.Repositories;
//using MotoApp.Entities;
//using MotoApp.Data;
//using MotoApp.Repositories.Extensions;

//var employeeRepository = new SqlRepository<Employee>(new MotoAppDbContext(), EmployeeAdded);

//AddEmployees(employeeRepository);
//WriteAllToConsole(employeeRepository);

//static void EmployeeAdded(Employee item)
//{
//    Console.WriteLine($"{item.FirstName} added");
//}

//static void AddEmployees(IRepository<Employee> repository)
//{
//    var employees = new[]
//    {
//        new Employee {FirstName="Krystian" },
//       new Employee {FirstName="Marek" },
//       new Employee {FirstName="Piotr" }
//    };
//  repository.AddBatch(employees);
//    "string".AddBatch(employees); 

//    //AddBatch(employeeRepository, employees);
//    //employeeRepository.Add(new Employee { FirstName = "Krystian" });
//    //employeeRepository.Add(new Employee { FirstName = "Andrzej" });
//    //employeeRepository.Add(new Employee { FirstName = "Anan" });
//    //employeeRepository.Save();
//}

////static void AddBatch<T>(IRepository<T> repository, T[] items)
////    where T:class,IEntity
////{
////    foreach (var item in items)
////    {
////        repository.Add(item);
////    }
////    repository.Save();
////}

//static void WriteAllToConsole(IReadRepository<IEntity> repository)
//{
//    var items = repository.GetAll();
//    foreach (var item in items)
//    {
//        Console.WriteLine(item);
//    }


//}