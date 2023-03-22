using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.BussinessObjects
{
    [Table("ToDo")]
    public class ToDo
    {
        [Key]
        public int id { get; set; }
        
        [Column("name")]
        public string name { get; set; }
        
        [Column("dateWhenFinish")]
        public DateOnly dateWhenFinish { get; set; }
        
        [Column("isFinished")]
        public int isFinished { get; set; }
        
        [Column("idCategory")]
        public int idCategoryFK { get; set; }
        
        [ForeignKey("idCategoryFK")]
        public Category category { get; set; }
    }
}
