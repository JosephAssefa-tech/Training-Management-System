using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class StaffEntity
    {
   
        public int Id { get; set; }

        public string Fullname { get; set; }
  
  
        public string PhoneNumber { get; set; }

        public string EmailAddress { get; set; }


        public string Username { get; set; }

        public string Password { get; set; }


        public virtual AcademicLevelEntity AcademicLevel { get; set; }

        public virtual GenderEntity Gender { get; set; }

        public virtual PositionEntity Position { get; set; }

        public virtual ICollection<TrainingStaffEntity> TrainingStaff { get; set; }
    }
}
