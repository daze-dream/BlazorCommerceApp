using System;
using EndToEndTest.Data.CommerceDataModels;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;

namespace EndToEndTest
{ 
    public class TransactionServices
    {
        private readonly CommerceappContext _context;
        private readonly IHttpContextAccessor _httpCA;


        public TransactionServices(CommerceappContext context)
        {
            _context = context;
        }
        public async Task<List<Transactionsmaster>> GetTransactions(string currUserID)
        {

            return await _context.Transactionsmaster
                .Where(x => x.UserId == currUserID)
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<List<Userstoaccounts>> GetUserBankAccounts(string currUserID)
        {

            return await _context.Userstoaccounts.Where(x => x.UserId == currUserID)
                .AsNoTracking()
                .ToListAsync();
        }
        //TODO: add additonal services to fetch the required data for adding new transacitons


        public Task<Transactionsmaster>
            CreateTransactionAsync(Transactionsmaster objTransactionsmaster)
        {
            _context.Transactionsmaster.Add(objTransactionsmaster);
            _context.SaveChanges();
            return Task.FromResult(objTransactionsmaster);
        }
    }
}
