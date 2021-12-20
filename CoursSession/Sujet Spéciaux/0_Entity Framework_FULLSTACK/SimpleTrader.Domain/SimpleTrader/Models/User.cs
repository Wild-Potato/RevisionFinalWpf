using SimpleTrader.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTrader.Models
{
    public class User : DomainObject
    {
        public string Email { get; set; }
        public string Username { get; set; }
        public string PassWord { get; set; }
        public DateTime DateJoined { get; set; }

    }
}
