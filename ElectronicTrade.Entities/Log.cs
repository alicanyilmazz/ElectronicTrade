using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicTrade.Entities
{
    public class Log
    {   
        public int Id { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public DateTime AddedDate { get; set; }
        public string IpAddress { get; set; }
        public string UserBy { get; set; }
    }
}
