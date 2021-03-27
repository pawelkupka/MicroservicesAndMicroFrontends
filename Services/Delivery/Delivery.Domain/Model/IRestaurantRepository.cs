using System;
using System.Threading.Tasks;

namespace Delivery.Domain.Model
{
    public interface IRestaurantRepository
    {
        Task<Restaurant> FindByIdAsync(Guid restaurantId);
        Task AddAsync(Restaurant restaurant);
        Task UpdateAsync(Restaurant restaurant);
    }
}
