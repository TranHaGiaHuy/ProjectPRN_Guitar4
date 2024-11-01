using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObject.DTO
{
    public class ProductEdit
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductImage { get; set; }
        public double ProductPrice { get; set; }
        public int CategoryID { get; set; }
        public int ProductQuantity { get; set; }
        public string ProductDetailDescription { get; set; }
        public string ProductBackWood { get; set; }
        public string ProductSideWood { get; set; }
        public string ProductSeries { get; set; }
        public string ProductOrigin { get; set; }
        public string ProductNeck { get; set; }
        public string ProductLength { get; set; }
    }
}
