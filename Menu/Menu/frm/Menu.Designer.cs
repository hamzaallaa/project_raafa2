namespace Menu
{
    partial class Menu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.الموضفونToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تسجيلالموظفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.المستفيدينToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تسجيلمستفيدةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1023, 39);
            this.panel1.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.الموضفونToolStripMenuItem,
            this.المستفيدينToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1023, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // الموضفونToolStripMenuItem
            // 
            this.الموضفونToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.تسجيلالموظفToolStripMenuItem});
            this.الموضفونToolStripMenuItem.Name = "الموضفونToolStripMenuItem";
            this.الموضفونToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.الموضفونToolStripMenuItem.Text = "الموظفون";
            // 
            // تسجيلالموظفToolStripMenuItem
            // 
            this.تسجيلالموظفToolStripMenuItem.Name = "تسجيلالموظفToolStripMenuItem";
            this.تسجيلالموظفToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.تسجيلالموظفToolStripMenuItem.Text = "تسجيل الموظف";
            // 
            // المستفيدينToolStripMenuItem
            // 
            this.المستفيدينToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.تسجيلمستفيدةToolStripMenuItem});
            this.المستفيدينToolStripMenuItem.Name = "المستفيدينToolStripMenuItem";
            this.المستفيدينToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.المستفيدينToolStripMenuItem.Text = "المستفيدين";
            // 
            // تسجيلمستفيدةToolStripMenuItem
            // 
            this.تسجيلمستفيدةToolStripMenuItem.Name = "تسجيلمستفيدةToolStripMenuItem";
            this.تسجيلمستفيدةToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.تسجيلمستفيدةToolStripMenuItem.Text = "تسجيل مستفيد(ة)";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1009, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(16, 471);
            this.panel2.TabIndex = 2;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 471);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Menu";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ادارة الموظفين :";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem الموضفونToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem تسجيلالموظفToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem المستفيدينToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem تسجيلمستفيدةToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
    }
}