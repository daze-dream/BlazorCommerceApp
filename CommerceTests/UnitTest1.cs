using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
using Microsoft.Data.SqlClient;
using Bunit;
using Bunit.JSInterop;
using EndToEndTest.Pages;
using EndToEndTest.Shared;
using EndToEndTest.Components;
using EndToEndTest.Areas;
using EndToEndTest.Data;

namespace CommerceTests
{
    public class UnitTest1
    {
    [Fact]
        public void Test1()
        {
            //arrange
            using var testContext = new TestContext();
            var transactionsPage = testContext.RenderComponent<Transactions>();

            //act
            transactionsPage.Find("AddTransButton");
        }
    }
}
