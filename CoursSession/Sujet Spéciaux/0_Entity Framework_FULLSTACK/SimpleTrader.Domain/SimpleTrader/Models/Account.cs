using SimpleTrader.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTrader.Models
{
    public class Account : DomainObject
    {
        public User AccountHolder { get; set; }
        public double Balance { get; set; }
        public IEnumerable<AssetTransaction> AssetTransactions { get; set; }

    }
}
