namespace Gui
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
            this.titleLbl = new System.Windows.Forms.Label();
            this.designersConfigBtn = new System.Windows.Forms.Button();
            this.createGridBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.Location = new System.Drawing.Point(44, 34);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(112, 20);
            this.titleLbl.TabIndex = 0;
            this.titleLbl.Text = "Menu Principal";
            // 
            // designersConfigBtn
            // 
            this.designersConfigBtn.Location = new System.Drawing.Point(20, 78);
            this.designersConfigBtn.Name = "designersConfigBtn";
            this.designersConfigBtn.Size = new System.Drawing.Size(169, 32);
            this.designersConfigBtn.TabIndex = 1;
            this.designersConfigBtn.Text = "Mantenimiento a Diseñadores";
            this.designersConfigBtn.UseVisualStyleBackColor = true;
            this.designersConfigBtn.Visible = false;
            this.designersConfigBtn.Click += new System.EventHandler(this.designersConfigBtn_Click);
            // 
            // createGridBtn
            // 
            this.createGridBtn.Location = new System.Drawing.Point(20, 78);
            this.createGridBtn.Name = "createGridBtn";
            this.createGridBtn.Size = new System.Drawing.Size(169, 32);
            this.createGridBtn.TabIndex = 2;
            this.createGridBtn.Text = "Crear Plano";
            this.createGridBtn.UseVisualStyleBackColor = true;
            this.createGridBtn.Visible = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 290);
            this.Controls.Add(this.createGridBtn);
            this.Controls.Add(this.designersConfigBtn);
            this.Controls.Add(this.titleLbl);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Button designersConfigBtn;
        private System.Windows.Forms.Button createGridBtn;
    }
}