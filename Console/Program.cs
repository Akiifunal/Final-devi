// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using DataAccess.Concrete.InMemory;

namespace ConsoleIU
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            
            foreach(var car in carManager.GetAll())
            {
                Console.WriteLine(car.CarId);
               

                
            }
        }
    }
}
