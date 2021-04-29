using System;
using EndToEndTest.Data.CommerceDataModels;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;

namespace EndToEndTest.Data
{
    public class TransactionSummary
    {
        private readonly CommerceappContext _context;
        private readonly IHttpContextAccessor _httpCA;
        private List<Transactionsmaster> transactions;
        public TransactionSummary(CommerceappContext context)
        {
            _context = context;
        }

        // this method only returns 5 most recent transactions from account
        public async Task<List<Transactionsmaster>> GetRecentTransaction(string userID)
        {
            transactions = _context.Transactionsmaster
                .Where(x => x.UserId == userID)
                .OrderByDescending(x => x.Transactiondate)
                .Take(5)
                .AsNoTracking()
                .ToList();

            return transactions;
        }

        //returns a dictionary that holds the description of a transaction as the key and the transaction
        //amount as the value
        public async Task<Dictionary<String, decimal>> getTransactionDescription(string userID)
        {
            Dictionary<String, decimal> transactionDescription = new Dictionary<String, decimal>();
            foreach (Transactionsmaster trans in transactions)
            {
                transactionDescription.Add(trans.Description, trans.Transactionamount);
            }

            return transactionDescription;
        }
    }
}