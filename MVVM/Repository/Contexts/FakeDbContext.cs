using System.Collections.Generic;
using MVVM.Models;

namespace MVVM.Repository.Contexts {

    public class FakeDbContext
    {
        public static List<Car> Cars { get; set; } = new()
        {
            new Car { Id = 1, Model = "Kia", Make = "Cerato", Year = 2013 },
            new Car { Id = 2, Model = "Mercedes", Make = "e320", Year = 2010 },
            new Car { Id = 3, Model = "Bmw", Make = "M4", Year = 2018 },

        };

        public static List<Car> GetCars()
        {
            var list = new List<Car>();
            return list;
        }

    }
}