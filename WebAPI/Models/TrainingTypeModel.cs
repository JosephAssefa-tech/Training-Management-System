using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class TrainingTypeModel:BaseModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public TrainingTypeModel()
        {

        }
        public TrainingTypeModel(TrainingTypeEntity entity)
        {
            this.Id = entity.Id;
            this.Name = entity.Name;
        }

        public T MapToEntity<T>() where T : class
        {
            TrainingTypeEntity entity = new TrainingTypeEntity();
            entity.Id = this.Id;
            entity.Name = this.Name;

            return entity as T;

          
        }
    }
  
}
