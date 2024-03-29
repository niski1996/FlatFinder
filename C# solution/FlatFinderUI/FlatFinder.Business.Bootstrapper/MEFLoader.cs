﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using FlatFinder.Data;

namespace FlatFinder.Business.Bootstrapper
{
    public static class MEFLoader
    {
        public static CompositionContainer Init()
        {
            AggregateCatalog catalog = new AggregateCatalog();

            catalog.Catalogs.Add(new AssemblyCatalog(typeof(AccountRepository).Assembly));
            
            CompositionContainer container = new CompositionContainer(catalog);

            return container;
        }
    }
}
