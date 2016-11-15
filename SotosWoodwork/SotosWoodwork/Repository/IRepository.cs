using System;
using System.Collections.Generic;
using System.Linq;

namespace SotosWoodwork.Repository
{
    interface IRepository
    {
        void Save(object obj);
        void Delete(object obj);
        object GetById(Type objType, object objId);
        IList<T> ToList<T>();
    }
}
