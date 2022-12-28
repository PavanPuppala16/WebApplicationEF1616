using System.ComponentModel.DataAnnotations;
namespace WebApplicationEF1616.Models
{
    public class country
    {
        [Key]
        public int cid { get; set; }
        public string cname { get; set; }
        public virtual state State { get; set; }

      
    }
}
