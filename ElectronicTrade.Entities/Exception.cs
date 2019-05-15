using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicTrade.Entities
{
    public class Exception
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public string Detail { get; set; }
        public string UserBy { get; set; }
        public DateTime AddedDate { get; set; }
        public string ControllerName { get; set; }
        public string ActionName { get; set; }
    }
}
