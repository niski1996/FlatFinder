using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using FlatFinder.Business.Entities;
using FlatFinder.Data.Contracts;

namespace FlatFinder.Data
{
    [Export(typeof(ISessionRepository))]
    [PartCreationPolicy(CreationPolicy.Shared)]
    public class SessionRepository : DataRepositoryBase<Session>, ISessionRepository
    {
        protected override Session AddEntity(FlatFinderContext entityContext, Session entity)
        {
            return entityContext.SessionSet.Add(entity);
        }

        protected override IEnumerable<Session> GetEntities(FlatFinderContext entityContext)
        {
            return from e in entityContext.SessionSet select e;
        }

        protected override Session GetEntity(FlatFinderContext entityContext, int id)
        {
            return (from e in entityContext.SessionSet
                    where e.Id == id
                    select e).FirstOrDefault();
        }

        protected override Session UpdateEntity(FlatFinderContext entityContext, Session entity)
        {
            return (from e in entityContext.SessionSet
                    where e.Id == entity.Id
                    select e).FirstOrDefault();
        }
    }
}
