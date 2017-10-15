using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Example.ASP.Libraries.DbTable
{
    [Table("TestChild")]
    public class TestChild
    {
        [Key]
        public int TestChildId { get; set; }

        [Required]
        [StringLength(255)]
        public string TestChildName { get; set; }

        public DateTime? TestChildDate { get; set; }
    }
}