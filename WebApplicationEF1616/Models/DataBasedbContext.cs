using Microsoft.EntityFrameworkCore;
namespace WebApplicationEF1616.Models
{
    public class DataBasedbContext :DbContext
    {
        public DataBasedbContext()
        {

        }
        public DataBasedbContext(DbContextOptions<DataBasedbContext> options) : base(options)
        {

        }

        public virtual DbSet<PRODUCT> PRODUCT { get; set; }

        public virtual DbSet<TB_EFSTUDENT> TB_EFSTUDENT { get; set; }
        public virtual DbSet<TB_EFEMPLOYE> TB_EFEMPLOYE { get; set; }
        public virtual DbSet<LinqEx> LINQEX { get; set; }

        public virtual DbSet<country> country { get; set; }
        public virtual DbSet<state> state { get; set; }
        public virtual DbSet<country1> country1 { get; set; }
        public virtual DbSet<state1> state1 { get; set; }
        public virtual DbSet<dist> dist { get; set; }

        public virtual DbSet<STUD> student { get; set; }
        public virtual DbSet<DEP> deptartment { get; set; }
        public virtual DbSet<SFEE> studentfee { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Bank> Bank { get; set; }






    }
}
