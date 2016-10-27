using System;
using System.Linq;

namespace SotosWoodwork.Repository
{
    interface IRepository
    {
        void Save(object obj);
        void Delete(object obj);
        object GetById(Type objType, object objId);
        IQueryable<T> ToList<T>();
    }
}
