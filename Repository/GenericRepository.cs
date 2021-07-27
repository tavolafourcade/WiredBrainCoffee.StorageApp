using System;
using System.Collections.Generic;
using WiredBrainCoffee.StorageApp.Entities;

namespace WiredBrainCoffee.StorageApp.Repository
{
    public class GenericRepository<T>
    {

        private readonly List<T> _items = new(); // With protected you can access it from a SubClass, but with private we can't
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

        public void Remove(T item)
        {
            _items.Remove(item);
        }
    }

    /*
     * Creating a SubClass
     */
    /*
    public class GenericRepositoryWithRemove<T, TKey> : GenericRepository<T, TKey> // We're inheriting from Employee Class
    {
        public void Remove(T item)
        {
            _items.Remove(item);
        }
    }
    */
}