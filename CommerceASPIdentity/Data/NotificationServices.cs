using System;
using System.Windows;
using EndToEndTest.Data.CommerceDataModels;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;

namespace EndToEndTest
{
    public class NotificationServices
    {
        private readonly CommerceappContext _context;
        private readonly IHttpContextAccessor _httpCA;


        public NotificationServices(CommerceappContext context)
        {
            _context = context;
        }

        /// <summary>
        /// this method only returns 5 most recent transactions from account
        /// </summary>
        /// <param name="currUserID"></param>
        /// <returns>Task<list></list>"</returns>
        public async Task<List<Transactionsmaster>> GetRecentTransaction(string currUserID)
        {

            return await _context.Transactionsmaster
            .Where(x => x.UserId == currUserID)
            .OrderByDescending(x => x.Transactiondate)
            .Take(5)
            .AsNoTracking()
            .ToListAsync();
        }

        public async Task<List<UserToNotifications>> GetNotifJoinTable (string currUserID)
        {
            return await _context.UserToNotifications
                .Where(x => x.UserId == currUserID)
                .AsNoTracking()
                .ToListAsync();
        }

        /// <summary>
        /// Returns a list of the user's AmountConstraint notifcation rules
        /// </summary>
        /// <param name="notifID"></param>
        /// <returns> List of AmountConstraint</returns>
        public async Task<List<AmountConstraint>> GetAmountConstraints(List<UserToNotifications> notifArray)
        {

            List<AmountConstraint> amountConstraints = new List<AmountConstraint>();
            List<AmountConstraint> testC = new List<AmountConstraint>();

            foreach (var z in notifArray)
            {
                testC = _context.AmountConstraint.Where(x => x.NotificationId == z.NotificationId).ToList();

                if ( testC.Count > 0)
                {
                    AmountConstraint temp = _context.AmountConstraint.Where(x => x.NotificationId == z.NotificationId).ToList()[0];

                    amountConstraints.Add(temp);
                }

            }

            return amountConstraints;
        }


        public async Task<List<TimeConstraint>> GetTimeConstraints(List<UserToNotifications> notifArray)
        {

            List<TimeConstraint> timeConstraints = new List<TimeConstraint>();
            List<TimeConstraint> testC = new List<TimeConstraint>();
            foreach (var z in notifArray)
            {
                testC = _context.TimeConstraint.Where(x => x.NotificationId == z.NotificationId).ToList();

                if (testC.Count > 0)
                {
                    TimeConstraint temp = _context.TimeConstraint.Where(x => x.NotificationId == z.NotificationId).ToList()[0];

                    timeConstraints.Add(temp);
                }
            }
            
            return timeConstraints;
        }

        public async Task<List<LocationConstraint>> GetLocationConstraints(List<UserToNotifications> notifArray)
        {
            List<LocationConstraint> locationConstraints = new List<LocationConstraint>();
            List<LocationConstraint> testC = new List<LocationConstraint>();

            foreach (var z in notifArray)
            {
                testC = _context.LocationConstraint.Where(x => x.NotificationId == z.NotificationId).ToList();
                if (testC.Count > 0)
                {
                    LocationConstraint temp = _context.LocationConstraint.Where(x => x.NotificationId == z.NotificationId).ToList()[0];

                    locationConstraints.Add(temp);
                }
            }

            return locationConstraints;
        }











    }
}
