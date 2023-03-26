namespace ToDoList
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_addTask = new System.Windows.Forms.Button();
            this.button_editTask = new System.Windows.Forms.Button();
            this.button_taskDetail = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(90, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(600, 279);
            this.dataGridView1.TabIndex = 0;
            // 
            // button_addTask
            // 
            this.button_addTask.Location = new System.Drawing.Point(90, 353);
            this.button_addTask.Name = "button_addTask";
            this.button_addTask.Size = new System.Drawing.Size(106, 42);
            this.button_addTask.TabIndex = 1;
            this.button_addTask.Text = "Add task";
            this.button_addTask.UseVisualStyleBackColor = true;
            this.button_addTask.Click += new System.EventHandler(this.button_addTask_Click);
            // 
            // button_editTask
            // 
            this.button_editTask.Location = new System.Drawing.Point(584, 353);
            this.button_editTask.Name = "button_editTask";
            this.button_editTask.Size = new System.Drawing.Size(106, 42);
            this.button_editTask.TabIndex = 3;
            this.button_editTask.Text = "Task edit";
            this.button_editTask.UseVisualStyleBackColor = true;
            this.button_editTask.Click += new System.EventHandler(this.button_editTask_Click);
            // 
            // button_taskDetail
            // 
            this.button_taskDetail.Location = new System.Drawing.Point(347, 353);
            this.button_taskDetail.Name = "button_taskDetail";
            this.button_taskDetail.Size = new System.Drawing.Size(106, 42);
            this.button_taskDetail.TabIndex = 4;
            this.button_taskDetail.Text = "Task detail";
            this.button_taskDetail.UseVisualStyleBackColor = true;
            this.button_taskDetail.Click += new System.EventHandler(this.button_taskDetail_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_taskDetail);
            this.Controls.Add(this.button_editTask);
            this.Controls.Add(this.button_addTask);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private Button button_addTask;
        private Button button_editTask;
        private Button button_taskDetail;
    }
}