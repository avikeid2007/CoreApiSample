using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreApiSample.Models
{
    public partial class Classes
    {
        public Classes()
        {
            Questions = new HashSet<Questions>();
        }

        [Key]
        public Guid Id { get; set; }
        public DateTimeOffset Created { get; set; }
        [StringLength(255)]
        public string CreatedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        [StringLength(255)]
        public string ModifiedBy { get; set; }
        public bool IsActive { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [StringLength(50)]
        public string Abbrasive { get; set; }

        [InverseProperty("Class")]
        public virtual ICollection<Questions> Questions { get; set; }
    }
}
