using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class TrainingModel
    {

        public int Id { get; set; }

        public string Name { get; set; }


        public string Fund { get; set; }

        public string TargetAudience { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string VerificationCode { get; set; }

        public string Status { get; set; }


        public virtual TrainingTypeModel TrainingType { get; set; }

        public TrainingModel()
        {

        }
        public TrainingModel(TrainingEntity entity)
        {
            this.Id = entity.Id;
            this.Name = entity.Name;
            this.Fund = entity.Fund;
            this.TargetAudience = entity.TargetAudience;
            this.StartDate = entity.StartDate;
            this.EndDate = entity.EndDate;
            this.VerificationCode = entity.VerificationCode;
            this.Status = entity.Status;
            this.TrainingType = entity.TrainingType;


    }



    }
}
