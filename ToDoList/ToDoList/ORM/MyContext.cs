using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.BussinessObjects;

namespace ToDoList.ORM
{
    public class MyContext : DbContext
    {
        public DbSet<ToDo> ToDo { get; set; }

        public DbSet<Category> Category { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=mysqlstudenti.litv.sssvt.cz;database=4a1_veselykrystof_db2;user=veselykrystof;password=123456;SslMode=none");
            optionsBuilder.UseLazyLoadingProxies();
        }
    }
}
