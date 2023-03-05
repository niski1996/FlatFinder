using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Runtime.Serialization;
using Core.Common.Contracts;
using FlatFinder.Buisness.Entities;

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
        public DbSet<Flat> ReservationSet { get; set; }
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
            modelBuilder.Entity<Car>().HasKey<int>(e => e.CarId).Ignore(e => e.EntityId);
            modelBuilder.Entity<Rental>().HasKey<int>(e => e.RentalId).Ignore(e => e.EntityId);
            modelBuilder.Entity<Reservation>().HasKey<int>(e => e.ReservationId).Ignore(e => e.EntityId);
            modelBuilder.Entity<Car>().Ignore(e => e.CurrentlyRented);
        }
    }
}
