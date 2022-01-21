using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Northwind.Entity.Base;
using Northwind.Entity.Dto;
using Northwind.Entity.IBase;
using Northwind.Entity.Models;
using Northwind.Interface;
using Northwind.WebApi.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace Northwind.WebApi.Controllers
{
    //uygulama.patika.com/api/order
    [Route("api/[controller]")]
    [ApiController]
    public class ShipperController : ApiBaseController<IShipperService, Shipper, DtoShipper>
    {
        
        


        public ShipperController(IShipperService Service) : base(Service)
        {
           
        }

    
    }
}
