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
    public class CategoryDataModel : IListSource
    {
        MyContext context = new MyContext();

        public List<Category> category = null;
        private BindingList<Category> data { get; set; } = new BindingList<Category>();
        public bool ContainsListCollection => true;

        public CategoryDataModel()
        {
            this.category = this.context.Category.ToList();

            foreach (Category category in this.category)
            {
                this.data.Add(category);
            }
        }

        public IList GetList()
        {
            return this.data;
        }

        public void Add(Category category)
        {
            this.data.Add(category);
            this.context.Add(category);
            this.context.SaveChanges();
        }

        public void RemoveAt(int index)
        {
            this.context.Remove(this.data[index]);
            this.context.SaveChanges();
            this.data.RemoveAt(index);
        }

        public void Update(Category category, int index)
        {
            this.data[index] = category;
            this.context.SaveChanges();
        }

        public Category Get(int index)
        {
            return this.data[index];
        }

        public Category GetId(int id)
        {
            this.category = this.context.Category.ToList();
            foreach (Category category in this.category)
            {
                if (category.id == id)
                {
                    return category;
                }
            }
            return null;
        }
    }
}
