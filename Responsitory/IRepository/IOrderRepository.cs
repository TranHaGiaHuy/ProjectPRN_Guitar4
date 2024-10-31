using BussinessObject.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Responsitory.IRepository
{
    public interface IOrderRepository
    {
        public Task<int> CreateOrderAsync(int userid);
        public Task UpdateOrderAsync(int id, OrderResponse orderResponse);
        public Task DeleteOrderAsync(int id);
        public Task<List<OrderAdminResponse>> GetOrderAsync();
        public Task<OrderResponse> GetByIdAsync(int id);
        public Task<List<OrderResponse>> GetOrderHistoryAsync(int id);
        public Task PlussOrderAsync(int id);
        public Task SubOrderAsync(int id);
        public Task<CountOrder> CountOr();
        public Task<bool> ConfirmOrdeAsync(int id);
        public Task<OrderTotalPrice> TotalPrice();
    }
}
