using AutoMapper;
using BussinessObject.Models;
using DataAccess.DAOs;
using DataAccess.DB;
using Microsoft.EntityFrameworkCore;
using BussinessObject.DTO;
using Responsitory.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Responsitory.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly AccountDAO _accountDAO;

        public AccountRepository(AccountDAO accountDAO)
        {
            _accountDAO = accountDAO;
        }

        public async Task AdminAccountAsync(int id) => await _accountDAO.AdminAccountAsync(id);

        public Task<bool> CheckLog(string email, string pass) => _accountDAO.CheckLog(email, pass);

        public Task<CountAccount> CountAcc()=>_accountDAO.CountAcc();

        public Task<int> CreateAccountAsync(CustomerResponse CustomerResponse) => _accountDAO.CreateAccountAsync(CustomerResponse);

        public Task DeleteAccountAsync(int id)=>_accountDAO.DeleteAccountAsync(id);

        public Task<string> ForgotPassword(string email)=>_accountDAO.ForgotPassword(email);

        public Task<List<CusView>> GetAccountAsync()=>_accountDAO.GetAccountAsync();

        public Task<CusView> GetByIdAsync(int id)=>_accountDAO.GetByIdAsync(id);

        public Account GetMemberByMail(string mail)=>_accountDAO.GetMemberByMail(mail);

        public Task<List<AccountResponse>> SearchAccountAsync(string search)=>_accountDAO.SearchAccountAsync(search);

        public Task UpdateAccountAsync(int id, ChangePasswordResponse changePasswordResponse)=> _accountDAO.UpdateAccountAsync(id, changePasswordResponse);

        public Task VerifiedAccountAsync(int id)=>_accountDAO.VerifiedAccountAsync(id);
    }
}
