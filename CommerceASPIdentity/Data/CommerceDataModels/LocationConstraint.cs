﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace EndToEndTest.Data.CommerceDataModels
{
    [Table("location_constraint")]
    public partial class LocationConstraint
    {
        [Key]
        [Column("notificationID")]
        public int NotificationId { get; set; }
        [Required]
        [Column("location")]
        [StringLength(200)]
        public string Location { get; set; }

        [ForeignKey(nameof(NotificationId))]
        [InverseProperty(nameof(UserToNotifications.LocationConstraint))]
        public virtual UserToNotifications Notification { get; set; }
    }
}