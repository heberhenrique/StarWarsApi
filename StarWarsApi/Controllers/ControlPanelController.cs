using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StarWarsApi.Domain.Extensions;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StarWarsApi.Controllers
{
    [Route("api/[controller]")]
    public class ControlPanelController : Controller
    {
        [HttpPost]
        public string Post([FromBody] string value)
        {
            return value.GetNumerics();
        }
    }
}

