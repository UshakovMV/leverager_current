using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Leverager_projects.Models
{
    public class Category
    {        
        public int ID { get; set; }
        public string Name { get; set; }
        public string Descriptions { get; set; }
        public bool Active { get; set; }
        public bool Master { get; set; }
        public string ParentName { get; set; }        
    }

    public class LeveragerDBContext : DbContext
    {
        public DbSet<Category> Categoryes { get; set; }
    }
}