using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace SGBank.Models
{
    public class Account
    {
        public int AccountID { get; set; }
        public decimal Balance { get; set; }
        public string Name { get; set; }
    }
}
