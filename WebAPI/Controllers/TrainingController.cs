using Entities;
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

        ITrainigServiceCRUD manager;
        ITrainingService _service;


        public TrainingController(ITrainigServiceCRUD services, ITrainingService service)
        {
            this.manager = services;
            this._service = service;
      

             

        }

        // GET: api/<TrainingController>
        [HttpGet]
        [Route("GetAll")]
        public List<TrainingModel> GetAll()
        {
            List<TrainingEntity> entities = this.manager.GetAllTraining();
            List<TrainingModel> models = new List<TrainingModel>();
            foreach (var entity in entities)
            {
                TrainingModel model = new TrainingModel(entity);
                models.Add(model);
            }
            return models;

        }

        // GET api/<TrainingController>/5
        [HttpGet("{id}")]
        public string  Get(int id)
        {
            return "something here";
           

        }

        // POST api/<TrainingController>
        [HttpPost]
        [Route("Save")]
        public string  Save([FromBody] TrainingModel training)
        {
            string result = this.manager.Save(training.MapToEntity<TrainingEntity>());
            return result;

            if (result == "Saved Sucessfully")
            {


             
            }
            else
            {

            }

        }

        // PUT api/<TrainingController>/5
        [HttpPut("{id}")]
        public void Update([FromBody] TrainingModel training)
        {
            string result = this.manager.Update(training.MapToEntity<TrainingEntity>());
            if (result == "Updated Sucessfully")
            {


            }
            else
            {

            }


        }
        // DELETE api/<TrainingController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {


        }
    }
}
