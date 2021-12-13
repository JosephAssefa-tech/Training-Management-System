using DataModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class TrainingEntity:BaseEntity
    {
  
        public int Id { get; set; }

        public string Name { get; set; }
  

        public string Fund { get; set; }

        public string TargetAudience { get; set; }

        public DateTime StartDate { get; set; }
     
        public DateTime EndDate { get; set; }

        public string VerificationCode { get; set; }

        public string Status { get; set; }


        public virtual TrainingTypeEntity TrainingType { get; set; }



        public TrainingEntity()
        {

        }

        public TrainingEntity(TableTraining table)
        {
          
            this.Id = table.Id;
            this.Name = table.Name;
            this.StartDate = table.StartDate;
            this.EndDate = table.EndDate;
            this.Fund = table.Fund;
            this.TrainingType = new TrainingTypeEntity(table.TrainingType);
            this.VerificationCode = table.VerificationCode;
            this.Status = table.Status;
            this.TargetAudience = table.TargetAudience;
        }

        public T MapToTable<T>() where T : class
        {
            TableTraining table = new TableTraining();
            table.Id = this.Id;
            table.Name = this.Name;
            table.StartDate = this.StartDate;
            table.EndDate = this.EndDate;
            table.Fund = this.Fund;
            table.TrainingTypeId = this.TrainingType.Id;
            table.VerificationCode = this.VerificationCode;
            table.Status = this.Status;
            table.TargetAudience = this.TargetAudience;

            return table as T;

        }
    }
 
}
