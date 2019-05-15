
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicTrade.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int StarPoint { get; set; }
        public string StockStatus { get; set; }
        public int UnitInStock { get; set; }
        public int StarGivenMemberCount { get; set; }
        public int Product_Category_Id { get; set; }
        public string UserBy { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public Category category { get; set; }
        public List<ProductImage> productImages { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
        public List<Comment> comments { get; set; }
    }
}
