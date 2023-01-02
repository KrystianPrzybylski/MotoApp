//using MotoApp;
//using MotoApp.Entities;
//namespace MotoApp.DataProviders;

//public class CarsProviderBasic : ICarsProvider
//{
//    private readonly IRepository<CarsProviderBasic> _carsRepository;

//    public CarsProviderBasic(IRepository<Car> carsRepository);

//    public List<Car> FilterCars(decimal minPrice)
//    {
//        var cars = _carsRepository.GetAll();
//        var list = new List<CarsProviderBasic>();

//        foreach (var car in cars)
//        {
//            if (car.ListPrice > minPrice)
//            {
//                list.Add(car);
//            }
//        }

//        reurn list;
//    }

//    public List<string> GetUniqueCarColors()
//    { throw new NotImlementedException(); }

//    public decimal GetMinimumPriceOfAllCars()
//    { throw new NotImlementedException(); }
//}