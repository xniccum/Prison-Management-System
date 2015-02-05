using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Prison_Managment_System_Site.Models
{
    public class User
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage="Username is Required")]
        [StringLength(15)]
        [DisplayName("Username")]
        public string username { get; set; }
        [StringLength(10)]
        [DisplayName("Password")]
        public string password { get; set; }
        [StringLength(10)]
        [DisplayName("Permissions")]
        public string permissions { get; set; }
    }
}