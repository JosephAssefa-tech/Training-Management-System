using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace DataModels.Models
{
    [Table("tableTrainingType")]
    public partial class TableTrainingType
    {
        public TableTrainingType()
        {
            TableTrainings = new HashSet<TableTraining>();
        }

        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [InverseProperty(nameof(TableTraining.TrainingType))]
        public virtual ICollection<TableTraining> TableTrainings { get; set; }
    }
}
