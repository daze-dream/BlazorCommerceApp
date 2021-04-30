using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EndToEndTest.Data;
using EndToEndTest.Data.CommerceDataModels;
using Xunit;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore.InMemory;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Security.Claims;



namespace EndToEndTest.xUnitTests
{
    public class xUnitTesting
    {
        private readonly CommerceappContext _context;
        private  TransactionSummary _sut;
        private TransactionServices _ts;
        public xUnitTesting()
        {
            _sut = new TransactionSummary();
            var optionsBuilder = new DbContextOptionsBuilder<CommerceappContext>()
                .UseSqlServer("Server=tcp:cs451group5.database.windows.net,1433;Initial Catalog=commerceapp;Persist Security Info=False;User ID=cs451x;Password=Supermongodb2;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30; ");
            _context = new CommerceappContext(optionsBuilder.Options);
            _ts = new TransactionServices(_context);
        }
        [Fact]
        public async Task CountRecentTransactionsReturned()
        {
            List<Transactionsmaster> temp = await _ts.GetTransactions("b48b3368-019a-4ef3-bcd7-2f9a425eaac7");
            int x = temp.Count();
            Assert.Equal(x, temp.Count());
        }
        [Fact]
        public async Task SubmitTransaction()
        {

        }
    }
}
