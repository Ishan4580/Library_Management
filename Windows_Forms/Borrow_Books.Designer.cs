namespace Library_Book_Manager.Windows_Forms
{
    partial class Borrow_Books
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
            listBox1 = new ListBox();
            txt_bookname = new TextBox();
            label6 = new Label();
            txt_name = new TextBox();
            label5 = new Label();
            button2 = new Button();
            txt_email = new TextBox();
            button1 = new Button();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            txt_memberid = new TextBox();
            txt_bookid = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(listBox1);
            panel1.Controls.Add(txt_bookname);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txt_name);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(txt_email);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(dateTimePicker2);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(txt_memberid);
            panel1.Controls.Add(txt_bookid);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(77, 48);
            panel1.Name = "panel1";
            panel1.Size = new Size(849, 481);
            panel1.TabIndex = 0;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(539, 389);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(238, 61);
            listBox1.TabIndex = 15;
            listBox1.Visible = false;
            listBox1.MouseClick += listBox1_MouseClick;
            listBox1.KeyDown += listBox1_KeyDown;
            // 
            // txt_bookname
            // 
            txt_bookname.Location = new Point(539, 357);
            txt_bookname.Name = "txt_bookname";
            txt_bookname.Size = new Size(238, 26);
            txt_bookname.TabIndex = 14;
            txt_bookname.KeyDown += txt_bookname_KeyDown;
            txt_bookname.KeyUp += txt_Title_KeyUp;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.Location = new Point(377, 351);
            label6.Name = "label6";
            label6.Size = new Size(87, 21);
            label6.TabIndex = 13;
            label6.Text = "Book Title";
            // 
            // txt_name
            // 
            txt_name.Location = new Point(535, 84);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(240, 26);
            txt_name.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(339, 89);
            label5.Name = "label5";
            label5.Size = new Size(124, 21);
            label5.TabIndex = 11;
            label5.Text = "Member Name";
            // 
            // button2
            // 
            button2.Location = new Point(75, 106);
            button2.Name = "button2";
            button2.Size = new Size(138, 23);
            button2.TabIndex = 10;
            button2.Text = "Search Email";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txt_email
            // 
            txt_email.Location = new Point(52, 58);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(200, 26);
            txt_email.TabIndex = 9;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 255, 128);
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.Location = new Point(169, 412);
            button1.Name = "button1";
            button1.Size = new Size(136, 48);
            button1.TabIndex = 8;
            button1.Text = "Borrow Book";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(539, 299);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(238, 26);
            dateTimePicker2.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(539, 246);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(236, 26);
            dateTimePicker1.TabIndex = 6;
            // 
            // txt_memberid
            // 
            txt_memberid.Location = new Point(539, 190);
            txt_memberid.Name = "txt_memberid";
            txt_memberid.Size = new Size(236, 26);
            txt_memberid.TabIndex = 5;
            // 
            // txt_bookid
            // 
            txt_bookid.Location = new Point(537, 136);
            txt_bookid.Name = "txt_bookid";
            txt_bookid.Size = new Size(238, 26);
            txt_bookid.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(362, 304);
            label4.Name = "label4";
            label4.Size = new Size(101, 21);
            label4.TabIndex = 3;
            label4.Text = "ReturnDate ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(362, 251);
            label3.Name = "label3";
            label3.Size = new Size(105, 21);
            label3.TabIndex = 2;
            label3.Text = "BorrowDate ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(368, 191);
            label2.Name = "label2";
            label2.Size = new Size(95, 21);
            label2.TabIndex = 1;
            label2.Text = "Member ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(393, 136);
            label1.Name = "label1";
            label1.Size = new Size(70, 21);
            label1.TabIndex = 0;
            label1.Text = "Book ID";
            // 
            // Borrow_Books
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1018, 590);
            Controls.Add(panel1);
            Name = "Borrow_Books";
            Text = "Borrow_Books";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private TextBox txt_memberid;
        private TextBox txt_bookid;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button2;
        private TextBox txt_email;
        private TextBox txt_name;
        private Label label5;
        private ListBox listBox1;
        private TextBox txt_bookname;
        private Label label6;
    }
}