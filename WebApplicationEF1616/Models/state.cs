using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WebApplicationEF1616.Models
{
    public class state
    {
        [Key]
        [ForeignKey("country")]
        public int cid { get; set; }
        public string sname { get; set; }
        public virtual country country { get; set; }
    }
}
