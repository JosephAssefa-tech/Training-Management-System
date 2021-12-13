using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace DataModels.Models
{
    [Table("tableStaff")]
    public partial class TableStaff
    {
        public TableStaff()
        {
            TableTrainingStaffs = new HashSet<TableTrainingStaff>();
        }

        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Fullname { get; set; }
        [Column("GenderID")]
        public int GenderId { get; set; }
        [Required]
        [StringLength(50)]
        public string PhoneNumber { get; set; }
        [Required]
        [StringLength(50)]
        public string EmailAddress { get; set; }
        [Column("PositionID")]
        public int PositionId { get; set; }
        [Column("AcademicLevelID")]
        public int AcademicLevelId { get; set; }
        [StringLength(50)]
        public string Username { get; set; }
        [StringLength(50)]
        public string Password { get; set; }

        [ForeignKey(nameof(AcademicLevelId))]
        [InverseProperty(nameof(TableAcademicLevel.TableStaffs))]
        public virtual TableAcademicLevel AcademicLevel { get; set; }
        [ForeignKey(nameof(GenderId))]
        [InverseProperty(nameof(TableGender.TableStaffs))]
        public virtual TableGender Gender { get; set; }
        [ForeignKey(nameof(PositionId))]
        [InverseProperty(nameof(TablePosition.TableStaffs))]
        public virtual TablePosition Position { get; set; }
        [InverseProperty(nameof(TableTrainingStaff.Staff))]
        public virtual ICollection<TableTrainingStaff> TableTrainingStaffs { get; set; }
    }
}
