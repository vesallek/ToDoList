using ToDoList.BussinessObjects;
using ToDoList.DataModels;
using ToDoList.Forms;

namespace ToDoList
{
    public partial class Form1 : Form
    {
        public CategoryDataModel categoryModel { get; set; } = new CategoryDataModel();
        public ToDoDataModel todoModel { get; set; } = new ToDoDataModel();
        public ToDo Todo { get; set; }
        public Category Category { get; set; }
        
        public Form1()
        {
            InitializeComponent();

            this.dataGridView1.DataSource = this.todoModel;

            this.dataGridView1.Columns["idCategoryFK"].Visible = false;
            this.dataGridView1.Columns["description"].Visible = false;
        }

        private void button_addTask_Click(object sender, EventArgs e)
        {
            AddTask adt = new AddTask(new ToDo());
            if (adt.ShowDialog() == DialogResult.OK)
            {
                this.todoModel.AddToDo(adt.Todo);
            }
            
        }

        private void button_editTask_Click(object sender, EventArgs e)
        {
            int index = this.dataGridView1.CurrentRow.Index;

            AddTask atd = new AddTask(this.todoModel.Get(index) as ToDo);
            if (atd.ShowDialog() == DialogResult.OK)
            {
                this.todoModel.Update(atd.Todo, index);
            }
        }

        private void button_taskDetail_Click(object sender, EventArgs e)
        {
            int index = this.dataGridView1.CurrentRow.Index;
            TaskDetail tdd = new TaskDetail(this.todoModel.Get(index) as ToDo, true);
            tdd.Show();
        }
    }
}