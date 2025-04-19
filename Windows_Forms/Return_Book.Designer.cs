namespace Library_Book_Manager.Windows_Forms
{
    partial class Return_Book
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
            panel1 = new Panel();
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            panel3 = new Panel();
            lib_borrowdate = new Label();
            lib_bookname = new Label();
            dateTimePicker1 = new DateTimePicker();
            button2 = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(49, 42);
            panel1.Name = "panel1";
            panel1.Size = new Size(309, 168);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 192, 255);
            button1.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            button1.Location = new Point(79, 101);
            button1.Name = "button1";
            button1.Size = new Size(131, 37);
            button1.TabIndex = 2;
            button1.Text = "Search Book";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(90, 15);
            label1.Name = "label1";
            label1.Size = new Size(97, 21);
            label1.TabIndex = 1;
            label1.Text = "Enter Email";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(34, 50);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(233, 26);
            textBox1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(429, 42);
            panel2.Name = "panel2";
            panel2.Size = new Size(621, 281);
            panel2.TabIndex = 1;
            panel2.Visible = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(28, 15);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(560, 243);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(lib_borrowdate);
            panel3.Controls.Add(lib_bookname);
            panel3.Controls.Add(dateTimePicker1);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(145, 350);
            panel3.Name = "panel3";
            panel3.Size = new Size(788, 247);
            panel3.TabIndex = 2;
            panel3.Visible = false;
            // 
            // lib_borrowdate
            // 
            lib_borrowdate.AutoSize = true;
            lib_borrowdate.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lib_borrowdate.Location = new Point(482, 42);
            lib_borrowdate.Name = "lib_borrowdate";
            lib_borrowdate.Size = new Size(0, 21);
            lib_borrowdate.TabIndex = 6;
            // 
            // lib_bookname
            // 
            lib_bookname.AutoSize = true;
            lib_bookname.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lib_bookname.Location = new Point(169, 35);
            lib_bookname.Name = "lib_bookname";
            lib_bookname.Size = new Size(0, 21);
            lib_bookname.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(234, 123);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 26);
            dateTimePicker1.TabIndex = 4;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button2.Location = new Point(295, 194);
            button2.Name = "button2";
            button2.Size = new Size(148, 39);
            button2.TabIndex = 3;
            button2.Text = "Return Book";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(56, 123);
            label4.Name = "label4";
            label4.Size = new Size(151, 21);
            label4.TabIndex = 2;
            label4.Text = "Select Return Date";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(364, 42);
            label3.Name = "label3";
            label3.Size = new Size(105, 21);
            label3.TabIndex = 1;
            label3.Text = "Borrow Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(56, 35);
            label2.Name = "label2";
            label2.Size = new Size(99, 21);
            label2.TabIndex = 0;
            label2.Text = "Book Name";
            // 
            // Return_Book
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1208, 626);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Return_Book";
            Text = "Return_Book";
            WindowState = FormWindowState.Maximized;
            Load += Return_Book_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Panel panel3;
        private Label lib_borrowdate;
        private Label lib_bookname;
        private DateTimePicker dateTimePicker1;
        private Button button2;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}