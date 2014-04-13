using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace Leverager_projects.Models
{
    public class Category
    {                
        [Key]
        public int ID { get; set; }        
        public string Name { get; set; }
        public string Descriptions { get; set; }
        public bool Active { get; set; }
        public bool Master { get; set; }        
        public Nullable<int> ParentID { get; set; }
    }

    public class Products
    {
        [Key]
        public int ProductID { get; set; }
        public int SKU { get; set; }
        public string ProductName { get; set; }
        public string ProductDescriptions { get; set; }
        public int CategoryID { get; set; }
        public int SupplierID { get; set; }
        public int QuantityPerUnit { get; set; }
        public int UnitPrice { get; set; }
        public int MSRP { get; set; }
        public int AvailableSize { get; set; }
        public int AvailableColors { get; set; }
        public string Size { get; set; }
        public string Colors { get; set; }
        public int Discount { get; set; }
        public float UnitWeight { get; set; }
        public string PictureUrl { get; set; }
        public int Ranking { get; set; }
        
    }
    
    public class LeveragerDBContext : DbContext
    {
        public DbSet<Category> Categoryes { get; set; }
        public DbSet<Products> Products { get; set; }                
    }
}