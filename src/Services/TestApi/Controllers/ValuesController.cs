using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommonLibrary;
using Microsoft.AspNetCore.Mvc;

namespace TestApi.Controllers
{
   [Route("api/[controller]")]
   public class ValuesController : Controller
   {

      private readonly MyCoolLib _myCoolLib;

      public ValuesController(MyCoolLib myCoolLib)
      {
         _myCoolLib = myCoolLib;
      }

      // GET api/values
      [HttpGet]
      public async Task<IActionResult> Get()
      {
            await Task.Delay(1);
            return Ok(_myCoolLib.DoSomething());
      }

      // GET api/values/5
      [HttpGet("{id}")]
      public string Get(int id)
      {
         return "value";
      }

      // POST api/values
      [HttpPost]
      public void Post([FromBody]string value)
      {
      }

      // PUT api/values/5
      [HttpPut("{id}")]
      public void Put(int id, [FromBody]string value)
      {
      }

      // DELETE api/values/5
      [HttpDelete("{id}")]
      public void Delete(int id)
      {
      }
   }
}
