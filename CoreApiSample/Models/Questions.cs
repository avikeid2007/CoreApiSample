using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreApiSample.Models
{
    public partial class Questions
    {
        [Key]
        public Guid Id { get; set; }
        public DateTimeOffset Created { get; set; }
        [StringLength(255)]
        public string CreatedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        [StringLength(255)]
        public string ModifiedBy { get; set; }
        public bool IsActive { get; set; }
        public Guid? ClassId { get; set; }
        public Guid? SubjectId { get; set; }
        [Required]
        public string QuestionsText { get; set; }
        public string SolutionText { get; set; }
        public byte[] ImageSolution { get; set; }
        [StringLength(20)]
        public string ImageMimeType { get; set; }
        [Column("VideoSolutionURL")]
        [StringLength(500)]
        public string VideoSolutionUrl { get; set; }
        public string Tag { get; set; }
        [StringLength(50)]
        public string Writer { get; set; }
        [StringLength(50)]
        public string Book { get; set; }

        [ForeignKey(nameof(ClassId))]
        [InverseProperty(nameof(Classes.Questions))]
        public virtual Classes Class { get; set; }
        [ForeignKey(nameof(SubjectId))]
        [InverseProperty(nameof(Subjects.Questions))]
        public virtual Subjects Subject { get; set; }
    }
}
