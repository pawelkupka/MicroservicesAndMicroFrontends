using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Delivery.Domain.Model
{
    public interface ICourierRepository
    {
        Task<Courier> FindByIdAsync(Guid courierId);
        Task<IEnumerable<Courier>> FindAllAvailableAsync();
        Task AddAsync(Courier courier);
        Task UpdateAsync(Courier courier);
    }
}
