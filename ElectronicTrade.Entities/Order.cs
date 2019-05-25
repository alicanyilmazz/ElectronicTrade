
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicTrade.Entities
{
    public class Order
    {
        public Order()
        {
            OrderDetails = new List<OrderDetail>();
        }

        public int Id { get; set; }
        public string Number { get; set; }      
        public string Status { get; set; }
        public string UserBy { get; set; }
        public int Order_Member_Id { get; set; }     
        public int Order_Address_Id { get; set; }     
        public string Description { get; set; }
        public DateTime? AddedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public Member member { get; set; }
        public Address address { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}
