using DataAccess.DAOs;
using BussinessObject.DTO;
using Responsitory.IRepository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Responsitory.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductDAO _productDAO;

        public ProductRepository(ProductDAO productDAO) =>
            _productDAO = productDAO;

        public Task<CountProduct> CountPro() =>
            _productDAO.CountPro();

        public Task<int> CreateProductAsync(ProductResponse productResponse) =>
            _productDAO.CreateProductAsync(productResponse);

        public Task DeleteProductAsync(int id) =>
            _productDAO.DeleteProductAsync(id);

        public Task<ProductView> GetByIdAsync(int id) =>
            _productDAO.GetByIdAsync(id);

        public Task<List<ProductView>> GetProductAsync() =>
            _productDAO.GetProductAsync();

        public Task<List<ProductView>> SearchProductAsync(string search) =>
            _productDAO.SearchProductAsync(search);

        public Task<List<ProductView>> SearchProductByCateAsync(int id) =>
            _productDAO.SearchProductByCateAsync(id);

        public Task UpdateProductAsync(int id, ProductEdit productEdit) =>
            _productDAO.UpdateProductAsync(id, productEdit);
    }
}
