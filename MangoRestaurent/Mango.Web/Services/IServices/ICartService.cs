using Mango.Web.Models;

namespace Mango.Web.Services.IServices
{
    public interface ICartService
    {
        Task<T> GetCartByUSerIdAsnyc<T>(string userId, string token = null);
        Task<T> AddToCartAsnyc<T>(CartDto cartDto, string token = null);
        Task<T> UpdateCartAsnyc<T>(CartDto cartDto, string token = null);
        Task<T> RemoveFromCartAsnyc<T>(int cartId, string token = null);
        Task<T> ClearCartAsnyc<T>(int userId, string token = null);
    }
}
