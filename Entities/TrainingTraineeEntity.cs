using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class TrainingTraineeEntity
    {
 
        public int Id { get; set; }

        public DateTime RegistrationDate { get; set; }

        public virtual TraineeEntity Trainee { get; set; }

        public virtual TrainingEntity Training { get; set; }
    }
}
