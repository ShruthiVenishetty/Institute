using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstituteRepository.Models
{
    [Table("Course")]
    public partial class Course
    {
        public Course()
        {
            Batches = new HashSet<Batch>();
           
        }
        [Key]
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public int CourseFee { get; set; }

        public virtual ICollection<Batch> Batches { get; set; }
    }
}
