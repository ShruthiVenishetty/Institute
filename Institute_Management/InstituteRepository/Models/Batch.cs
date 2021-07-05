using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstituteRepository.Models
{
    [Table("Batch")]
    public partial class Batch
    {
            public Batch()
            {
                Students = new HashSet<Student>();
                Courses = new HashSet<Course>();
            }
        [Key]
        public int BatchId { get; set; }
        public string BatchName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
