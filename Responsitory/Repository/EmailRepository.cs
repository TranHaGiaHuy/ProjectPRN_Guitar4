using BussinessObject.Models;
using DataAccess.DAOs;
using Responsitory.IRepository;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Responsitory.Repository
{
    public class EmailRepository : IEmailRepository
    {
        private readonly EmailDAO _emailDAO;

        public EmailRepository(EmailDAO emailDAO)
        {
            _emailDAO = emailDAO;
        }

        public Task SendEmailAsync(string email, string subject, string message)
            => _emailDAO.SendEmailAsync(email, subject, message);

        public Task SendMail(MailContent mailContent)
            => _emailDAO.SendMail(mailContent);
    }
}
