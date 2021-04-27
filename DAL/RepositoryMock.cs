using Models;
using System.Collections.Generic;

namespace DAL
{
    public class RepositoryMock : IRepository
    {
        public IEnumerable<Car> Cars { get; set; }

        public RepositoryMock()
        {
            Cars = new List<Car>
            {
                new Car { Id = 1, Model = "Mazda"},
                new Car { Id = 2, Model = "Toyota"},
                new Car { Id = 3, Model = "Ford"},
                new Car { Id = 4, Model = "Renault"},
            };
        }
    }
}