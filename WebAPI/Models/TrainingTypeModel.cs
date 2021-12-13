using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class TrainingTypeModel
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

    }
  
}
