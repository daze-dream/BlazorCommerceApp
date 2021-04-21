using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommerceBankWebAppDemo.Data.Commerce;
using Microsoft.EntityFrameworkCore;

namespace CommerceBankWebAppDemo.Data
{
    public class LoginService
    {
        private readonly CommerceappContext _context;

        public LoginService(CommerceappContext context)
        {
            _context = context;
        }
    }
}
