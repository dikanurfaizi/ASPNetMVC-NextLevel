using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ASPNetMVC.Models
{
    [Table("Tb_M_Division")]
    public class Division
    {
        [Key]
        public int Id
        {
            get; set;
        }

        public string Name
        {
            get; set;
        }
    }
}