using System.ComponentModel.DataAnnotations;
namespace WebApplicationEF1616.Models
{
    public class country1
    {
        [Key]
        public int cid { get; set; }
        public string cname { get; set; }
        public virtual state1 state1 { get; set; }
        public virtual dist dist { get; set; }

    }
}
