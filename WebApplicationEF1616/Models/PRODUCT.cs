using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationEF1616.Models
{
    public class PRODUCT
    {
        [Key]
        public int PID { get; set; }
        public string PNAME { get; set; }
        public string DESCREPTION { get; set; }
        public DateTime EXPAIRYDATE { get; set; }
        public decimal PRICE { get; set; }

    }
}
