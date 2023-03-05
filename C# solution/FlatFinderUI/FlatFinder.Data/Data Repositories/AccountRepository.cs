using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using FlatFinder.Business.Entities;
using FlatFinder.Data.Contracts;

namespace FlatFinder.Data
{



    [Export(typeof(IAccountRepository))]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class AccountRepository : DataRepositoryBase<Account>, IAccountRepository
    {
        protected override Account AddEntity(FlatFinderContext entityContext, Account entity)
        {
            return entityContext.AccountSet.Add(entity);
        }

        protected override Account UpdateEntity(FlatFinderContext entityContext, Account entity)
        {
            return (from e in entityContext.AccountSet
                    where e.AccountId == entity.AccountId
                    select e).FirstOrDefault();
        }

        protected override IEnumerable<Account> GetEntities(FlatFinderContext entityContext)
        {
            return from e in entityContext.AccountSet
                   select e;
        }
        
        protected override Account GetEntity(FlatFinderContext entityContext, int id)
        {
            var query = (from e in entityContext.AccountSet
                         where e.AccountId == id
                         select e);
            
            var results = query.FirstOrDefault();

            return results;
        }

        public Account GetByLogin(string login)
        {
            using (FlatFinderContext entityContext = new FlatFinderContext())
            {
                return (from a in entityContext.AccountSet
                        where a.LoginEmail == login
                        select a).FirstOrDefault();
            }
        }
    }
}
