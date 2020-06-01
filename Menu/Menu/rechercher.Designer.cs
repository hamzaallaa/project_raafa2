namespace Menu
{
    partial class rechercher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rechercher));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_sup = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_imp = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_update = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_search = new Bunifu.Framework.UI.BunifuImageButton();
            this.Textbox_search = new Bunifu.Framework.UI.BunifuTextbox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_sup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_imp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_update)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(77)))), ((int)(((byte)(106)))));
            this.panel2.Controls.Add(this.btn_sup);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btn_imp);
            this.panel2.Controls.Add(this.btn_update);
            this.panel2.Controls.Add(this.btn_search);
            this.panel2.Controls.Add(this.Textbox_search);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1323, 70);
            this.panel2.TabIndex = 1;
            // 
            // btn_sup
            // 
            this.btn_sup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(77)))), ((int)(((byte)(106)))));
            this.btn_sup.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btn_sup.ErrorImage")));
            this.btn_sup.Image = global::Menu.Properties.Resources.icons8_supprimer_50;
            this.btn_sup.ImageActive = null;
            this.btn_sup.Location = new System.Drawing.Point(196, 12);
            this.btn_sup.Name = "btn_sup";
            this.btn_sup.Size = new System.Drawing.Size(69, 46);
            this.btn_sup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_sup.TabIndex = 8;
            this.btn_sup.TabStop = false;
            this.btn_sup.Visible = false;
            this.btn_sup.Zoom = 10;
            this.btn_sup.Click += new System.EventHandler(this.bunifuImageButton1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1248, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "بحت :";
            // 
            // btn_imp
            // 
            this.btn_imp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(77)))), ((int)(((byte)(106)))));
            this.btn_imp.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btn_imp.ErrorImage")));
            this.btn_imp.Image = ((System.Drawing.Image)(resources.GetObject("btn_imp.Image")));
            this.btn_imp.ImageActive = null;
            this.btn_imp.Location = new System.Drawing.Point(12, 12);
            this.btn_imp.Name = "btn_imp";
            this.btn_imp.Size = new System.Drawing.Size(69, 46);
            this.btn_imp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_imp.TabIndex = 3;
            this.btn_imp.TabStop = false;
            this.btn_imp.Zoom = 10;
            this.btn_imp.Click += new System.EventHandler(this.btn_imp_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(77)))), ((int)(((byte)(106)))));
            this.btn_update.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btn_update.ErrorImage")));
            this.btn_update.Image = ((System.Drawing.Image)(resources.GetObject("btn_update.Image")));
            this.btn_update.ImageActive = null;
            this.btn_update.Location = new System.Drawing.Point(102, 12);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(69, 46);
            this.btn_update.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_update.TabIndex = 2;
            this.btn_update.TabStop = false;
            this.btn_update.Visible = false;
            this.btn_update.Zoom = 10;
            this.btn_update.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(77)))), ((int)(((byte)(106)))));
            this.btn_search.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btn_search.ErrorImage")));
            this.btn_search.Image = ((System.Drawing.Image)(resources.GetObject("btn_search.Image")));
            this.btn_search.ImageActive = null;
            this.btn_search.Location = new System.Drawing.Point(856, 12);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(74, 46);
            this.btn_search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_search.TabIndex = 1;
            this.btn_search.TabStop = false;
            this.btn_search.Zoom = 10;
            this.btn_search.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // Textbox_search
            // 
            this.Textbox_search.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Textbox_search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Textbox_search.BackgroundImage")));
            this.Textbox_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Textbox_search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.Textbox_search.Icon = ((System.Drawing.Image)(resources.GetObject("Textbox_search.Icon")));
            this.Textbox_search.Location = new System.Drawing.Point(953, 12);
            this.Textbox_search.Name = "Textbox_search";
            this.Textbox_search.Size = new System.Drawing.Size(288, 46);
            this.Textbox_search.TabIndex = 0;
            this.Textbox_search.text = "ادخل رقم مسار او بطاقة الوطنية";
            this.Textbox_search.OnTextChange += new System.EventHandler(this.Textbox_search_OnTextChange);
            this.Textbox_search.MouseEnter += new System.EventHandler(this.Textbox_search_MouseEnter);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 587);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1323, 21);
            this.panel1.TabIndex = 3;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(0, 70);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(1323, 517);
            this.dgv.TabIndex = 4;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // rechercher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 608);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "rechercher";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.rechercher_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_sup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_imp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_update)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuTextbox Textbox_search;
        private Bunifu.Framework.UI.BunifuImageButton btn_search;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton btn_update;
        private Bunifu.Framework.UI.BunifuImageButton btn_imp;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton btn_sup;
        private System.Windows.Forms.DataGridView dgv;
    }
}