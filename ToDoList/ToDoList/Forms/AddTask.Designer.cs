namespace ToDoList.Forms
{
    partial class AddTask
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_Description = new System.Windows.Forms.TextBox();
            this.dateTimePicker_dateWhenFinish = new System.Windows.Forms.DateTimePicker();
            this.comboBox_Categories = new System.Windows.Forms.ComboBox();
            this.checkBox_Yes = new System.Windows.Forms.CheckBox();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Task name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Finished?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date when finish";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Description";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(141, 45);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(200, 23);
            this.textBox_name.TabIndex = 5;
            // 
            // textBox_Description
            // 
            this.textBox_Description.Location = new System.Drawing.Point(141, 90);
            this.textBox_Description.Multiline = true;
            this.textBox_Description.Name = "textBox_Description";
            this.textBox_Description.Size = new System.Drawing.Size(200, 50);
            this.textBox_Description.TabIndex = 6;
            // 
            // dateTimePicker_dateWhenFinish
            // 
            this.dateTimePicker_dateWhenFinish.Location = new System.Drawing.Point(141, 159);
            this.dateTimePicker_dateWhenFinish.Name = "dateTimePicker_dateWhenFinish";
            this.dateTimePicker_dateWhenFinish.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker_dateWhenFinish.TabIndex = 7;
            // 
            // comboBox_Categories
            // 
            this.comboBox_Categories.FormattingEnabled = true;
            this.comboBox_Categories.Location = new System.Drawing.Point(141, 203);
            this.comboBox_Categories.Name = "comboBox_Categories";
            this.comboBox_Categories.Size = new System.Drawing.Size(200, 23);
            this.comboBox_Categories.TabIndex = 8;
            // 
            // checkBox_Yes
            // 
            this.checkBox_Yes.AutoSize = true;
            this.checkBox_Yes.Location = new System.Drawing.Point(217, 247);
            this.checkBox_Yes.Name = "checkBox_Yes";
            this.checkBox_Yes.Size = new System.Drawing.Size(43, 19);
            this.checkBox_Yes.TabIndex = 9;
            this.checkBox_Yes.Text = "Yes";
            this.checkBox_Yes.UseVisualStyleBackColor = true;
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(141, 296);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(75, 23);
            this.button_Save.TabIndex = 11;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(266, 296);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.button_Cancel.TabIndex = 12;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            // 
            // AddTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 356);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Save);
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
            this.Name = "AddTask";
            this.Text = "AddTask";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox_name;
        private TextBox textBox_Description;
        private DateTimePicker dateTimePicker_dateWhenFinish;
        private ComboBox comboBox_Categories;
        private CheckBox checkBox_Yes;
        private Button button_Save;
        private Button button_Cancel;
    }
}