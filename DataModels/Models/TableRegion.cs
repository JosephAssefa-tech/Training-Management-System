using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace DataModels.Models
{
    [Table("tableRegion")]
    public partial class TableRegion
    {
        public TableRegion()
        {
            TableTrainees = new HashSet<TableTrainee>();
        }

        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [InverseProperty(nameof(TableTrainee.Region))]
        public virtual ICollection<TableTrainee> TableTrainees { get; set; }
    }
}
