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
    }
}
