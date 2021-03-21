using System;
using CommerceBankWebAppDemo.Data.Commerce;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CommerceBankWebAppDemo.Data
{
    public class DemoService
    {
        private readonly CommerceappContext _context;

        public DemoService(CommerceappContext context)
        {
            _context = context;
        }
        public async Task<List<Transactionsmaster>> GetTransactions ()
        {
            return await _context.Transactionsmaster.AsNoTracking().ToListAsync();
        }
    }
}
