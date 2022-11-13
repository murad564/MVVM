﻿using MVVM.Models;
using MVVM.Repositories.Abstracts;
using MVVM.Repositories.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MVVM.Repositories.Concretes
{
    public class CarRepository // : ICarRepository
    {
        public void Add(Car entity) => FakeDbContext.Cars.Add(entity);

        public Car Get(Func<Car, bool> predicate) => FakeDbContext.Cars.FirstOrDefault(predicate);

        //public List<Car> GetList(Func<Car, bool> predicate = null)
        //=> (predicate is null) switch
        //{
        //    true => FakeDbContext.Cars,
        //    false => FakeDbContext.Cars.Where(predicate).ToList()
        //};

        public void Remove(Car entity) => FakeDbContext.Cars.Remove(entity);

        public void Update(Car entity)
        {
            var index = FakeDbContext.Cars.IndexOf(entity);
            FakeDbContext.Cars[index] = entity;
        }
    }
}