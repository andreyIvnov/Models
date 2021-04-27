using BL;
using Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services
{
    public class DataService : IDataService
    {
        readonly Logic logic = new Logic();

        public Task<IEnumerable<Car>> GetCarsAsync()
        {
            return Task.Run(() => logic.Cars);
        }
    }
}