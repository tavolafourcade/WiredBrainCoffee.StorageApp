using System;
using System.Collections.Generic;
using WiredBrainCoffee.StorageApp.Entities;

namespace WiredBrainCoffee.StorageApp.Repository
{
    public class GenericRepository<T>
    {
        protected readonly List<T> _items = new(); // With protected you can access it from a SubClass
        public void Add(T item)
        {
            _items.Add(item);
        }

        public void Save()
        {
            foreach (var item in _items)
            {
                Console.WriteLine(item);
            }
        }
    }

    /*
     * Creating a SubClass
     */
    public class GenericRepositoryWithRemove<T> : GenericRepository<T> // We're inheriting from Employee Class
    {
        public void Remove(T item)
        {
            _items.Remove(item);
        }
    }
}