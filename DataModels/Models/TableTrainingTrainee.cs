using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace DataModels.Models
{
    [Table("tableTrainingTrainee")]
    public partial class TableTrainingTrainee
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("TrainingID")]
        public int TrainingId { get; set; }
        [Column("TraineeID")]
        public int TraineeId { get; set; }
        [Column(TypeName = "date")]
        public DateTime RegistrationDate { get; set; }

        [ForeignKey(nameof(TraineeId))]
        [InverseProperty(nameof(TableTrainee.TableTrainingTrainees))]
        public virtual TableTrainee Trainee { get; set; }
        [ForeignKey(nameof(TrainingId))]
        [InverseProperty(nameof(TableTraining.TableTrainingTrainees))]
        public virtual TableTraining Training { get; set; }
    }
}
