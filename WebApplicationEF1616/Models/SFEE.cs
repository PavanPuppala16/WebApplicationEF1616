using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace WebApplicationEF1616.Models
{
    public class SFEE
    {
        [Key]
        [ForeignKey("student")]
        public int SID { get; set; }
        public int STUFEE { get; set; }
        public virtual STUD student { get; set; }
    }
}
