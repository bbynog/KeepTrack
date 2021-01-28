using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KeepTrack.Models
{
    public class User
    {
        public int UserId { get; set; }
        public List<Bill> Bills { get; set; }

        public string Name { get; set; }
        public string Password { get; set; }
        public int Balance { get; set; }        
    }
}
