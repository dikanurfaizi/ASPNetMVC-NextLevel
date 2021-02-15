using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPNetMVC.Models
{
    public class Multiple
    {
        public Employee employees { get; set; }
        public Account accounts { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}