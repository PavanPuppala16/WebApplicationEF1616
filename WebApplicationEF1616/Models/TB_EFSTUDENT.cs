using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
namespace WebApplicationEF1616.Models
{
    public class TB_EFSTUDENT
    {
        [Key]
        public int ROLLNO { get; set; }
        public string NAME { get; set; }
        public DateTime DOB { get; set; }
        public string FATHERNAME { get; set; }
        public string COLLEGE { get; set; }
        public int FEE { get; set; }
        public string BRANCH { get; set; }
        public DateTime YEAR { get; set; }
    }
}
