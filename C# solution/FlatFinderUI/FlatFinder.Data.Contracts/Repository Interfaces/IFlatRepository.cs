using Core.Common.Contracts;
using FlatFinder.Business.Entities;
using System.Collections.Generic;

namespace FlatFinder.Data.Contracts
{
    public interface IFlatRepository : IDataRepository<Flat>
    {
        IEnumerable<Flat> GetInCity(string city);
        IEnumerable<Flat> GetWithRoomNumber(int roomNumber);
        IEnumerable<Flat> GetWitchAreaBetween(int minArea, int maxArea);
        IEnumerable<Flat> GetOnStreet(string street);
    }
}
