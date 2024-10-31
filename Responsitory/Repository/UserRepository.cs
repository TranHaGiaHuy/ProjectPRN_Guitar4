using DataAccess.DAOs;
using BussinessObject.DTO;
using Responsitory.IRepository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Responsitory.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly UserDAO _userDAO;

        public UserRepository(UserDAO userDAO) =>
            _userDAO = userDAO;

        public Task<int> CreateUserAsync(UserResponse userResponse) =>
            _userDAO.CreateUserAsync(userResponse);

        public Task DeleteUserAsync(int id) =>
            _userDAO.DeleteUserAsync(id);

        public Task<UserResponse> GetByIdAsync(int id) =>
            _userDAO.GetByIdAsync(id);

        public Task<List<UserResponse>> GetUserAsync() =>
            _userDAO.GetUserAsync();

        public Task<List<UserResponse>> SearchUserAsync(string search) =>
            _userDAO.SearchUserAsync(search);

        public Task UpdateUserAsync(int id, UserResponse userResponse) =>
            _userDAO.UpdateUserAsync(id, userResponse);
    }
}
