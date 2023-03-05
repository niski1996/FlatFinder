using Core.Common.Contracts;
using FlatFinder.Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlatFinder.Data.Contracts
{
    public interface IAnnouncementRepository:IDataRepository<Announcement>
    {
        IEnumerable<Announcement> GetWithTheSameFlat(int idFlat);
        IEnumerable<Announcement> GetWithPriceBetween(int minPrice, int maxPrice);
        IEnumerable<AnnouncerInfo> GetAnnouncerInfo(int announcerId);
    }
}
