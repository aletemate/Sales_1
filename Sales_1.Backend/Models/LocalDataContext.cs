using Sales_1.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sales_1.Backend.Models
{
    public class LocalDataContext : DataContext
    {
        public System.Data.Entity.DbSet<Sales_1.Common.Models.Product> Products { get; set; }
    }
}