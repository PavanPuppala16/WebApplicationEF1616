using System.ComponentModel.DataAnnotations;
namespace WebApplicationEF1616.Models
{
    public class Bank
    {
        [Key]
        public int BankID { get; set; }

        public String BankName { get; set; }
        public String Branch { get; set; }
    }
}
