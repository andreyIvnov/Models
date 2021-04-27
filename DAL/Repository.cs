using Models;
using System.Collections.Generic;

namespace DAL
{
    public class Repository : IRepository
    {
        readonly DataContext data = new DataContext();

        public IEnumerable<Car> Cars => data.Cars;
    }
}