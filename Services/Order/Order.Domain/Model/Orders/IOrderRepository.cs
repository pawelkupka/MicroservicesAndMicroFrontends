using System;
using System.Threading.Tasks;

namespace Order.Domain.Model.Orders
{
    public interface IOrderRepository
    {
        Task<Order> FindByIdAsync(Guid orderId);
        Task AddAsync(Order order);
        Task UpdateAsync(Order order);
    }
}
