using Sales_1.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sales_1.Backend.Models
{
    public class ProductView : Product
    {

        public HttpPostedFileBase ImageFile
        {
            get; set;
        }
    }
}