namespace Gui.Forms
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.titleLbl = new System.Windows.Forms.Label();
            this.leftMenuStrip = new System.Windows.Forms.MenuStrip();
            this.options = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.leftMenuStrip.SuspendLayout();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.Location = new System.Drawing.Point(131, 31);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(205, 35);
            this.titleLbl.TabIndex = 0;
            this.titleLbl.Text = "Graphic Master";
            // 
            // leftMenuStrip
            // 
            this.leftMenuStrip.AutoSize = false;
            this.leftMenuStrip.BackColor = System.Drawing.Color.SlateGray;
            this.leftMenuStrip.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.leftMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.options});
            this.leftMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.leftMenuStrip.Name = "leftMenuStrip";
            this.leftMenuStrip.Padding = new System.Windows.Forms.Padding(6, 2, 0, 0);
            this.leftMenuStrip.Size = new System.Drawing.Size(118, 447);
            this.leftMenuStrip.TabIndex = 16;
            this.leftMenuStrip.Text = "Left Menu Strip";
            // 
            // options
            // 
            this.options.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesionToolStripMenuItem});
            this.options.Name = "options";
            this.options.Size = new System.Drawing.Size(111, 19);
            this.options.Text = "General";
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.logOut);
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.pictureBox1);
            this.MainPanel.Controls.Add(this.titleLbl);
            this.MainPanel.Location = new System.Drawing.Point(113, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(581, 116);
            this.MainPanel.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(424, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 122);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // controlPanel
            // 
            this.controlPanel.BackColor = System.Drawing.Color.LightBlue;
            this.controlPanel.Location = new System.Drawing.Point(113, 113);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(581, 333);
            this.controlPanel.TabIndex = 18;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(697, 447);
            this.Controls.Add(this.controlPanel);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.leftMenuStrip);
            this.Name = "MainMenu";
            this.Text = "Graphic Master";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.quit);
            this.leftMenuStrip.ResumeLayout(false);
            this.leftMenuStrip.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.MenuStrip leftMenuStrip;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem options;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
    }
}