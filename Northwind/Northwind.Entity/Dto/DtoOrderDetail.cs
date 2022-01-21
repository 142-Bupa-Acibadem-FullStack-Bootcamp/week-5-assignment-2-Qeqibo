using Northwind.Entity.Base;
using System;
using System.Collections.Generic;

#nullable disable

namespace Northwind.Entity.Dto
{
    public partial class DtoOrderDetail:DtoBase
    {
        
        public decimal UnitPrice { get; set; }
        public short Quantity { get; set; }
        public float Discount { get; set; }

       
    }
}
