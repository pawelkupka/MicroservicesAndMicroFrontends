using System;
using System.Threading.Tasks;

namespace Delivery.Domain.Model
{
    public interface IDeliveryRepository
    {
        Task<Delivery> FindByIdAsync(Guid deliveryId);
        Task<Delivery> FindByOrderIdAsync(Guid orderId);
        Task AddAsync(Delivery delivery);
        Task UpdateAsync(Delivery delivery);
    }
}
