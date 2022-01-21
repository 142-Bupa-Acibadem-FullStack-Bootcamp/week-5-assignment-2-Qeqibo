using Northwind.Entity.Base;
using System;
using System.Collections.Generic;

#nullable disable

namespace Northwind.Entity.Dto
{
    public partial class DtoInvoice:DtoBase
    {
        public string ShipName { get; set; }
        public string ShipAddress { get; set; }
        public string ShipCity { get; set; }
        
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Salesperson { get; set; }
        
      
        public string ShipperName { get; set; }
        
    }
}
