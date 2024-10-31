using DataAccess.DAOs;
using BussinessObject.DTO;
using Responsitory.IRepository;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Responsitory.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly CategoryDAO _categoryDAO;

        public CategoryRepository(CategoryDAO categoryDAO)
        {
            _categoryDAO = categoryDAO;
        }

        public Task<int> CreateCategoryAsync(CategoryResponse categoryResponse) => _categoryDAO.CreateCategoryAsync(categoryResponse);

        public Task DeleteCategoryAsync(int id) => _categoryDAO.DeleteCategoryAsync(id);

        public Task<CategoryResponse> GetByIdAsync(int id) => _categoryDAO.GetByIdAsync(id);

        public Task<List<CategoryResponse>> GetCategoryAsync() => _categoryDAO.GetCategoryAsync();

        public Task<List<CategoryResponse>> SearchCategoryAsync(string search) => _categoryDAO.SearchCategoryAsync(search);

        public Task UpdateCategoryAsync(int id, CategoryResponse categoryResponse) => _categoryDAO.UpdateCategoryAsync(id, categoryResponse);
    }
}
