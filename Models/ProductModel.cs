using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ecommerceMVC.Models
{
    public class ProductModel
    {
        public int ID { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public decimal Rating { get; set; }
        public decimal Price { get; set; }
        public bool OnSale { get; set; }
        public decimal SalePrice { get; set; }
        public bool FreeShipping { get; set; }
        public decimal ShippingCost { get; set; }
        public decimal DisplaySize { get; set; }
        public int DiskSize { get; set; }
        public bool DiskSizeGB { get; set; }
        public bool DiskSSD { get; set; }
        public int RAM { get; set; }
        public string OperatingSystem { get; set; }
        public bool InStock { get; set; }
        public int NumInStock { get; set; }
        public string LongDescription { get; set; }
    }
}
