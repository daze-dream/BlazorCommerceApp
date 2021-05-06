using System;
using System.Windows;
using EndToEndTest.Data.CommerceDataModels;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;

namespace EndToEndTest.Data
{

    /// <summary>
    /// This class is a Service that deals with getting how many times a notification has been triggered, as well as
    ///     getting the TriggeredNotif table data to use for summaries and latest notifications.
    /// </summary>
    public class NotificationTriggeredServices : NotificationServices
    {
        /// <summary>
        /// database context variable
        /// </summary>
        private readonly CommerceappContext _context;

        /// <summary>
        /// Constructor, parameter passed in startup.cs or in tests
        /// </summary>
        /// <param name="context"></param>
        public NotificationTriggeredServices(CommerceappContext context) : base(context)
        {

        }


    }
}
