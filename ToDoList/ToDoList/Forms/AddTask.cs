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
using ToDoList.ORM;

namespace ToDoList.Forms
{
    public partial class AddTask : Form
    {
        MyContext context = new MyContext();

        public ToDo Todo { get; set; }
        public Category Category { get; set; }

        public AddTask(ToDo todo)
        {
            InitializeComponent();

            this.Todo = todo;

            this.textBox_name.Text = todo.name;
            this.textBox_Description.Text = todo.description;
            this.checkBox_Yes.Checked = todo.isFinished;

            this.comboBox_Categories.DataSource = this.context.Category.ToList();

            Category selectedCategory = this.context.Category.Find(todo.idCategoryFK);
            this.comboBox_Categories.SelectedItem = selectedCategory;
            
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            this.Todo.name = this.textBox_name.Text;
            this.Todo.description = this.textBox_Description.Text;
            this.Todo.dateWhenFinish = this.dateTimePicker_dateWhenFinish.Value;
            this.Todo.isFinished = this.checkBox_Yes.Checked;

            this.Todo.idCategoryFK = (this.comboBox_Categories.Items[this.comboBox_Categories.SelectedIndex] as Category).id;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
