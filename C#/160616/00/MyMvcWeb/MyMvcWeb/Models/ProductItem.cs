using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyMvcWeb.Models
{
    public class ProductItem
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public int? StoreId { get; set; }
        public string StoreName { get; set; }
        public int? TypeId { get; set; }
        public string TypeName { get; set; }
        public double? Price { get; set; }
        public string Unit { get; set; }
        public int? Stock  { get; set; }
        public byte? SellOrNot { get; set; }        
    }
}