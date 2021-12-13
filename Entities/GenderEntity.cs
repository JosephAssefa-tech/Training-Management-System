using DataModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class GenderEntity:BaseEntity
    {

 
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<StaffEntity> Staff { get; set; }
        public virtual ICollection<TraineeEntity> Trainee { get; set; }

        public GenderEntity()
        {

        }

        public GenderEntity(TableGender table)
        {
            this.Id = table.Id;
            this.Name = table.Name;


        }

        public T MapToTable<T>() where T : class
        {
            TableGender table = new TableGender();
            table.Id = this.Id;
            table.Name = this.Name;

            return table as T;
           
        }
    }
}
