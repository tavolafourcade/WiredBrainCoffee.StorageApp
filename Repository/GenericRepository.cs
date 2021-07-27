using System;
using System.Collections.Generic;
using System.Linq;
using WiredBrainCoffee.StorageApp.Entities;

namespace WiredBrainCoffee.StorageApp.Repository
{
    public class GenericRepository<T> where T : EntityBase // T is of type EntityBase
    {

        private readonly List<T> _items = new(); // With protected you can access it from a SubClass, but with private we can't

        public T GetById(int id)
        {
            return _items.Single(item => item.Id == id);
        }
        public void Add(T item)
        {
            item.Id = _items.Count + 1;
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