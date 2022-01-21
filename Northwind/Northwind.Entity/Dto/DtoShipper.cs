using Northwind.Entity.Base;
using System;
using System.Collections.Generic;

#nullable disable

namespace Northwind.Entity.Dto
{
    public partial class DtoShipper:DtoBase
    {
      

        
        public string CompanyName { get; set; }
        public string Phone { get; set; }

        
    }
}
