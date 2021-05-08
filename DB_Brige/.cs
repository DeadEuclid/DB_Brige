using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DB_Brige
{
    class Repository<T> : IRepository<T>
    {
        public Repository()
        {
           private LiteDatabase LiteDB { get; }
        private LiteCollection<TickerCandles> TickerColection { get; }
    }
        public void Create(T item)
        {
            throw new NotImplementedException();
        }

        public bool Delete(T item)
        {
            throw new NotImplementedException();
        }

        public T Read(Predicate<T> predicate)
        {
            throw new NotImplementedException();
        }

        public bool Update(T item)
        {
            throw new NotImplementedException();
        }
    }


}

