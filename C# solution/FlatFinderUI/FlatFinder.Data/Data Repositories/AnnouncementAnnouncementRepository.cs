using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using FlatFinder.Business.Entities;
using FlatFinder.Data.Contracts;

namespace FlatFinder.Data
{
    [Export(typeof(IAnnouncementRepository))]
    [PartCreationPolicy(CreationPolicy.Shared)]
    public class AnnouncementAnnouncementRepository : DataRepositoryBase<Announcement>, IAnnouncementRepository
    {
        public IEnumerable<AnnouncerInfo> GetAnnouncerInfo(int announcerId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Announcement> GetWithPriceBetween(int minPrice, int maxPrice)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Announcement> GetWithTheSameFlat(int idFlat)
        {
            throw new NotImplementedException();
        }

        protected override Announcement AddEntity(FlatFinderContext entityContext, Announcement entity)
        {
            return entityContext.AnnouncementSet.Add(entity);
        }

        protected override IEnumerable<Announcement> GetEntities(FlatFinderContext entityContext)
        {
            return from e in entityContext.AnnouncementSet select e;
        }

        protected override Announcement GetEntity(FlatFinderContext entityContext, int id)
        {
            return (from e in entityContext.AnnouncementSet
                    where e.Id == id
                    select e).FirstOrDefault();
        }

        protected override Announcement UpdateEntity(FlatFinderContext entityContext, Announcement entity)
        {
            return (from e in entityContext.AnnouncementSet
                    where e.Id == entity.Id
                    select e).FirstOrDefault();
        }
    }
}
