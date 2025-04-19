namespace Library_Book_Manager.Windows_Forms
{
    partial class View_books
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
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            button3 = new Button();
            button2 = new Button();
            checkBox1 = new CheckBox();
            Publication_Year = new TextBox();
            ISBN = new TextBox();
            Author = new TextBox();
            Title = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(377, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(625, 237);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(33, 52);
            panel1.Name = "panel1";
            panel1.Size = new Size(320, 110);
            panel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            button1.Location = new Point(86, 60);
            button1.Name = "button1";
            button1.Size = new Size(126, 28);
            button1.TabIndex = 2;
            button1.Text = "Search Books";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(149, 18);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(148, 26);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            label1.Location = new Point(13, 25);
            label1.Name = "label1";
            label1.Size = new Size(126, 19);
            label1.TabIndex = 0;
            label1.Text = "Enter Book Name";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(checkBox1);
            panel2.Controls.Add(Publication_Year);
            panel2.Controls.Add(ISBN);
            panel2.Controls.Add(Author);
            panel2.Controls.Add(Title);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            panel2.Location = new Point(304, 323);
            panel2.Name = "panel2";
            panel2.Size = new Size(698, 291);
            panel2.TabIndex = 2;
            panel2.Visible = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 128, 128);
            button3.Location = new Point(187, 218);
            button3.Name = "button3";
            button3.Size = new Size(118, 43);
            button3.TabIndex = 3;
            button3.Text = "Delete Book";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Highlight;
            button2.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            button2.Location = new Point(407, 218);
            button2.Name = "button2";
            button2.Size = new Size(91, 43);
            button2.TabIndex = 9;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            checkBox1.Location = new Point(307, 99);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(101, 23);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "IsAvailable";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // Publication_Year
            // 
            Publication_Year.Font = new Font("Segoe UI", 10F);
            Publication_Year.Location = new Point(427, 44);
            Publication_Year.Name = "Publication_Year";
            Publication_Year.Size = new Size(189, 25);
            Publication_Year.TabIndex = 7;
            // 
            // ISBN
            // 
            ISBN.Font = new Font("Segoe UI", 10F);
            ISBN.Location = new Point(103, 147);
            ISBN.Name = "ISBN";
            ISBN.Size = new Size(157, 25);
            ISBN.TabIndex = 6;
            // 
            // Author
            // 
            Author.Font = new Font("Segoe UI", 10F);
            Author.Location = new Point(103, 97);
            Author.Name = "Author";
            Author.Size = new Size(157, 25);
            Author.TabIndex = 5;
            // 
            // Title
            // 
            Title.Font = new Font("Segoe UI", 10F);
            Title.Location = new Point(103, 43);
            Title.Name = "Title";
            Title.Size = new Size(157, 25);
            Title.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            label5.Location = new Point(294, 46);
            label5.Name = "label5";
            label5.Size = new Size(114, 19);
            label5.TabIndex = 3;
            label5.Text = "PublicationYear";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            label4.Location = new Point(36, 153);
            label4.Name = "label4";
            label4.Size = new Size(41, 19);
            label4.TabIndex = 2;
            label4.Text = "ISBN";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            label3.Location = new Point(22, 97);
            label3.Name = "label3";
            label3.Size = new Size(55, 19);
            label3.TabIndex = 1;
            label3.Text = "Author";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            label2.Location = new Point(40, 46);
            label2.Name = "label2";
            label2.Size = new Size(38, 19);
            label2.TabIndex = 0;
            label2.Text = "Title";
            // 
            // View_books
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1234, 664);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Name = "View_books";
            Text = "View_books";
            WindowState = FormWindowState.Maximized;
            Load += View_books_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel1;
        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private Panel panel2;
        private CheckBox checkBox1;
        private TextBox Publication_Year;
        private TextBox ISBN;
        private TextBox Author;
        private TextBox Title;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button button2;
        private Button button3;
    }
}