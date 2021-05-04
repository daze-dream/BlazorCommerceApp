using System;
using System.Windows;
using EndToEndTest.Data.CommerceDataModels;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;
using CsvHelper;
using System.IO;
using System.Globalization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.JSInterop;

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

        /// <summary>
        /// ONLY TO BE USED WHEN ADDING A NEW NOTIFICATION RULE.
        /// Gets the most recent notification rule ID that was added in. This is used for the join table to connect with the actual table
        /// </summary>
        /// <param name="currUserID"></param>
        /// <returns>List of NotificationJoin</returns>
        public async Task<int> GetMostRecentNotifJoinTableRule(string currUserID)
        {
           int toReturn =_context.UserToNotifications
                .Where(x => x.UserId == currUserID)
                .OrderByDescending(x => x.NotificationId)
                .ToList()[0].NotificationId;
            await Task.CompletedTask;
            return toReturn;
        }

        /// <summary>
        /// Gets a list the UserToNotification join table based on userID.
        /// </summary>
        /// <param name="currUserID"></param>
        /// <returns>List of UserToNotifcations</returns>
        public async Task<List<UserToNotifications>> GetNotifJoinTable (string currUserID)
        {
            return await _context.UserToNotifications
                .Where(x => x.UserId == currUserID)
                .AsNoTracking()
                .ToListAsync();
        }

        /// <summary>
        /// Returns the notification that matches the passed ID
        /// </summary>
        /// <param name="notifID"></param>
        /// <returns></returns>
        public async Task<UserToNotifications> getSingleNotif(int notifID)
        {
            return await _context.UserToNotifications
                .Where(x => x.NotificationId == notifID)
                .AsNoTracking()
                .SingleOrDefaultAsync();
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

        /// <summary>
        /// Adds a new AmountConstraint notification rule to database context
        /// </summary>
        /// <param name="newNotif"></param>
        /// <returns>true or false from Task</returns>
        public Task<AmountConstraint> AddAmountNotification(AmountConstraint newNotif)
        {
            _context.AmountConstraint.Add(newNotif);
            _context.SaveChanges();
            return Task.FromResult(newNotif);
        }


        /// <summary>
        /// Adds a new TimeConstraint notification rule to database context
        /// </summary>
        /// <param name="newNotif"></param>
        /// <returns>true or false from Task</returns>
        public Task<TimeConstraint> AddTimeNotification(TimeConstraint newNotif)
        {
            _context.TimeConstraint.Add(newNotif);
            _context.SaveChanges();
            return Task.FromResult(newNotif);
        }


        /// <summary>
        /// Adds a new LocationConstraint notification rule to database context
        /// </summary>
        /// <param name="newNotif"></param>
        /// <returns>true or false from Task</returns>
        public Task<LocationConstraint> AddLocationNotification(LocationConstraint newNotif)
        {
            _context.LocationConstraint.Add(newNotif);
            _context.SaveChanges();
            return Task.FromResult(newNotif);
        }



        public Task<bool> AddNewUsersToNotifJoinTableEntry(UserToNotifications x)
        {
            _context.UserToNotifications.Add(x);
            int result = _context.SaveChanges();
            if(result > 0)
            {
                return Task.FromResult(true);
            }
            else
            {
                return Task.FromResult(false);
            }
            

        }

        public Task<bool> updateNotificationsAsync(object notif)
        {
            if(notif is AmountConstraint)
            {
                AmountConstraint castedNotif = (AmountConstraint)notif;
                var existingNotif = _context.AmountConstraint
                    .Where(x => x.NotificationId == castedNotif.NotificationId)
                    .FirstOrDefault();
                if(existingNotif != null)
                {
                    existingNotif.Min = castedNotif.Min;
                    existingNotif.Max = castedNotif.Max;
                    _context.SaveChanges();
                }
                else return Task.FromResult(false);
            }
            else if(notif is TimeConstraint)
            {
                TimeConstraint castedNotif = (TimeConstraint)notif;
                var existingNotif = _context.TimeConstraint
                    .Where(x => x.NotificationId == castedNotif.NotificationId)
                    .FirstOrDefault();
                if (existingNotif != null)
                {
                    existingNotif.TimeIn = castedNotif.TimeIn;
                    existingNotif.TimeOut = castedNotif.TimeOut;
                    _context.SaveChanges();
                }
                else return Task.FromResult(false);

            }
            else if (notif is LocationConstraint)
            {
                LocationConstraint castedNotif = (LocationConstraint)notif;
                var existingNotif = _context.LocationConstraint
                    .Where(x => x.NotificationId == castedNotif.NotificationId)
                    .FirstOrDefault();
                if (existingNotif != null)
                {
                    existingNotif.Location = castedNotif.Location;
                    _context.SaveChanges();
                }
                else return Task.FromResult(false);
            }

            return Task.FromResult(true);
        }

        public Task<bool> DeleteNotificationAsync(object notif)
        {
            if (notif is AmountConstraint)
            {
                AmountConstraint castedNotif = (AmountConstraint)notif;
                var existingNotif = _context.AmountConstraint
                    .Where(x => x.NotificationId == castedNotif.NotificationId)
                    .FirstOrDefault();
                var existingJoin = _context.UserToNotifications
                    .Where(y => y.NotificationId == castedNotif.NotificationId)
                    .FirstOrDefault();
                if (existingNotif != null)
                {
                    _context.AmountConstraint.Remove(existingNotif);
                    _context.UserToNotifications.Remove(existingJoin);
                    _context.SaveChanges();
                }
                else return Task.FromResult(false);
            }
            else if (notif is TimeConstraint)
            {
                TimeConstraint castedNotif = (TimeConstraint)notif;
                var existingNotif = _context.TimeConstraint
                    .Where(x => x.NotificationId == castedNotif.NotificationId)
                    .FirstOrDefault();
                var existingJoin = _context.UserToNotifications
                    .Where(y => y.NotificationId == castedNotif.NotificationId)
                    .FirstOrDefault();
                if (existingNotif != null)
                {
                    _context.TimeConstraint.Remove(existingNotif);
                    _context.UserToNotifications.Remove(existingJoin);
                    _context.SaveChanges();
                }
                else return Task.FromResult(false);

            }
            else if (notif is LocationConstraint)
            {
                LocationConstraint castedNotif = (LocationConstraint)notif;
                var existingNotif = _context.LocationConstraint
                    .Where(x => x.NotificationId == castedNotif.NotificationId)
                    .FirstOrDefault();
                var existingJoin = _context.UserToNotifications
                    .Where(y => y.NotificationId == castedNotif.NotificationId)
                    .FirstOrDefault();
                if (existingNotif != null)
                {
                    _context.LocationConstraint.Remove(existingNotif);
                    _context.UserToNotifications.Remove(existingJoin);
                    _context.SaveChanges();
                }
                else return Task.FromResult(false);
            }

            return Task.FromResult(true);
        }

        /// <summary>
        /// Returns a single entry from the TriggeredNotif table based on notifID
        /// </summary>
        /// <param name="notifID"></param>
        /// <returns></returns>
        public async Task<TriggeredNotif> GetSingleTriggeredNotifEntry(int notifID)
        {
            return await _context.TriggeredNotif
                .Where(x => x.TrigNotifId == notifID)
                .SingleAsync();                
        }
        /// <summary>
        /// Gets all the TriggeredNotif of the user's email, dubbed "name" by ASP Identity.
        /// </summary>
        /// <param name="notifArray"></param>
        /// <returns>Task with list of TriggeredNotif</returns>
        public async Task<List<TriggeredNotif>> GetAllTriggeredNotifEntries(/*List<UserToNotifications> notifArray,*/ string userEmail)
        {

            return await _context.TriggeredNotif
                .Where(x => x.EmailSentTo == userEmail)
                .OrderBy(x => x.DateAdded)
                .AsNoTracking()
                .ToListAsync();

        }

        /// <summary>
        /// Gets most recent 5 TriggeredNotif of the user's email, dubbed "name" by ASP Identity.
        /// </summary>
        /// <param name="notifArray"></param>
        /// <returns>Task with list of TriggeredNotif</returns>
        public async Task<List<TriggeredNotif>> GetTriggeredNotifSummary(/*List<UserToNotifications> notifArray,*/ string userEmail)
        {

            return await _context.TriggeredNotif
                .Where(x => x.EmailSentTo == userEmail)
                .Take(5)
                .OrderBy(x => x.DateAdded)
                .AsNoTracking()
                .ToListAsync();

        }

        /// <summary>
        /// Gets all the user's notifications, joined as one table, including the monthly counts, with a stored procedure.
        /// For context, joins userToNotifications, time/amount/location_constraint, coalesces and changes column names
        /// </summary>
        /// <param name="userId"></param>
        /// <returns>Task of List 'joinAllNotifsResult' </returns>
        public async Task<List<joinAllNotifsResult>> getAllNotifsJoinedWithDates(string userId)
        {
            var procedures = new CommerceappContextProcedures(_context);
            return await procedures.joinAllNotifsAsync(userId);
        }

        //public async Task<FileContentResult> exportToCSVService(string id)
        //{
        //    using var memorystream = new MemoryStream();
        //    using var writer = new StreamWriter(memorystream);
        //    using var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);
        //    var allJoinedNotifs = await getAllNotifsJoinedWithDates(id);
        //    {
        //        csv.WriteRecords(allJoinedNotifs);
        //        writer.Flush();
        //    }
        //    FileContentResult result = new FileContentResult(memorystream.GetBuffer(), "text/csv")
        //    {
        //        FileDownloadName = "notifications.csv"
        //    };
        //    return result;
        //}

        /// <summary>
        /// invokes the javascript file located at wwwroot with the following parameters. It tries to download a file from the byte array as csv
        /// 
        /// </summary>
        /// <param name="js"></param>
        /// <param name="filename"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public async  Task SaveAs(IJSRuntime js, string filename, byte[] data)
        {
            await js.InvokeAsync<object>(
                "FileSaveAs",
                filename,
                Convert.ToBase64String(data));
        }

    }
}
