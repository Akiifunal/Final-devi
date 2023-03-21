using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>() {
            new Car{CarBrandId=1,CarId=1,CarModelYear=2021,CarColorId=1,CarDailyPrice=20000,CarDescription="Yeni modeldir."},
            new Car{CarBrandId=3,CarId=4,CarModelYear=2023,CarColorId=5,CarDailyPrice=40000,CarDescription="Tüm parçaları yenidir."},
            new Car{CarBrandId=2,CarId=2,CarModelYear=2045,CarColorId=4,CarDailyPrice=20000,CarDescription="Yenilenecektir."},
            new Car{CarBrandId=1,CarId=3,CarModelYear=2050,CarColorId=1,CarDailyPrice=30000,CarDescription="Gelecek sizin tekerlerinizde."}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
           Car carToDelete= _cars.SingleOrDefault(c=> c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(c => c.CarId == id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.CarBrandId = car.CarBrandId;
            carToUpdate.CarId = car.CarId;
            carToUpdate.CarColorId = car.CarColorId;
            carToUpdate.CarModelYear = car.CarModelYear;
            carToUpdate.CarDailyPrice = car.CarDailyPrice;
            carToUpdate.CarDescription = car.CarDescription;
        }
    }
}
