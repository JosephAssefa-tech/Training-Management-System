using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace DataModels.Models
{
    [Table("tableTraining")]
    public partial class TableTraining
    {
        public TableTraining()
        {
            TableTrainingStaffs = new HashSet<TableTrainingStaff>();
            TableTrainingTrainees = new HashSet<TableTrainingTrainee>();
        }

        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Column("TrainingTypeID")]
        public int TrainingTypeId { get; set; }
        [Required]
        [StringLength(50)]
        public string Fund { get; set; }
        [Required]
        [StringLength(50)]
        public string TargetAudience { get; set; }
        [Column(TypeName = "date")]
        public DateTime StartDate { get; set; }
        [Column(TypeName = "date")]
        public DateTime EndDate { get; set; }
        [StringLength(50)]
        public string VerificationCode { get; set; }
        [Required]
        [StringLength(50)]
        public string Status { get; set; }

        [ForeignKey(nameof(TrainingTypeId))]
        [InverseProperty(nameof(TableTrainingType.TableTrainings))]
        public virtual TableTrainingType TrainingType { get; set; }
        [InverseProperty(nameof(TableTrainingStaff.Training))]
        public virtual ICollection<TableTrainingStaff> TableTrainingStaffs { get; set; }
        [InverseProperty(nameof(TableTrainingTrainee.Training))]
        public virtual ICollection<TableTrainingTrainee> TableTrainingTrainees { get; set; }
    }
}
