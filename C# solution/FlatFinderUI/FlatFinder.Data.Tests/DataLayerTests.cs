using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using FlatFinder.Business.Bootstrapper;
using FlatFinder.Business.Entities;
using FlatFinder.Data.Contracts;
using Core.Common.Contracts;
using Core.Common.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace FlatFinder.Data.Tests
{
    [TestClass]
    public class DataLayerTests
    {
        [TestInitialize]
        public void Initialize()
        {
            ObjectBase.Container = MEFLoader.Init();
        }

        [TestMethod]
        public void test_repository_usage()
        {
            RepositoryTestClass repositoryTest = new RepositoryTestClass();

            IEnumerable<Flat> Flats = repositoryTest.GetFlats();

            Assert.IsTrue(Flats != null);
        }

        [TestMethod]
        public void test_repository_factory_usage()
        {
            RepositoryFactoryTestClass factoryTest = new RepositoryFactoryTestClass();

            IEnumerable<Flat> Flats = factoryTest.GetFlats();

            Assert.IsTrue(Flats != null);
        }

        [TestMethod]
        public void test_repository_mocking()
        {
            List<Flat> Flats = new List<Flat>()
            {
                new Flat() { Id = 1, ForSale = true},
                new Flat() { Id = 2, ForSale = false }
            };

            Mock<IFlatRepository> mockFlatRepository = new Mock<IFlatRepository>();
            mockFlatRepository.Setup(obj => obj.Get()).Returns(Flats);

            RepositoryTestClass repositoryTest = new RepositoryTestClass(mockFlatRepository.Object);

            IEnumerable<Flat> ret = repositoryTest.GetFlats();

            Assert.IsTrue(ret == Flats);
        }
        
        [TestMethod]
        public void test_factory_mocking1()
        {
            List<Flat> Flats = new List<Flat>()
            {
                new Flat() { Id = 1, ForSale = true},
                new Flat() { Id = 2, ForSale = false }
            };

            Mock<IDataRepositoryFactory> mockDataRepository = new Mock<IDataRepositoryFactory>();
            mockDataRepository.Setup(obj => obj.GetDataRepository<IFlatRepository>().Get()).Returns(Flats);

            RepositoryFactoryTestClass factoryTest = new RepositoryFactoryTestClass(mockDataRepository.Object);

            IEnumerable<Flat> ret = factoryTest.GetFlats();

            Assert.IsTrue(ret == Flats);
        }

        [TestMethod]
        public void test_factory_mocking2()
        {
            List<Flat> Flats = new List<Flat>()
            {
                new Flat() { Id = 1, ForSale = true},
                new Flat() { Id = 2, ForSale = false }
            };

            Mock<IFlatRepository> mockFlatRepository = new Mock<IFlatRepository>();
            mockFlatRepository.Setup(obj => obj.Get()).Returns(Flats);

            Mock<IDataRepositoryFactory> mockDataRepository = new Mock<IDataRepositoryFactory>();
            mockDataRepository.Setup(obj => obj.GetDataRepository<IFlatRepository>()).Returns(mockFlatRepository.Object);

            RepositoryFactoryTestClass factoryTest = new RepositoryFactoryTestClass(mockDataRepository.Object);

            IEnumerable<Flat> ret = factoryTest.GetFlats();

            Assert.IsTrue(ret == Flats);
        }
    }

    public class RepositoryTestClass
    {
        public RepositoryTestClass()
        {
            ObjectBase.Container.SatisfyImportsOnce(this);
        }

        public RepositoryTestClass(IFlatRepository FlatRepository)
        {
            _FlatRepository = FlatRepository;
        }

        [Import]
        IFlatRepository _FlatRepository;

        public IEnumerable<Flat> GetFlats()
        {
            IEnumerable<Flat> Flats = _FlatRepository.Get();

            return Flats;
        }
    }

    public class RepositoryFactoryTestClass
    {
        public RepositoryFactoryTestClass()
        {
            ObjectBase.Container.SatisfyImportsOnce(this);
        }

        public RepositoryFactoryTestClass(IDataRepositoryFactory dataRepositoryFactory)
        {
            _DataRepositoryFactory = dataRepositoryFactory;
        }

        [Import]
        IDataRepositoryFactory _DataRepositoryFactory;

        public IEnumerable<Flat> GetFlats()
        {
            IFlatRepository FlatRepository = _DataRepositoryFactory.GetDataRepository<IFlatRepository>();

            IEnumerable<Flat> Flats = FlatRepository.Get();

            return Flats;
        }
    }
}
