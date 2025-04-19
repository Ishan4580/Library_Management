
namespace Library_Book_Manager
{
    partial class mdi_user
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
            components = new System.ComponentModel.Container();
            menuStrip = new MenuStrip();
            booksToolStripMenuItem = new ToolStripMenuItem();
            addNewBooksToolStripMenuItem = new ToolStripMenuItem();
            viewBooksToolStripMenuItem = new ToolStripMenuItem();
            borrowBooksToolStripMenuItem = new ToolStripMenuItem();
            returnBooksToolStripMenuItem = new ToolStripMenuItem();
            bookStockToolStripMenuItem = new ToolStripMenuItem();
            viewBookBorrowingToolStripMenuItem = new ToolStripMenuItem();
            membersToolStripMenuItem = new ToolStripMenuItem();
            addNewMembersToolStripMenuItem = new ToolStripMenuItem();
            viewMembersToolStripMenuItem = new ToolStripMenuItem();
            statusStrip = new StatusStrip();
            toolStripStatusLabel = new ToolStripStatusLabel();
            toolTip = new ToolTip(components);
            addNewMembersToolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip.SuspendLayout();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { booksToolStripMenuItem, membersToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(8, 3, 0, 3);
            menuStrip.Size = new Size(843, 29);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "MenuStrip";
            // 
            // booksToolStripMenuItem
            // 
            booksToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addNewBooksToolStripMenuItem, viewBooksToolStripMenuItem, borrowBooksToolStripMenuItem, returnBooksToolStripMenuItem, bookStockToolStripMenuItem, viewBookBorrowingToolStripMenuItem });
            booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            booksToolStripMenuItem.Size = new Size(58, 23);
            booksToolStripMenuItem.Text = "Books";
            // 
            // addNewBooksToolStripMenuItem
            // 
            addNewBooksToolStripMenuItem.Name = "addNewBooksToolStripMenuItem";
            addNewBooksToolStripMenuItem.Size = new Size(209, 24);
            addNewBooksToolStripMenuItem.Text = "Add New Books";
            addNewBooksToolStripMenuItem.Click += addNewBooksToolStripMenuItem_Click;
            // 
            // viewBooksToolStripMenuItem
            // 
            viewBooksToolStripMenuItem.Name = "viewBooksToolStripMenuItem";
            viewBooksToolStripMenuItem.Size = new Size(209, 24);
            viewBooksToolStripMenuItem.Text = "View Books";
            viewBooksToolStripMenuItem.Click += viewBooksToolStripMenuItem_Click;
            // 
            // borrowBooksToolStripMenuItem
            // 
            borrowBooksToolStripMenuItem.Name = "borrowBooksToolStripMenuItem";
            borrowBooksToolStripMenuItem.Size = new Size(209, 24);
            borrowBooksToolStripMenuItem.Text = "Borrow Books";
            borrowBooksToolStripMenuItem.Click += borrowBooksToolStripMenuItem_Click;
            // 
            // returnBooksToolStripMenuItem
            // 
            returnBooksToolStripMenuItem.Name = "returnBooksToolStripMenuItem";
            returnBooksToolStripMenuItem.Size = new Size(209, 24);
            returnBooksToolStripMenuItem.Text = "Return Books";
            returnBooksToolStripMenuItem.Click += returnBooksToolStripMenuItem_Click;
            // 
            // bookStockToolStripMenuItem
            // 
            bookStockToolStripMenuItem.Name = "bookStockToolStripMenuItem";
            bookStockToolStripMenuItem.Size = new Size(209, 24);
            bookStockToolStripMenuItem.Text = "Book Stock";
            bookStockToolStripMenuItem.Click += bookStockToolStripMenuItem_Click;
            // 
            // viewBookBorrowingToolStripMenuItem
            // 
            viewBookBorrowingToolStripMenuItem.Name = "viewBookBorrowingToolStripMenuItem";
            viewBookBorrowingToolStripMenuItem.Size = new Size(209, 24);
            viewBookBorrowingToolStripMenuItem.Text = "View Book Borrowing";
            viewBookBorrowingToolStripMenuItem.Click += viewBookBorrowingToolStripMenuItem_Click;
            // 
            // membersToolStripMenuItem
            // 
            membersToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addNewMembersToolStripMenuItem, viewMembersToolStripMenuItem });
            membersToolStripMenuItem.Name = "membersToolStripMenuItem";
            membersToolStripMenuItem.Size = new Size(79, 23);
            membersToolStripMenuItem.Text = "Members";
            // 
            // addNewMembersToolStripMenuItem
            // 
            addNewMembersToolStripMenuItem.Name = "addNewMembersToolStripMenuItem";
            addNewMembersToolStripMenuItem.Size = new Size(190, 24);
            addNewMembersToolStripMenuItem.Text = "Add New Member";
            addNewMembersToolStripMenuItem.Click += addNewMembersToolStripMenuItem_Click_1;
            // 
            // viewMembersToolStripMenuItem
            // 
            viewMembersToolStripMenuItem.Name = "viewMembersToolStripMenuItem";
            viewMembersToolStripMenuItem.Size = new Size(190, 24);
            viewMembersToolStripMenuItem.Text = "View Members";
            viewMembersToolStripMenuItem.Click += viewMembersToolStripMenuItem_Click;
            // 
            // statusStrip
            // 
            statusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel });
            statusStrip.Location = new Point(0, 638);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new Padding(1, 0, 19, 0);
            statusStrip.Size = new Size(843, 24);
            statusStrip.TabIndex = 2;
            statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            toolStripStatusLabel.Name = "toolStripStatusLabel";
            toolStripStatusLabel.Size = new Size(47, 19);
            toolStripStatusLabel.Text = "Status";
            // 
            // addNewMembersToolStripMenuItem1
            // 
            addNewMembersToolStripMenuItem1.Name = "addNewMembersToolStripMenuItem1";
            addNewMembersToolStripMenuItem1.Size = new Size(196, 24);
            addNewMembersToolStripMenuItem1.Text = "Add New Members";
            // 
            // mdi_user
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(843, 662);
            Controls.Add(statusStrip);
            Controls.Add(menuStrip);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip;
            Margin = new Padding(4);
            Name = "mdi_user";
            Text = "mdi_user";
            WindowState = FormWindowState.Maximized;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }


        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private ToolStripMenuItem booksToolStripMenuItem;
        private ToolStripMenuItem addNewBooksToolStripMenuItem;
        private ToolStripMenuItem viewBooksToolStripMenuItem;
        private ToolStripMenuItem membersToolStripMenuItem;
        private ToolStripMenuItem addNewMembersToolStripMenuItem;
        private ToolStripMenuItem addNewMembersToolStripMenuItem1;
        private ToolStripMenuItem viewMembersToolStripMenuItem;
        private ToolStripMenuItem borrowBooksToolStripMenuItem;
        private ToolStripMenuItem returnBooksToolStripMenuItem;
        private ToolStripMenuItem bookStockToolStripMenuItem;
        private ToolStripMenuItem viewBookBorrowingToolStripMenuItem;
    }
}



