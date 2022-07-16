using MotoApp.Repositories;
using MotoApp.Entities;
using MotoApp.Data;
using MotoApp.Repositories.Extensions;


var employeeRepository = new SqlRepository<Employee>(new MotoAppDbContext());
AddEmployees(employeeRepository);
WriteAllToConsole(employeeRepository);

static void AddEmployees(IRepository<BusinessPartner> businesParrtnersRepository)
{
    var businesPartners = new[]
    {
        new BusinessPartner { },
        new BusinessPartner {},
        new BusinessPartner {}
    };
    businesParrtnersRepository.AddBatch(businesPartners);
    "string".AddBatch(businesPartners); 

    //AddBatch(employeeRepository, employees);
    //employeeRepository.Add(new Employee { FirstName = "Krystian" });
    //employeeRepository.Add(new Employee { FirstName = "Andrzej" });
    //employeeRepository.Add(new Employee { FirstName = "Anan" });
    //employeeRepository.Save();
}

//static void AddBatch<T>(IRepository<T> repository, T[] items)
//    where T:class,IEntity
//{
//    foreach (var item in items)
//    {
//        repository.Add(item);
//    }
//    repository.Save();
//}

static void WriteAllToConsole(IReadRepository<IEntity> repository)
{
    var items = repository.GetAll();
    foreach (var item in items)
    {
        Console.WriteLine(item);
    }


}