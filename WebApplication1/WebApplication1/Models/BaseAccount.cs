using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class BaseAccount
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool VerifyLogin()
        {
            if (this.UserName == "shahadat" && this.Password == "123456")
            {
                return true;
            }
            return false;
        }
    }
}