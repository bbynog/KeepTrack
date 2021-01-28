using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KeepTrack.Models
{
    public class Bill
    {
        public int BillId { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }

        public string Creditor { get; set; }
        public string Debtor { get; set; }
        public string Description { get; set; }
        public int Amount { get; set; }
        public bool isOpen { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime CreditDate { get; set; }     
        public DateTime Created_at { get; set; }

        public Bill()
        {
            Amount = 0;
            Created_at = DateTime.Now;
            UserId = 1;
            isOpen = true;
        }
    }
}
