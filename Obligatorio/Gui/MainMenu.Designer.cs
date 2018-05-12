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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.titleLbl = new System.Windows.Forms.Label();
            this.designerConfiguration_btn = new System.Windows.Forms.Button();
            this.createGrid_btn = new System.Windows.Forms.Button();
            this.girdConfiguration_btn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.userOptions_Btn = new System.Windows.Forms.ToolStripMenuItem();
            this.logOut_Btn = new System.Windows.Forms.ToolStripMenuItem();
            this.clearMenu_Btn = new System.Windows.Forms.Label();
            this.mainPicture_box = new System.Windows.Forms.PictureBox();
            this.modifyGrid_btn = new System.Windows.Forms.Button();
            this.deleteGrid_btn = new System.Windows.Forms.Button();
            this.createDesigner_btn = new System.Windows.Forms.Button();
            this.modifyDesigner_btn = new System.Windows.Forms.Button();
            this.deleteDesigners_btn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainPicture_box)).BeginInit();
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
            // designerConfiguration_btn
            // 
            this.designerConfiguration_btn.Location = new System.Drawing.Point(20, 78);
            this.designerConfiguration_btn.Name = "designerConfiguration_btn";
            this.designerConfiguration_btn.Size = new System.Drawing.Size(169, 32);
            this.designerConfiguration_btn.TabIndex = 1;
            this.designerConfiguration_btn.Text = "Mantenimiento de Diseñadores";
            this.designerConfiguration_btn.UseVisualStyleBackColor = true;
            this.designerConfiguration_btn.Visible = false;
            this.designerConfiguration_btn.Click += new System.EventHandler(this.showDesignersConfiguration);
            // 
            // createGrid_btn
            // 
            this.createGrid_btn.Location = new System.Drawing.Point(268, 48);
            this.createGrid_btn.Name = "createGrid_btn";
            this.createGrid_btn.Size = new System.Drawing.Size(169, 32);
            this.createGrid_btn.TabIndex = 2;
            this.createGrid_btn.Text = "Crear Plano";
            this.createGrid_btn.UseVisualStyleBackColor = true;
            this.createGrid_btn.Visible = false;
            this.createGrid_btn.Click += new System.EventHandler(this.createGrid);
            // 
            // girdConfiguration_btn
            // 
            this.girdConfiguration_btn.Location = new System.Drawing.Point(20, 98);
            this.girdConfiguration_btn.Name = "girdConfiguration_btn";
            this.girdConfiguration_btn.Size = new System.Drawing.Size(169, 32);
            this.girdConfiguration_btn.TabIndex = 3;
            this.girdConfiguration_btn.Text = "Mantenimiento de Planos";
            this.girdConfiguration_btn.UseVisualStyleBackColor = true;
            this.girdConfiguration_btn.Visible = false;
            this.girdConfiguration_btn.Click += new System.EventHandler(this.showGridConfigurationOptions);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userOptions_Btn});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(491, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // userOptions_Btn
            // 
            this.userOptions_Btn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOut_Btn});
            this.userOptions_Btn.Name = "userOptions_Btn";
            this.userOptions_Btn.Size = new System.Drawing.Size(69, 20);
            this.userOptions_Btn.Text = "Opciones";
            // 
            // logOut_Btn
            // 
            this.logOut_Btn.Name = "logOut_Btn";
            this.logOut_Btn.Size = new System.Drawing.Size(143, 22);
            this.logOut_Btn.Text = "Cerrar Sesion";
            this.logOut_Btn.Click += new System.EventHandler(this.logOut);
            // 
            // clearMenu_Btn
            // 
            this.clearMenu_Btn.AutoSize = true;
            this.clearMenu_Btn.Location = new System.Drawing.Point(317, 259);
            this.clearMenu_Btn.Name = "clearMenu_Btn";
            this.clearMenu_Btn.Size = new System.Drawing.Size(70, 13);
            this.clearMenu_Btn.TabIndex = 5;
            this.clearMenu_Btn.Text = "Limpiar Menu";
            this.clearMenu_Btn.Click += new System.EventHandler(this.clearMenu);
            // 
            // mainPicture_box
            // 
            this.mainPicture_box.Image = ((System.Drawing.Image)(resources.GetObject("mainPicture_box.Image")));
            this.mainPicture_box.Location = new System.Drawing.Point(232, 34);
            this.mainPicture_box.Name = "mainPicture_box";
            this.mainPicture_box.Size = new System.Drawing.Size(238, 215);
            this.mainPicture_box.TabIndex = 6;
            this.mainPicture_box.TabStop = false;
            // 
            // modifyGrid_btn
            // 
            this.modifyGrid_btn.Location = new System.Drawing.Point(268, 113);
            this.modifyGrid_btn.Name = "modifyGrid_btn";
            this.modifyGrid_btn.Size = new System.Drawing.Size(169, 33);
            this.modifyGrid_btn.TabIndex = 7;
            this.modifyGrid_btn.Text = "Modificar Plano";
            this.modifyGrid_btn.UseVisualStyleBackColor = true;
            this.modifyGrid_btn.Visible = false;
            // 
            // deleteGrid_btn
            // 
            this.deleteGrid_btn.Location = new System.Drawing.Point(268, 180);
            this.deleteGrid_btn.Name = "deleteGrid_btn";
            this.deleteGrid_btn.Size = new System.Drawing.Size(169, 33);
            this.deleteGrid_btn.TabIndex = 8;
            this.deleteGrid_btn.Text = "Eliminar Plano";
            this.deleteGrid_btn.UseVisualStyleBackColor = true;
            this.deleteGrid_btn.Visible = false;
            // 
            // createDesigner_btn
            // 
            this.createDesigner_btn.Location = new System.Drawing.Point(268, 48);
            this.createDesigner_btn.Name = "createDesigner_btn";
            this.createDesigner_btn.Size = new System.Drawing.Size(169, 32);
            this.createDesigner_btn.TabIndex = 9;
            this.createDesigner_btn.Text = "Crear Diseñadores";
            this.createDesigner_btn.UseVisualStyleBackColor = true;
            this.createDesigner_btn.Visible = false;
            // 
            // modifyDesigner_btn
            // 
            this.modifyDesigner_btn.Location = new System.Drawing.Point(268, 111);
            this.modifyDesigner_btn.Name = "modifyDesigner_btn";
            this.modifyDesigner_btn.Size = new System.Drawing.Size(168, 34);
            this.modifyDesigner_btn.TabIndex = 10;
            this.modifyDesigner_btn.Text = "Modificar Diseñadores";
            this.modifyDesigner_btn.UseVisualStyleBackColor = true;
            this.modifyDesigner_btn.Visible = false;
            // 
            // deleteDesigners_btn
            // 
            this.deleteDesigners_btn.Location = new System.Drawing.Point(270, 181);
            this.deleteDesigners_btn.Name = "deleteDesigners_btn";
            this.deleteDesigners_btn.Size = new System.Drawing.Size(167, 32);
            this.deleteDesigners_btn.TabIndex = 11;
            this.deleteDesigners_btn.Text = "Eliminar Diseñadores";
            this.deleteDesigners_btn.UseVisualStyleBackColor = true;
            this.deleteDesigners_btn.Visible = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(491, 290);
            this.Controls.Add(this.deleteDesigners_btn);
            this.Controls.Add(this.modifyDesigner_btn);
            this.Controls.Add(this.createDesigner_btn);
            this.Controls.Add(this.deleteGrid_btn);
            this.Controls.Add(this.modifyGrid_btn);
            this.Controls.Add(this.clearMenu_Btn);
            this.Controls.Add(this.girdConfiguration_btn);
            this.Controls.Add(this.createGrid_btn);
            this.Controls.Add(this.designerConfiguration_btn);
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.mainPicture_box);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.exit);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainPicture_box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Button designerConfiguration_btn;
        private System.Windows.Forms.Button createGrid_btn;
        private System.Windows.Forms.Button girdConfiguration_btn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem userOptions_Btn;
        private System.Windows.Forms.ToolStripMenuItem logOut_Btn;
        private System.Windows.Forms.Label clearMenu_Btn;
        private System.Windows.Forms.PictureBox mainPicture_box;
        private System.Windows.Forms.Button modifyGrid_btn;
        private System.Windows.Forms.Button deleteGrid_btn;
        private System.Windows.Forms.Button createDesigner_btn;
        private System.Windows.Forms.Button modifyDesigner_btn;
        private System.Windows.Forms.Button deleteDesigners_btn;
    }
}