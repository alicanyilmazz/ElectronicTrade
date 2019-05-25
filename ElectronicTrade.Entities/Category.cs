
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicTrade.Entities
{
    public class Category
    {
        public Category()
        {
            Categories = new List<Category>();
            products = new List<Product>();

        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ActionName { get; set; }
        public string ControllerName { get; set; }
        public string QueryStrings { get; set; }
        public int OrderNumber { get; set; }
        public int? ParentCategory_Id { get; set; }
        public string UserBy { get; set; }
        public DateTime? AddedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public Category ParentCategory { get; set; }
        public List<Category> Categories { get; set; }
        public List<Product> products { get; set; }
    }
}
