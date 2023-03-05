using System;
using System.Collections.Generic;
using System.Linq;
using Core.Common.Contracts;
using Core.Common.Data;

namespace FlatFinder.Data
{
    public abstract class DataRepositoryBase<T> : DataRepositoryBase<T, FlatFinderContext>
        where T : class, IIdentifiableEntity, new()
    {
    }
}
