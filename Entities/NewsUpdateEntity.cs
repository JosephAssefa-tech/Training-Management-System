using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class NewsUpdateEntity
    {
        public int Id { get; set; }


        public string Message { get; set; }

        public DateTime CreatedDate { get; set; }


        public virtual TraineeEntity Trainee { get; set; }
    }
}
