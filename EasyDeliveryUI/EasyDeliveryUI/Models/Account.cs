using System;
using System.Collections.Generic;
using System.Text;

namespace EasyDeliveryUI.Models
{
    public class Account
    {
        public string Username{ get; set; }
        public string Lastname { get; set; }
        public string Password { get; set; }
        public int Id_Card { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int PhoneUser { get; set; }
        public string EmailUser { get; set; }
        public Account()
        {
            DateOfBirth = DateTime.UtcNow;
        }
    }
}
