using System.ComponentModel.DataAnnotations;
namespace WebApplicationEF1616.Models
{
    public class Employee
    {

        [Key]
        public int EID { get; set; }
        public String EName { get; set; }
        public int Salary { get; set; }
        public int BankID { get; set; }
        public Bank Bank { get; set; }
    }
}
