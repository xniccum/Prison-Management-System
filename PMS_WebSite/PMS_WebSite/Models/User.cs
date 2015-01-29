﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PMS_WebSite.Models
{
    public class User
    {
        [Key]
        [Required]
        public int ID { get; set; }
        [Required]
        public string username { get; set; }
        public string password { get; set; }
        public string permissions { get; set; }
    }
}