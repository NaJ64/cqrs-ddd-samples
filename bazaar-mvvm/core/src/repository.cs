using System;
using System.Collections.Generic;
using Bazaar.Core.Entities;

namespace Bazaar.Core.Repositories
{
    public interface IRepository<T> where T : Entity 
    {
        T FindById(int id);
        List<T> GetAll();
        T Update(T updated);
        void Delete(T updated);
        void DoTransaction(Action action);
        U DoTransaction<U>(Func<U> action);
    }
}