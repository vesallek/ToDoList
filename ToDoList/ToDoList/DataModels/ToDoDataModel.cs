using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.BussinessObjects;
using ToDoList.ORM;

namespace ToDoList.DataModels
{
    public class ToDoDataModel : IListSource
    {
        MyContext context = new MyContext();

        public List<ToDo> toDo = null;

        public BindingList<ToDo> data { get; set; } = new BindingList<ToDo>();

        public bool ContainsListCollection => true;

        public ToDoDataModel()
        {
            this.toDo = this.context.ToDo.ToList();

            foreach(ToDo todo in this.toDo)
            {
                this.data.Add(todo);
            }
        }

        public IList GetList()
        {
            return this.data;
        }

        public void AddToDo(ToDo todo)
        {
            this.data.Add(todo);
            this.context.ToDo.Add(todo);
            this.context.SaveChanges();
        }

        public void RemoveAt(int index)
        {
            this.context.Remove(data[index]);
            this.context.SaveChanges();
            this.data.RemoveAt(index);
        }

        public void Update(ToDo todo, int index)
        {
            this.data[index] = todo;
            this.context.SaveChanges();
        }

        public ToDo Get(int index)
        {
            return this.data[index];
        }

        public ToDo GetId(int id)
        {
            this.toDo = this.context.ToDo.ToList();
            foreach(ToDo todo in this.toDo)
            {
                if (todo.id == id)
                {
                    return todo;
                }
                
            }
            return null;
        }

    }
}
