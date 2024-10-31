using BussinessObject.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Responsitory.IRepository
{
    public interface ICategoryRepository
    {
        public Task<int> CreateCategoryAsync(CategoryResponse categoryResponse);
        public Task UpdateCategoryAsync(int id, CategoryResponse categoryResponse);
        public Task DeleteCategoryAsync(int id);
        public Task<List<CategoryResponse>> SearchCategoryAsync(string search);
        public Task<CategoryResponse> GetByIdAsync(int id);
        public Task<List<CategoryResponse>> GetCategoryAsync();
    }
}
