using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicTrade.Entities
{
    public class Localization
    {      
        public int Id { get; set; }   
        public string Culture { get; set; }    
        public string Text { get; set; }
        public string Name { get; set; }
    }
}
