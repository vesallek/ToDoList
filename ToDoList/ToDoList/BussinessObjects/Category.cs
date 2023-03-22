using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.BussinessObjects
{
    [Table("Category")]
    public class Category
    {
        [Key]
        public int id { get; set; }
        [Column("name")]
        public string name { get; set; }
    }
}
