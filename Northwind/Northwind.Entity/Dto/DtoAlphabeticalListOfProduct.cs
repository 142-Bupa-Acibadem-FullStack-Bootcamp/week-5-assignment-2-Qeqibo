using Northwind.Entity.Base;

using System;
using System.Collections.Generic;

#nullable disable

namespace Northwind.Entity.Dto
{
    public class DtoAlphabeticalListOfProduct:DtoBase
    {
        public DtoAlphabeticalListOfProduct()
        {
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        
        
        
        public decimal? UnitPrice { get; set; }
        public short? UnitsInStock { get; set; }
        
        public short? ReorderLevel { get; set; }
        public bool Discontinued { get; set; }
        public string CategoryName { get; set; }
    }
}
