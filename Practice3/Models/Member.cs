using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practice3.Models
{
    public class Member
    {

        public int Id { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public string OTP { get; set; }

        public StatusEnum Status { get; set; }
    }
    public enum StatusEnum { ACTIVE, DEACTIVE, DELETE }
}