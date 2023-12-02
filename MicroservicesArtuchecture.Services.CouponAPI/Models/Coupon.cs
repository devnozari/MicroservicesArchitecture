﻿using System.ComponentModel.DataAnnotations;

namespace MicroservicesArtuchecture.Services.CouponAPI.Models
{
    public class Coupon
    {
        [Key]
        public int CouponId { get; set; }
        [Required]
        public string CouponCode { get; set; }
        [Required]
        public double DiscountAmount { get; set; }
        public int MinAmount { get; set; }

        public DateTime CreateDate
        {
            get { return DateTime.Now; }
        }

    }
}
