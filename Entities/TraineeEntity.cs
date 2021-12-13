using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class TraineeEntity
    {



        public int Id { get; set; }

        public string FirstName { get; set; }
    
        public string LastName { get; set; }

        public string Profession { get; set; }
   
        public string PhoneNumber { get; set; }
 
        public string EmailAddress { get; set; }
 
        public string Organization { get; set; }

        public string Department { get; set; }

        public virtual GenderEntity Gender { get; set; }

        public virtual RegionEntity Region { get; set; }
  
        public virtual ICollection<NewsUpdateEntity> NewsUpdate { get; set; }

        public virtual ICollection<TrainingTraineeEntity> TrainingTrainee { get; set; }
    }

}