using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using FlatFinder.Business.Entities;
using FlatFinder.Data.Contracts;

namespace FlatFinder.Data
{
    [Export(typeof(IFlatRepository))]
    [PartCreationPolicy(CreationPolicy.Shared)]
    public class FlatRepository : DataRepositoryBase<Flat>, IFlatRepository
    {
        public IEnumerable<Flat> GetInCity(string city)
        {
            using (FlatFinderContext entityContext = new FlatFinderContext())
            {
                return from e in entityContext.FlatSet
                        where e.City == city
                        select e;
            }
        }

        public IEnumerable<Flat> GetOnStreet(string street)
        {
            using (FlatFinderContext entityContext = new FlatFinderContext())
            {
                return from e in entityContext.FlatSet
                       where e.Street == street
                       select e;
            }
        }

        public IEnumerable<Flat> GetWitchAreaBetween(int minArea, int maxArea)
        {
            using (FlatFinderContext entityContext = new FlatFinderContext())
            {
                return from e in entityContext.FlatSet
                       where e.Area >= minArea 
                       & e.Area <= maxArea
                       select e;
            }
        }

        public IEnumerable<Flat> GetWithRoomNumber(int roomNumber)
        {
            using (FlatFinderContext entityContext = new FlatFinderContext())
            {
                return from e in entityContext.FlatSet
                       where roomNumber==e.Rooms
                       select e;
            }
        }

        protected override Flat AddEntity(FlatFinderContext entityContext, Flat entity)
        {
            return entityContext.FlatSet.Add(entity);
        }

        protected override IEnumerable<Flat> GetEntities(FlatFinderContext entityContext)
        {
            return from e in entityContext.FlatSet select e;
        }

        protected override Flat GetEntity(FlatFinderContext entityContext, int id)
        {
            return (from e in entityContext.FlatSet
                    where e.Id == id
                    select e).FirstOrDefault();
        }

        protected override Flat UpdateEntity(FlatFinderContext entityContext, Flat entity)
        {
            return (from e in entityContext.FlatSet
                    where e.Id == entity.Id
                    select e).FirstOrDefault();
        }
    }
}
