using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoList.BussinessObjects;
using ToDoList.DataModels;
using ToDoList.ORM;

namespace ToDoList.Forms
{
    public partial class TaskDetail : Form
    {
        MyContext context = new MyContext();
        public ToDo Todo { get; set; }
        public Category Category { get; set; }

        public ToDoDataModel todoModel { get; set; } = new ToDoDataModel();
        public TaskDetail(ToDo todo, bool ReadOnly)
        {
            InitializeComponent();

            this.Todo = todo;
            if (ReadOnly)
            {
                this.textBox_name.Enabled = false;
                this.textBox_Description.Enabled = false;
                this.dateTimePicker_dateWhenFinish.Enabled = false;
                this.checkBox_Yes.Enabled = false;
                this.comboBox_Categories.Enabled = false;
            }

            this.textBox_name.Text = this.Todo.name;
            this.textBox_Description.Text = this.Todo.description;
            this.dateTimePicker_dateWhenFinish.Value = this.Todo.dateWhenFinish;

            this.comboBox_Categories.DataSource = this.context.Category.ToList();

            Category selectedCategory = this.context.Category.Find(todo.idCategoryFK);
            this.comboBox_Categories.SelectedItem = selectedCategory;
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button_Categories_Click(object sender, EventArgs e)
        {

        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            
        }
    }
}
