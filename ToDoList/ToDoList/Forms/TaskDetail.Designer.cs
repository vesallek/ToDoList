namespace ToDoList.Forms
{
    partial class TaskDetail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_Close = new System.Windows.Forms.Button();
            this.checkBox_Yes = new System.Windows.Forms.CheckBox();
            this.comboBox_Categories = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_dateWhenFinish = new System.Windows.Forms.DateTimePicker();
            this.textBox_Description = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Categories = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Close
            // 
            this.button_Close.Location = new System.Drawing.Point(130, 319);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(75, 23);
            this.button_Close.TabIndex = 23;
            this.button_Close.Text = "Close";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // checkBox_Yes
            // 
            this.checkBox_Yes.AutoSize = true;
            this.checkBox_Yes.Location = new System.Drawing.Point(237, 252);
            this.checkBox_Yes.Name = "checkBox_Yes";
            this.checkBox_Yes.Size = new System.Drawing.Size(43, 19);
            this.checkBox_Yes.TabIndex = 22;
            this.checkBox_Yes.Text = "Yes";
            this.checkBox_Yes.UseVisualStyleBackColor = true;
            // 
            // comboBox_Categories
            // 
            this.comboBox_Categories.FormattingEnabled = true;
            this.comboBox_Categories.Location = new System.Drawing.Point(161, 208);
            this.comboBox_Categories.Name = "comboBox_Categories";
            this.comboBox_Categories.Size = new System.Drawing.Size(200, 23);
            this.comboBox_Categories.TabIndex = 21;
            // 
            // dateTimePicker_dateWhenFinish
            // 
            this.dateTimePicker_dateWhenFinish.Location = new System.Drawing.Point(161, 164);
            this.dateTimePicker_dateWhenFinish.Name = "dateTimePicker_dateWhenFinish";
            this.dateTimePicker_dateWhenFinish.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker_dateWhenFinish.TabIndex = 20;
            // 
            // textBox_Description
            // 
            this.textBox_Description.Location = new System.Drawing.Point(161, 95);
            this.textBox_Description.Multiline = true;
            this.textBox_Description.Name = "textBox_Description";
            this.textBox_Description.Size = new System.Drawing.Size(200, 50);
            this.textBox_Description.TabIndex = 19;
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(161, 50);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(200, 23);
            this.textBox_name.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "Date when finish";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Finished?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Task name";
            // 
            // button_Categories
            // 
            this.button_Categories.Location = new System.Drawing.Point(312, 319);
            this.button_Categories.Name = "button_Categories";
            this.button_Categories.Size = new System.Drawing.Size(75, 23);
            this.button_Categories.TabIndex = 24;
            this.button_Categories.Text = "Categories";
            this.button_Categories.UseVisualStyleBackColor = true;
            this.button_Categories.Click += new System.EventHandler(this.button_Categories_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(222, 319);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(75, 23);
            this.button_Delete.TabIndex = 25;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // TaskDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 386);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Categories);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.checkBox_Yes);
            this.Controls.Add(this.comboBox_Categories);
            this.Controls.Add(this.dateTimePicker_dateWhenFinish);
            this.Controls.Add(this.textBox_Description);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TaskDetail";
            this.Text = "TaskDetail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button_Close;
        private CheckBox checkBox_Yes;
        private ComboBox comboBox_Categories;
        private DateTimePicker dateTimePicker_dateWhenFinish;
        private TextBox textBox_Description;
        private TextBox textBox_name;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button_Categories;
        private Button button_Delete;
    }
}