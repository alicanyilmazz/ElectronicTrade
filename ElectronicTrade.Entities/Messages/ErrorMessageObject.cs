using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicTrade.Entities.Messages
{
    public class ErrorMessageObject
    {
        public ErrorMessageCode Code { get; set; }
        public string Message { get; set; }
    }
}
