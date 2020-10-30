namespace WindowsFormsApp13
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addClientsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.savingsAccoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loanAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addChangeOrTerminationOfStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientsToolStripMenuItem,
            this.staffToolStripMenuItem,
            this.logOffToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1401, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clientsToolStripMenuItem
            // 
            this.clientsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addClientsToolStripMenuItem,
            this.addClientsToolStripMenuItem1});
            this.clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            this.clientsToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.clientsToolStripMenuItem.Text = "Clients";
            // 
            // staffToolStripMenuItem
            // 
            this.staffToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addChangeOrTerminationOfStaffToolStripMenuItem});
            this.staffToolStripMenuItem.Name = "staffToolStripMenuItem";
            this.staffToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.staffToolStripMenuItem.Text = "Staff";
            // 
            // logOffToolStripMenuItem
            // 
            this.logOffToolStripMenuItem.Name = "logOffToolStripMenuItem";
            this.logOffToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.logOffToolStripMenuItem.Text = "Reporting";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.logOutToolStripMenuItem.Text = "Log out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // addClientsToolStripMenuItem
            // 
            this.addClientsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.savingsAccoutToolStripMenuItem,
            this.loanAccountToolStripMenuItem,
            this.transactionToolStripMenuItem});
            this.addClientsToolStripMenuItem.Name = "addClientsToolStripMenuItem";
            this.addClientsToolStripMenuItem.Size = new System.Drawing.Size(305, 26);
            this.addClientsToolStripMenuItem.Text = "Accounts";
            // 
            // addClientsToolStripMenuItem1
            // 
            this.addClientsToolStripMenuItem1.Name = "addClientsToolStripMenuItem1";
            this.addClientsToolStripMenuItem1.Size = new System.Drawing.Size(305, 26);
            this.addClientsToolStripMenuItem1.Text = "Add change or deletion of clients";
            this.addClientsToolStripMenuItem1.Visible = false;
            this.addClientsToolStripMenuItem1.Click += new System.EventHandler(this.addClientsToolStripMenuItem1_Click);
            // 
            // savingsAccoutToolStripMenuItem
            // 
            this.savingsAccoutToolStripMenuItem.Name = "savingsAccoutToolStripMenuItem";
            this.savingsAccoutToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.savingsAccoutToolStripMenuItem.Text = "Savings Accout";
            this.savingsAccoutToolStripMenuItem.Click += new System.EventHandler(this.savingsAccoutToolStripMenuItem_Click);
            // 
            // loanAccountToolStripMenuItem
            // 
            this.loanAccountToolStripMenuItem.Name = "loanAccountToolStripMenuItem";
            this.loanAccountToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.loanAccountToolStripMenuItem.Text = "Loan Account";
            this.loanAccountToolStripMenuItem.Click += new System.EventHandler(this.loanAccountToolStripMenuItem_Click);
            // 
            // transactionToolStripMenuItem
            // 
            this.transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
            this.transactionToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.transactionToolStripMenuItem.Text = "Transaction";
            this.transactionToolStripMenuItem.Click += new System.EventHandler(this.transactionToolStripMenuItem_Click);
            // 
            // addChangeOrTerminationOfStaffToolStripMenuItem
            // 
            this.addChangeOrTerminationOfStaffToolStripMenuItem.Name = "addChangeOrTerminationOfStaffToolStripMenuItem";
            this.addChangeOrTerminationOfStaffToolStripMenuItem.Size = new System.Drawing.Size(316, 26);
            this.addChangeOrTerminationOfStaffToolStripMenuItem.Text = "Add Change or termination of staff";
            this.addChangeOrTerminationOfStaffToolStripMenuItem.Click += new System.EventHandler(this.addChangeOrTerminationOfStaffToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1401, 738);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addClientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem savingsAccoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loanAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addClientsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem staffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addChangeOrTerminationOfStaffToolStripMenuItem;
    }
}

