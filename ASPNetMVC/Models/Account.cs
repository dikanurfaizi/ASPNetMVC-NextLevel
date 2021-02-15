using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ASPNetMVC.Models
{
    [Table("Tb_M_Account")]
    public class Account
    {
        [Key][ForeignKey("Employee")]
        public int Id { get; set; }

        public string Password { get; set; }

        public virtual Employee Employee { get; set; }
    }
}