using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class TrainingStaffEntity
    {
    
        public int Id { get; set; }


        public DateTime AssignedDate { get; set; }

        public virtual StaffEntity Staff { get; set; }

        public virtual TrainingEntity Training { get; set; }
    
}
}
