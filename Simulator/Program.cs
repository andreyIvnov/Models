using Services;
using System;

namespace Simulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Test();

            Console.ReadLine();
        }

        private static async void Test()
        {
            IDataService service = new DataService();

            foreach (var car in await service.GetCarsAsync())
                Console.WriteLine(car.Model);
        }
    }
}