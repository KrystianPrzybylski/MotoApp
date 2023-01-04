using MotoApp;
using MotoApp.Repositories;
using MotoApp.Entities;
using MotoApp.DataProviders;

namespace MotoApp.DataProviders;

public class CarsProviderBasic : ICarsProvider
{
    private readonly IRepository<Car> _carsRepository;

    public CarsProviderBasic(IRepository<Car> carsRepository)
    {
        _carsRepository = carsRepository;
    }

    public List<Car> FilterCars(decimal minPrice)
    { 
        var cars=_carsRepository.GetAll();
        var list = new List<Car>();

        foreach (var car in cars)
        {
            if(car.ListPrice>minPrice)
            {
                list.Add(car);  
            }
        }

        return list;
    }



    public List<string> GetUniqueCarColors()
    { throw new NotImplementedException(); }


    public decimal GetMinimumPriceOfAllCars()
    { throw new NotImplementedException(); }
}


