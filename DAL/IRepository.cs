using Models;
using System.Collections.Generic;

namespace DAL
{
    public interface IRepository
    {
        IEnumerable<Car> Cars { get; }
    }
}