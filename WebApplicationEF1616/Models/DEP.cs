﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace WebApplicationEF1616.Models
{
    public class DEP
    {
        [Key]
        [ForeignKey("student")]
        public int SID { get; set; }
        public String DEPNAME { get; set; } 
        public int DEPNO { get; set; }
        public virtual STUD student { get; set; }
    }
}
