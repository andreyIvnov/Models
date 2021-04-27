using DAL;
using Models;
using System.Collections.Generic;

namespace BL
{
    public class Logic
    {
        readonly IRepository repository;

        public IEnumerable<Car> Cars => repository.Cars;

        public Logic()
        {
#if DEBUG
            repository = new RepositoryMock();
#else
            repository = new Repository();
#endif
        }
    }
}