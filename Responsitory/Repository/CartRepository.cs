using BussinessObject.Models;
using DataAccess.DAOs;
using BussinessObject.DTO;
using Responsitory.IRepository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Responsitory.Repository
{
    public class CartRepository : ICartRepository
    {
        private readonly CartDAO _cartDAO;

        public CartRepository(CartDAO cartDAO)
        {
            _cartDAO = cartDAO;
        }

        public List<Cart> CheckCart(List<Cart> carts) => _cartDAO.CheckCart(carts);

        public Task<CountCartQuan> CountCart(int id) => _cartDAO.CountCart(id);

        public Task<int> CreateCartAsync(int proid, int userId) => _cartDAO.CreateCartAsync(proid, userId);

        public Task DeleteCartAsync(int id) => _cartDAO.DeleteCartAsync(id);

        public Task<CartResponse> GetCartByIdAsync(int id) => _cartDAO.GetCartByIdAsync(id);

        public Task<List<CustomCartResponse>> GetCartsAsync(int id) => _cartDAO.GetCartsAsync(id);

        public Task PlussCartAsync(int id) => _cartDAO.PlussCartAsync(id);

        public Task<List<CartResponse>> SearchCartAsync(string search) => _cartDAO.SearchCartAsync(search);

        public Task SubCartAsync(int id) => _cartDAO.SubCartAsync(id);

        public Task<CartTotalPrice> TotalPrice(int id) => _cartDAO.TotalPrice(id);

        public Task UpdateCartAsync(int id, CartResponse cartResponse) => _cartDAO.UpdateCartAsync(id, cartResponse);
    }
}
