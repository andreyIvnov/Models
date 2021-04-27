using Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services
{
    public interface IDataService
    {
        Task<IEnumerable<Car>> GetCarsAsync();
    }
}