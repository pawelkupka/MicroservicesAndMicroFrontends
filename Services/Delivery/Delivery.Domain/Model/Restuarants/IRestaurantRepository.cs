using System;
using System.Threading.Tasks;

namespace Delivery.Domain.Model.Restuarants
{
    public interface IRestaurantRepository
    {
        Task<Restaurant> FindByIdAsync(Guid restaurantId);
        Task AddAsync(Restaurant restaurant);
        Task UpdateAsync(Restaurant restaurant);
    }
}
