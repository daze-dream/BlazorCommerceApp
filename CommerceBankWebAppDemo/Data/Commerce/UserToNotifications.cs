﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace CommerceBankWebAppDemo.Data.Commerce
{
    [Table("userToNotifications")]
    public partial class UserToNotifications
    {
        [Column("userID")]
        public int UserId { get; set; }
        [Key]
        [Column("notificationID")]
        public int NotificationId { get; set; }
    }
}