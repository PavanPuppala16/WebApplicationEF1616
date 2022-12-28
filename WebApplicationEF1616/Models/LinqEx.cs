using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
namespace WebApplicationEF1616.Models
{
    public class LinqEx
    {
        [Key]
        public int ID { get; set; }
        public int ROLLNO { get; set; }

        public string NAME { get; set; }
        public string SURNAME { get; set; }
        public DateTime AGE { get; set; }
        public string GENDER { get; set; }
        public int SALARY { get; set; }
        public int MARKS { get; set; }
        public int LUCKY { get; set; }



    }
}