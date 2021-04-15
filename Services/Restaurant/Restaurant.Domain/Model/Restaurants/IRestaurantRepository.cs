using System;
using System.Threading.Tasks;

namespace Restaurant.Domain.Model.Restaurants
{
    public interface IRestaurantRepository
    {
        Task<Restaurant> FindByIdAsync(Guid restaurantId);
        Task AddAsync(Restaurant restaurant);
        Task UpdateAsync(Restaurant restaurant);
    }
}
