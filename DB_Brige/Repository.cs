using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Brige
{
  public  class Repository<T> : IRepository<T>
    {
        T Exemple;
        StationContext StationContext;
        Repository()
        {
            StationContext = new StationContext();
        }
        public void Create(T item)
        {
            TypeFabric(StationContext).Add(item);
            StationContext.SaveChanges();
        }

        public void Delete(T item)
        {
            TypeFabric(StationContext).Remove(item);
            StationContext.SaveChanges();
        }

        public List<T> Read(Predicate<T> predicate)
        {

         return  (List<T>) TypeFabric(StationContext).ToListAsync().AsyncState;
        }

        public void Update(ref T oldItem,T newItem)
        {
            oldItem = newItem;
            StationContext.SaveChanges();
        }
        private DbSet TypeFabric(StationContext context)
        {
            if (Exemple is Person)
                return context.Clients;
            if (Exemple is Route)
                return context.Routes;
            if (Exemple is Station)
                return context.Stations;
            if (Exemple is Ticket)
                return context.Tickets;
            if (Exemple is TimeTable)
                return context.TimeTables;
            if (Exemple is Train)
                return context.Trains;
            if (Exemple is Trip)
                return context.Trips;
            if (Exemple is Wagon)
                return context.Wagons;
            throw new Exception("База не содержит такого типа данных");

        }
    }
}
