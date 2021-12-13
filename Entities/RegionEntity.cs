using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class RegionEntity
    {
 
        public int Id { get; set; }

        public string Name { get; set; }


        public virtual ICollection<TraineeEntity> Trainee { get; set; }
    }
}
