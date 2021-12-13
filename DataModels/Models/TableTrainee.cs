using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace DataModels.Models
{
    [Table("tableTrainee")]
    public partial class TableTrainee
    {
        public TableTrainee()
        {
            TableNewsUpdates = new HashSet<TableNewsUpdate>();
            TableTrainingTrainees = new HashSet<TableTrainingTrainee>();
        }

        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }
        [Column("GenderID")]
        public int GenderId { get; set; }
        [Required]
        [StringLength(50)]
        public string Profession { get; set; }
        [Column("RegionID")]
        public int RegionId { get; set; }
        [Required]
        [StringLength(50)]
        public string PhoneNumber { get; set; }
        [Required]
        [StringLength(50)]
        public string EmailAddress { get; set; }
        [Required]
        [StringLength(50)]
        public string Organization { get; set; }
        [Required]
        [StringLength(50)]
        public string Department { get; set; }

        [ForeignKey(nameof(GenderId))]
        [InverseProperty(nameof(TableGender.TableTrainees))]
        public virtual TableGender Gender { get; set; }
        [ForeignKey(nameof(RegionId))]
        [InverseProperty(nameof(TableRegion.TableTrainees))]
        public virtual TableRegion Region { get; set; }
        [InverseProperty(nameof(TableNewsUpdate.Trainee))]
        public virtual ICollection<TableNewsUpdate> TableNewsUpdates { get; set; }
        [InverseProperty(nameof(TableTrainingTrainee.Trainee))]
        public virtual ICollection<TableTrainingTrainee> TableTrainingTrainees { get; set; }
    }
}
