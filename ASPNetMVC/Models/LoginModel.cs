using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPNetMVC.Models
{
    public class LoginModel
    {
        public int ID { get; set; }
        public string EmailEmployee { get; set; }
        public string PasswordAccount { get; set; }
    }
}