using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Runtime.Serialization;
using Core.Common.Contracts;
using FlatFinder.Business.Entities;

namespace FlatFinder.Data
{
    public class FlatFinderContext : DbContext
    {
        public FlatFinderContext()
            : base("name=FlatFinder")
        {
            Database.SetInitializer<FlatFinderContext>(null);
        }

        public DbSet<Account> AccountSet { get; set; }

        public DbSet<Announcement> AnnouncementSet { get; set; }

        public DbSet<Domain> DomainSet { get; set; }

        public DbSet<Flat> FlatSet { get; set; }
        public DbSet<SeedPoint> SeedPointSet { get; set; }
        public DbSet<Session> SessionSet { get; set; }
        public DbSet<SessionInDomain> SessionInDomainSet { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Ignore<PropertyChangedEventHandler>();
            modelBuilder.Ignore<ExtensionDataObject>();
            modelBuilder.Ignore<IIdentifiableEntity>();

            modelBuilder.Entity<Account>().HasKey<int>(e => e.AccountId).Ignore(e => e.EntityId);
            modelBuilder.Entity<Announcement>().HasKey<int>(e => e.Id).Ignore(e => e.EntityId);
            modelBuilder.Entity<Flat>().HasKey<int>(e => e.Id).Ignore(e => e.EntityId);
            modelBuilder.Entity<SeedPoint>().HasKey<int>(e => e.Id).Ignore(e => e.EntityId);
            modelBuilder.Entity<Session>().HasKey<int>(e => e.Id).Ignore(e => e.EntityId);
            modelBuilder.Entity<SessionInDomain>().HasKey<int>(e => e.Id).Ignore(e => e.EntityId);
        }
    }
}
