using DataAccess.DAOs;
using BussinessObject.DTO;
using Responsitory.IRepository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Responsitory.Repository
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        private readonly OrderDetailDAO _orderDetailDAO;

        public OrderDetailRepository(OrderDetailDAO orderDetailDAO)
        {
            _orderDetailDAO = orderDetailDAO;
        }

        public Task<int> CreateOrderDetailAsync(OrderDetailResponse orderDetailResponse) =>
            _orderDetailDAO.CreateOrderDetailAsync(orderDetailResponse);

        public Task DeleteOrderDetailAsync(int id) =>
            _orderDetailDAO.DeleteOrderDetailAsync(id);

        public Task<OrderDetailResponse> GetByIdAsync(int id) =>
            _orderDetailDAO.GetByIdAsync(id);

        public Task<List<OrderDetailAdminResponse>> GetOrderDetailAdminAsync(int id) =>
            _orderDetailDAO.GetOrderDetailAdminAsync(id);

        public Task<OrderDetailTotalPriceResponse> TotalPrice(int id) =>
            _orderDetailDAO.TotalPrice(id);

        public Task UpdateOrderDetailAsync(int id, OrderDetailResponse orderDetailResponse) =>
            _orderDetailDAO.UpdateOrderDetailAsync(id, orderDetailResponse);
    }
}
