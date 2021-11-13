using HotelListing01.Data;
using System;
using System.Threading.Tasks;

namespace HotelListing01.IRepository
{
    public interface IUnitOfWork:IDisposable
    {
        IGenericRepository<Country> Countries { get; }
        IGenericRepository<Hotel> Hotels { get; }
        Task Save();
    }
}
