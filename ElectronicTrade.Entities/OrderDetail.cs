
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicTrade.Entities
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public int OrderDetail_Product_Id { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public int Discount { get; set; }
        public int OrderDetail_Order_Id { get; set; }
        public string UserBy { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public Order order { get; set; }
        public Product product { get; set; }
    }
}
