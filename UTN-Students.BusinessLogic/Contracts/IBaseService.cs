using System.Collections.Generic;
using UTNAvanzada2.Common.Models;

namespace UTN_Students.BusinessLogic.Contracts
{
    public interface IBaseService<T> where T : Entity
    {
        void Add(T entity);
        T GetById(int entityId);
        IList<T> GetAll();
        void RemoveById(int entityId);
        void Modify(T entity);
    }
}
