using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicTrade.Entities
{
    public class ProductImage
    {
        public int Id { get; set; }
        public string FirstImageName { get; set; }
        public string SecondImageName { get; set; }
        public string ThirdImageName { get; set; }
        public string UserBy { get; set; }
        public string FourthImageName { get; set; }
        public int ProductImage_Product_Id { get; set; }
        public Product product { get; set; }
    }
}
