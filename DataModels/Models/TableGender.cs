using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace DataModels.Models
{
    [Table("tableGender")]
    public partial class TableGender
    {
        public TableGender()
        {
            TableStaffs = new HashSet<TableStaff>();
            TableTrainees = new HashSet<TableTrainee>();
        }

        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [InverseProperty(nameof(TableStaff.Gender))]
        public virtual ICollection<TableStaff> TableStaffs { get; set; }
        [InverseProperty(nameof(TableTrainee.Gender))]
        public virtual ICollection<TableTrainee> TableTrainees { get; set; }
    }
}
