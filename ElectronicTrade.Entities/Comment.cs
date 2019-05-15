
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicTrade.Entities
{
    public class Comment
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string UserBy { get; set; }
        public int Comment_Member_Id { get; set; }
        public int Comment_Product_Id { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public Member member { get; set; }
        public Product product { get; set; }
    }
}
