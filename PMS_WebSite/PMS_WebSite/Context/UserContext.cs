using PMS_WebSite.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PMS_WebSite.Context
{
    public class UserContext : DbContext
    {
        public DbSet<User> Monsters { get; set; }
    }
}