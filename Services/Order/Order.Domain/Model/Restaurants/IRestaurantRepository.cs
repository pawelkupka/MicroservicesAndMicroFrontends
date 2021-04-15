using System;
using System.Threading.Tasks;

namespace Order.Domain.Model.Restaurants
{
    public interface IRestaurantRepository
    {
        Task<Restaurant> FindByIdAsync(Guid restaurantId);
    }
}
