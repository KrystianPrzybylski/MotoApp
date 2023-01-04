namespace MotoApp;
//using MotoApp;
//using MotoApp.Entities;

using Microsoft.Extensions.DependencyInjection;
using MotoApp;
using MotoApp.DataProviders;
using MotoApp.Entities;
using MotoApp.Repositories;


public class App : IApp

{

    private readonly IRepository<Employee> _employeesRepository;
    private readonly IRepository<Car> _carsRepository;
    private readonly ICarsProvider _carsProvider;

    public App(
        IRepository<Employee> employesRepository,
        IRepository<Car> carsRepository,
        ICarsProvider carsProvider)
    {
        _employeesRepository = employesRepository;
        _carsRepository = carsRepository;
    }

    public void Run()
    {
        global::System.Console.WriteLine("tekst po zmianach");
        Console.WriteLine("Jestem tutaj, interfejs dzia³a.Turbo dzia³a gówno dzia³a");

        var employees = new[]
        {

            new Employee{FirstName="Adam"},
            new Employee{FirstName="Adam2"},
            new Employee{FirstName="Krystian"}


        };

        foreach (var employee in employees)
        {
            _employeesRepository.Add(employee);
        }
        _employeesRepository.Save();

        var items = _employeesRepository.GetAll();
        foreach (var item in items)
        {
            global::System.Console.WriteLine(item);
        }

        var cars = GeneralSampleCars();
        foreach (var car in cars) 
        {
            _carsRepository.Add(car);
        }
        foreach (var car in _carsProvider.FilerCars(1000))
        {
            global::System.Console.WriteLine(car);
        }

    }

    public static List<Car> GeneralSampleCars()
    {
        return new List<Car>
        {
            new Car
            {
                Id=680,
                nameof="Car",
                Color="Black",
                StandardCost=33,31M,
                ListPrice=142,55M,
                Type="58"
            },
            new Car
            {
                Id=681,
                nameof="Car2",
                Color="Black",
                StandardCost=33,31M,
                ListPrice=142,55M,
                Type="58"
            }
        };
    }

}
