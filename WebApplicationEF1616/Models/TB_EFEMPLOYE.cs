using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace WebApplicationEF1616.Models
{
    public class TB_EFEMPLOYE
    {
        [Key]
        public int EMPID { get; set; }
        public string ENAME { get; set; }
        public string EDEPT { get; set; }
        public string QUALICATION { get; set; }
        public int SALARY { get; set; }
       
        public string JOBTYPE { get; set; }
        public int EXPERENACE { get; set; }
     
    }
}
