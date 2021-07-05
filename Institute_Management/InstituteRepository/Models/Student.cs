using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstituteRepository.Models
{
    [Table("Student")]
    public partial class Student
    {
        [Key]
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int PhoneNum { get; set; }
        public string Address { get; set; }
        [ForeignKey("Job")]
        public int BatchId { get; set; }
        
        public virtual Batch Batch { get; set; }
    }
}
