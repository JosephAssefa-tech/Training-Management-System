using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace DataModels.Models
{
    [Table("tableAcademicLevel")]
    public partial class TableAcademicLevel
    {
        public TableAcademicLevel()
        {
            TableStaffs = new HashSet<TableStaff>();
        }

        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [InverseProperty(nameof(TableStaff.AcademicLevel))]
        public virtual ICollection<TableStaff> TableStaffs { get; set; }
    }
}
