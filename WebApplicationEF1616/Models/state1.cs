using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WebApplicationEF1616.Models
{
    public class state1
    {

        [Key]
        [ForeignKey("country1")]
        public int cid { get; set; }
        
        public string sname { get; set; }
        public virtual country1 country1 { get; set; }

    }
}
