using System;
using System.Collections.Generic;
using System.Linq;
using Core.Common.Contracts;
using FlatFinder.Business.Entities;

namespace FlatFinder.Data.Contracts
{
    public interface IAccountRepository : IDataRepository<Account>
    {
        Account GetByLogin(string login);
    }
}
