using Northwind.Entity.Base;
using System;
using System.Collections.Generic;

#nullable disable

namespace Northwind.Entity.Dto
{
    public partial class DtoOrderSubtotal:DtoBase
    {
        
        public decimal? Subtotal { get; set; }
    }
}
