using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace MyWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Car>> Get()
        {
            return new List<Car>()
            {
                new Car(){Color = "Red",Name = "Tesla",Year="2018"},
                new Car(){Color = "Black",Name = "Mercedes-Benz",Year="2015"},
                new Car(){Color = "White",Name = "Cadilac",Year="2014"},
                //new Car(){Color = "Blue",Name = "Porche",Year="2016"},
            };
        }
    }
}
