using System;

namespace DB_Brige
{
    public interface IRepository<T>
    {
        void Create(T item);
        T Read(Predicate<T> predicate);
        bool Update(T item);
        bool Delete(T item);

    }

}
