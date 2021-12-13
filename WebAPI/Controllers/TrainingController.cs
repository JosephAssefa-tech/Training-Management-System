using Microsoft.AspNetCore.Mvc;
using ServiceFacade;
using ServiceManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrainingController : ControllerBase
    {

        TrainingService manager;
        public TrainingController(TrainingService service)
        {
            this.manager = service;


        }

        // GET: api/<TrainingController>
        [HttpGet]
        public List<TrainingModel> GetAllTraining()
        {
            this.manager.GetAllTraining();
         


        }

        // GET api/<TrainingController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TrainingController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<TrainingController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TrainingController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
