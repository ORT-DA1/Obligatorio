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
            this.mainPicture_box = new System.Windows.Forms.PictureBox();
            this.leftMenuStrip = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.mainPicture_box)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.Location = new System.Drawing.Point(262, 48);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(112, 20);
            this.titleLbl.TabIndex = 0;
            this.titleLbl.Text = "Menu Principal";
            // 
            // mainPicture_box
            // 
            this.mainPicture_box.Image = ((System.Drawing.Image)(resources.GetObject("mainPicture_box.Image")));
            this.mainPicture_box.Location = new System.Drawing.Point(210, 93);
            this.mainPicture_box.Name = "mainPicture_box";
            this.mainPicture_box.Size = new System.Drawing.Size(238, 215);
            this.mainPicture_box.TabIndex = 6;
            this.mainPicture_box.TabStop = false;
            // 
            // leftMenuStrip
            // 
            this.leftMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.leftMenuStrip.Name = "leftMenuStrip";
            this.leftMenuStrip.Size = new System.Drawing.Size(642, 24);
            this.leftMenuStrip.TabIndex = 16;
            this.leftMenuStrip.Text = "Left Menu Strip";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(642, 386);
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.leftMenuStrip);
            this.Controls.Add(this.mainPicture_box);
            this.Name = "MainMenu";
            this.Text = "Graphic Master";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.quit);
            ((System.ComponentModel.ISupportInitialize)(this.mainPicture_box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.PictureBox mainPicture_box;
        private System.Windows.Forms.MenuStrip leftMenuStrip;
    }
}