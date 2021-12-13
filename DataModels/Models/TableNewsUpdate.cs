using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace DataModels.Models
{
    [Table("tableNewsUpdate")]
    public partial class TableNewsUpdate
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("TraineeID")]
        public int TraineeId { get; set; }
        [Required]
        [StringLength(500)]
        public string Message { get; set; }
        [Column(TypeName = "date")]
        public DateTime CreatedDate { get; set; }

        [ForeignKey(nameof(TraineeId))]
        [InverseProperty(nameof(TableTrainee.TableNewsUpdates))]
        public virtual TableTrainee Trainee { get; set; }
    }
}
