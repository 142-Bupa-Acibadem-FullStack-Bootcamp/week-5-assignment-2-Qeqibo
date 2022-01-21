using Northwind.Entity.Base;
using System;
using System.Collections.Generic;

#nullable disable

namespace Northwind.Entity.Dto
{
    public partial class DtoSummaryOfSalesByQuarter:DtoBase
    {
        public DateTime? ShippedDate { get; set; }
       
        public decimal? Subtotal { get; set; }
    }
}
