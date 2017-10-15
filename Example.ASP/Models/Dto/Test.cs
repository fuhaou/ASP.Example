using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Example.ASP.Models.Dto
{
    [Table("Test")]
    public class Test
    {
        [Key]
        public int TestId { get; set; }

        [Required]
        [StringLength(255)]
        public string TestName { get; set; }

        public DateTime? TestDate { get; set; }

        public TestChild TestChild { get; set; }
    }
}