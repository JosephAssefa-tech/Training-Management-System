using DataModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
   public  class TrainingTypeEntity : BaseEntity
    {


        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<TrainingEntity> Training { get; set; }
        public TrainingTypeEntity(TableTrainingType table)
        {
            this.Id = table.Id;
            this.Name = table.Name;

        }


        public T MapToTable<T>() where T : class
        {
            TableTrainingType table = new TableTrainingType();
            table.Id = this.Id;
            table.Name = this.Name;

            return table as T;
        }
    }
}
