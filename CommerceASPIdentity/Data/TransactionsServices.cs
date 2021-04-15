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

        /// <summary>
        /// gets a list of all the transactions matching the current user's ID
        /// </summary>
        /// <param name="currUserID"></param>
        /// <returns>a Task containing List of Transactionsmaster </returns>
        public async Task<List<Transactionsmaster>> GetTransactions(string currUserID)
        {

            return await _context.Transactionsmaster
                .Where(x => x.UserId == currUserID)
                .AsNoTracking()
                .ToListAsync();
        }
        public async Task<List<Accounts>> GetAccount(string currUserID)
        {
            int accountID = _context.Userstoaccounts.Where(x => x.UserId == currUserID).AsNoTracking().ToList()[0].AccountId;
            return await _context.Accounts.Where(x => x.AccountId == accountID).AsNoTracking().ToListAsync();
        }

        /// <summary>
        /// gets user's bank account ID by getting a list async and then getting the first (and only) row
        /// </summary>
        /// <param name="currUserID"></param>
        /// <returns> a Task containing int result </returns>
        public async Task<int> getUsersBankAccountID(string currUserID)
        {
            int accountID = _context.Userstoaccounts.Where(x => x.UserId == currUserID).AsNoTracking().ToList()[0].AccountId;
            await Task.CompletedTask;
            return accountID;
        }

        //TODO: add additonal services to fetch the required data for adding new transacitons

        /// <summary>
        ///  gets the opening balance of the user's account (currently only one account is supported)
        /// </summary>
        /// <param name="currAccountID"></param>
        /// <returns> a Task containing a float result </returns>
        public async Task<float> GetAccountCurrentBalance(int currAccountID)
        {
            float currBalance = (float)_context.Accounts.Where(x => x.AccountId == currAccountID).AsNoTracking().ToList()[0].Balance;
            await Task.CompletedTask;
            return currBalance;
        }

        /// <summary>
        /// adds a transaction
        /// </summary>
        /// <param name="objTransactionsmaster"></param>
        /// <returns> an empty result (I think) </returns>
        public Task<Transactionsmaster>
            CreateTransactionAsync(Transactionsmaster objTransactionsmaster)
        {
            _context.Transactionsmaster.Add(objTransactionsmaster);
            _context.SaveChanges();
            return Task.FromResult(objTransactionsmaster);
        }

        /// <summary>
        /// Updates the user's bank account information after a transaction
        /// </summary>
        /// <param name="newTrans"></param>
        /// <param name="currUserID"></param>
        /// <returns>Task with bool result</returns>
        public Task<bool> updateUsersBankBalanceAfterTransaction(Transactionsmaster newTrans, string currUserID)
        {
            int accountID = _context.Userstoaccounts.Where(x => x.UserId == currUserID).AsNoTracking().ToList()[0].AccountId;
            var existingAccount = _context.Accounts.Where(x => x.AccountId == accountID).FirstOrDefault();
            if(existingAccount != null)
            {
                decimal transactionAmount = newTrans.Transactionamount;
                existingAccount.Balance += transactionAmount;
                existingAccount.Lasttransaction = System.DateTime.Now;
                _context.SaveChanges();
            }
            else
            {
                return Task.FromResult(false);
            }
            return Task.FromResult(true);
        }
    }
}
