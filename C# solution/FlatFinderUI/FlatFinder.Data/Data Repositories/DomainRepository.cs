using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using FlatFinder.Business.Entities;
using FlatFinder.Data.Contracts;

namespace FlatFinder.Data
{
    [Export(typeof(IDomainRepository))]
    [PartCreationPolicy(CreationPolicy.Shared)]
    public class DomainRepository : DataRepositoryBase<Domain>, IDomainRepository
    {
        protected override Domain AddEntity(FlatFinderContext entityContext, Domain entity)
        {
            return entityContext.DomainSet.Add(entity);
        }

        protected override IEnumerable<Domain> GetEntities(FlatFinderContext entityContext)
        {
            return from e in entityContext.DomainSet select e;
        }

        protected override Domain GetEntity(FlatFinderContext entityContext, int id)
        {
            return (from e in entityContext.DomainSet
                    where e.Id == id
                    select e).FirstOrDefault();
        }

        protected override Domain UpdateEntity(FlatFinderContext entityContext, Domain entity)
        {
            return (from e in entityContext.DomainSet
                    where e.Id == entity.Id
                    select e).FirstOrDefault();
        }
    }
}
