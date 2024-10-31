using DataAccess.DAOs;
using BussinessObject.DTO;
using Responsitory.IRepository;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Responsitory.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly OrderDAO _orderDAO;

        public OrderRepository(OrderDAO orderDAO)
        {
            _orderDAO = orderDAO;
        }

        public Task<bool> ConfirmOrdeAsync(int id)
          => _orderDAO.ConfirmOrderAsync(id);

        public Task<CountOrder> CountOr()
            => _orderDAO.CountOr();

        public Task<int> CreateOrderAsync(int userId)
            => _orderDAO.CreateOrderAsync(userId);

        public Task DeleteOrderAsync(int id)
            => _orderDAO.DeleteOrderAsync(id);

        public Task<OrderResponse> GetByIdAsync(int id)
            => _orderDAO.GetByIdAsync(id);

        public Task<List<OrderAdminResponse>> GetOrderAsync()
            => _orderDAO.GetOrderAsync();

        public Task<List<OrderResponse>> GetOrderHistoryAsync(int id)
            => _orderDAO.GetOrderHistoryAsync(id);

        public Task PlussOrderAsync(int id)
            => _orderDAO.PlussOrderAsync(id);

        public Task SubOrderAsync(int id)
            => _orderDAO.SubOrderAsync(id);

        public Task<OrderTotalPrice> TotalPrice()
            => _orderDAO.TotalPrice();

        public Task UpdateOrderAsync(int id, OrderResponse orderResponse)
            => _orderDAO.UpdateOrderAsync(id, orderResponse);
    }
}
