using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Net.Mail;

namespace BethanyPieShop.Models
{
    public class Register
    {
        [Key]
        public int UserId { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        [Required]
        public long PhoneNo { get; set; }
        [Required]
        public string EmialId { get; set; }
        [Required]
        public string Password { get; set; }

    }
}