using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace DataModels.Models
{
    [Table("tableTrainingStaff")]
    public partial class TableTrainingStaff
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("TrainingID")]
        public int TrainingId { get; set; }
        [Column("StaffID")]
        public int StaffId { get; set; }
        [Column(TypeName = "date")]
        public DateTime AssignedDate { get; set; }

        [ForeignKey(nameof(StaffId))]
        [InverseProperty(nameof(TableStaff.TableTrainingStaffs))]
        public virtual TableStaff Staff { get; set; }
        [ForeignKey(nameof(TrainingId))]
        [InverseProperty(nameof(TableTraining.TableTrainingStaffs))]
        public virtual TableTraining Training { get; set; }
    }
}
