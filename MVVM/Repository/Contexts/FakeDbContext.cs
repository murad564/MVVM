using MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.Repositories.Contexts
{
    public class FakeDbContext
    {
        public static List<Car> Cars { get; set; } = new List<Car>()
        {
            new Car { Id = 1, Make = "Kia", Model = "Cerato", Year = 2013 },
            new Car { Id = 2, Make = "Kia", Model = "Rio", Year = 2012 },
            new Car { Id = 3, Make = "BMW", Model = "X6", Year = 2021 }
        };
    }
}