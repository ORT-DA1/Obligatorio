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
            this.showDesignerConfiguration_btn = new System.Windows.Forms.Button();
            this.createGrid_btn = new System.Windows.Forms.Button();
            this.showGirdConfiguration_btn = new System.Windows.Forms.Button();
            this.topMenu = new System.Windows.Forms.MenuStrip();
            this.userOptions_Btn = new System.Windows.Forms.ToolStripMenuItem();
            this.logOut_Btn = new System.Windows.Forms.ToolStripMenuItem();
            this.clearMenu_Btn = new System.Windows.Forms.Label();
            this.mainPicture_box = new System.Windows.Forms.PictureBox();
            this.modifyGrid_btn = new System.Windows.Forms.Button();
            this.deleteGrid_btn = new System.Windows.Forms.Button();
            this.createDesigner_btn = new System.Windows.Forms.Button();
            this.modifyDesigner_btn = new System.Windows.Forms.Button();
            this.deleteDesigners_btn = new System.Windows.Forms.Button();
            this.showClientsConfiguration_btn = new System.Windows.Forms.Button();
            this.createClients_brn = new System.Windows.Forms.Button();
            this.modifyClients_btn = new System.Windows.Forms.Button();
            this.deleteClients_btn = new System.Windows.Forms.Button();
            this.leftMenuStrip = new System.Windows.Forms.MenuStrip();
            this.topMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainPicture_box)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.Location = new System.Drawing.Point(111, 34);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(112, 20);
            this.titleLbl.TabIndex = 0;
            this.titleLbl.Text = "Menu Principal";
            // 
            // showDesignerConfiguration_btn
            // 
            this.showDesignerConfiguration_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showDesignerConfiguration_btn.Location = new System.Drawing.Point(473, 175);
            this.showDesignerConfiguration_btn.Name = "showDesignerConfiguration_btn";
            this.showDesignerConfiguration_btn.Size = new System.Drawing.Size(169, 32);
            this.showDesignerConfiguration_btn.TabIndex = 1;
            this.showDesignerConfiguration_btn.Text = "Mantenimiento de Diseñadores";
            this.showDesignerConfiguration_btn.UseVisualStyleBackColor = true;
            this.showDesignerConfiguration_btn.Visible = false;
            this.showDesignerConfiguration_btn.Click += new System.EventHandler(this.showDesignersConfiguration);
            // 
            // createGrid_btn
            // 
            this.createGrid_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createGrid_btn.Location = new System.Drawing.Point(461, 96);
            this.createGrid_btn.Name = "createGrid_btn";
            this.createGrid_btn.Size = new System.Drawing.Size(169, 32);
            this.createGrid_btn.TabIndex = 2;
            this.createGrid_btn.Text = "Crear Plano";
            this.createGrid_btn.UseVisualStyleBackColor = true;
            this.createGrid_btn.Visible = false;
            this.createGrid_btn.Click += new System.EventHandler(this.createGrid);
            // 
            // showGirdConfiguration_btn
            // 
            this.showGirdConfiguration_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showGirdConfiguration_btn.Location = new System.Drawing.Point(473, 212);
            this.showGirdConfiguration_btn.Name = "showGirdConfiguration_btn";
            this.showGirdConfiguration_btn.Size = new System.Drawing.Size(169, 32);
            this.showGirdConfiguration_btn.TabIndex = 3;
            this.showGirdConfiguration_btn.Text = "Mantenimiento de Planos";
            this.showGirdConfiguration_btn.UseVisualStyleBackColor = true;
            this.showGirdConfiguration_btn.Visible = false;
            this.showGirdConfiguration_btn.Click += new System.EventHandler(this.showGridConfiguration);
            // 
            // topMenu
            // 
            this.topMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userOptions_Btn});
            this.topMenu.Location = new System.Drawing.Point(98, 0);
            this.topMenu.Name = "topMenu";
            this.topMenu.Size = new System.Drawing.Size(544, 24);
            this.topMenu.TabIndex = 4;
            this.topMenu.Text = "Top Menu";
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
            this.logOut_Btn.Size = new System.Drawing.Size(152, 22);
            this.logOut_Btn.Text = "Cerrar Sesion";
            this.logOut_Btn.Click += new System.EventHandler(this.logOut);
            // 
            // clearMenu_Btn
            // 
            this.clearMenu_Btn.AutoSize = true;
            this.clearMenu_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearMenu_Btn.Location = new System.Drawing.Point(537, 352);
            this.clearMenu_Btn.Name = "clearMenu_Btn";
            this.clearMenu_Btn.Size = new System.Drawing.Size(70, 13);
            this.clearMenu_Btn.TabIndex = 5;
            this.clearMenu_Btn.Text = "Limpiar Menu";
            this.clearMenu_Btn.Click += new System.EventHandler(this.clearMenu);
            // 
            // mainPicture_box
            // 
            this.mainPicture_box.Image = ((System.Drawing.Image)(resources.GetObject("mainPicture_box.Image")));
            this.mainPicture_box.Location = new System.Drawing.Point(409, 134);
            this.mainPicture_box.Name = "mainPicture_box";
            this.mainPicture_box.Size = new System.Drawing.Size(238, 215);
            this.mainPicture_box.TabIndex = 6;
            this.mainPicture_box.TabStop = false;
            // 
            // modifyGrid_btn
            // 
            this.modifyGrid_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modifyGrid_btn.Location = new System.Drawing.Point(272, 136);
            this.modifyGrid_btn.Name = "modifyGrid_btn";
            this.modifyGrid_btn.Size = new System.Drawing.Size(169, 33);
            this.modifyGrid_btn.TabIndex = 7;
            this.modifyGrid_btn.Text = "Modificar Plano";
            this.modifyGrid_btn.UseVisualStyleBackColor = true;
            this.modifyGrid_btn.Visible = false;
            // 
            // deleteGrid_btn
            // 
            this.deleteGrid_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteGrid_btn.Location = new System.Drawing.Point(234, 275);
            this.deleteGrid_btn.Name = "deleteGrid_btn";
            this.deleteGrid_btn.Size = new System.Drawing.Size(169, 33);
            this.deleteGrid_btn.TabIndex = 8;
            this.deleteGrid_btn.Text = "Eliminar Plano";
            this.deleteGrid_btn.UseVisualStyleBackColor = true;
            this.deleteGrid_btn.Visible = false;
            // 
            // createDesigner_btn
            // 
            this.createDesigner_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createDesigner_btn.Location = new System.Drawing.Point(289, 45);
            this.createDesigner_btn.Name = "createDesigner_btn";
            this.createDesigner_btn.Size = new System.Drawing.Size(169, 32);
            this.createDesigner_btn.TabIndex = 9;
            this.createDesigner_btn.Text = "Crear Diseñadores";
            this.createDesigner_btn.UseVisualStyleBackColor = true;
            this.createDesigner_btn.Visible = false;
            // 
            // modifyDesigner_btn
            // 
            this.modifyDesigner_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modifyDesigner_btn.Location = new System.Drawing.Point(272, 96);
            this.modifyDesigner_btn.Name = "modifyDesigner_btn";
            this.modifyDesigner_btn.Size = new System.Drawing.Size(169, 34);
            this.modifyDesigner_btn.TabIndex = 10;
            this.modifyDesigner_btn.Text = "Modificar Diseñadores";
            this.modifyDesigner_btn.UseVisualStyleBackColor = true;
            this.modifyDesigner_btn.Visible = false;
            // 
            // deleteDesigners_btn
            // 
            this.deleteDesigners_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteDesigners_btn.Location = new System.Drawing.Point(234, 236);
            this.deleteDesigners_btn.Name = "deleteDesigners_btn";
            this.deleteDesigners_btn.Size = new System.Drawing.Size(169, 33);
            this.deleteDesigners_btn.TabIndex = 11;
            this.deleteDesigners_btn.Text = "Eliminar Diseñadores";
            this.deleteDesigners_btn.UseVisualStyleBackColor = true;
            this.deleteDesigners_btn.Visible = false;
            // 
            // showClientsConfiguration_btn
            // 
            this.showClientsConfiguration_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showClientsConfiguration_btn.Location = new System.Drawing.Point(474, 251);
            this.showClientsConfiguration_btn.Name = "showClientsConfiguration_btn";
            this.showClientsConfiguration_btn.Size = new System.Drawing.Size(168, 32);
            this.showClientsConfiguration_btn.TabIndex = 12;
            this.showClientsConfiguration_btn.Text = "Mantenimiento de Clientes";
            this.showClientsConfiguration_btn.UseVisualStyleBackColor = true;
            this.showClientsConfiguration_btn.Visible = false;
            this.showClientsConfiguration_btn.Click += new System.EventHandler(this.showClientsConfiguration);
            // 
            // createClients_brn
            // 
            this.createClients_brn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createClients_brn.Location = new System.Drawing.Point(473, 34);
            this.createClients_brn.Name = "createClients_brn";
            this.createClients_brn.Size = new System.Drawing.Size(169, 32);
            this.createClients_brn.TabIndex = 13;
            this.createClients_brn.Text = "Crear Clientes";
            this.createClients_brn.UseVisualStyleBackColor = true;
            this.createClients_brn.Visible = false;
            // 
            // modifyClients_btn
            // 
            this.modifyClients_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modifyClients_btn.Location = new System.Drawing.Point(272, 175);
            this.modifyClients_btn.Name = "modifyClients_btn";
            this.modifyClients_btn.Size = new System.Drawing.Size(169, 34);
            this.modifyClients_btn.TabIndex = 14;
            this.modifyClients_btn.Text = "Modificar Clientes";
            this.modifyClients_btn.UseVisualStyleBackColor = true;
            this.modifyClients_btn.Visible = false;
            // 
            // deleteClients_btn
            // 
            this.deleteClients_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteClients_btn.Location = new System.Drawing.Point(234, 316);
            this.deleteClients_btn.Name = "deleteClients_btn";
            this.deleteClients_btn.Size = new System.Drawing.Size(169, 33);
            this.deleteClients_btn.TabIndex = 15;
            this.deleteClients_btn.Text = "Eliminar Clientes";
            this.deleteClients_btn.UseVisualStyleBackColor = true;
            // 
            // leftMenuStrip
            // 
            this.leftMenuStrip.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.leftMenuStrip.Name = "leftMenuStrip";
            this.leftMenuStrip.Size = new System.Drawing.Size(98, 386);
            this.leftMenuStrip.TabIndex = 16;
            this.leftMenuStrip.Text = "Left Menu Strip";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(642, 386);
            this.Controls.Add(this.deleteClients_btn);
            this.Controls.Add(this.modifyClients_btn);
            this.Controls.Add(this.createClients_brn);
            this.Controls.Add(this.showClientsConfiguration_btn);
            this.Controls.Add(this.deleteDesigners_btn);
            this.Controls.Add(this.modifyDesigner_btn);
            this.Controls.Add(this.createDesigner_btn);
            this.Controls.Add(this.deleteGrid_btn);
            this.Controls.Add(this.modifyGrid_btn);
            this.Controls.Add(this.clearMenu_Btn);
            this.Controls.Add(this.showGirdConfiguration_btn);
            this.Controls.Add(this.createGrid_btn);
            this.Controls.Add(this.showDesignerConfiguration_btn);
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.topMenu);
            this.Controls.Add(this.leftMenuStrip);
            this.Controls.Add(this.mainPicture_box);
            this.MainMenuStrip = this.topMenu;
            this.Name = "MainMenu";
            this.Text = "Graphic Master";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.quit);
            this.topMenu.ResumeLayout(false);
            this.topMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainPicture_box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Button showDesignerConfiguration_btn;
        private System.Windows.Forms.Button createGrid_btn;
        private System.Windows.Forms.Button showGirdConfiguration_btn;
        private System.Windows.Forms.MenuStrip topMenu;
        private System.Windows.Forms.ToolStripMenuItem userOptions_Btn;
        private System.Windows.Forms.ToolStripMenuItem logOut_Btn;
        private System.Windows.Forms.Label clearMenu_Btn;
        private System.Windows.Forms.PictureBox mainPicture_box;
        private System.Windows.Forms.Button modifyGrid_btn;
        private System.Windows.Forms.Button deleteGrid_btn;
        private System.Windows.Forms.Button createDesigner_btn;
        private System.Windows.Forms.Button modifyDesigner_btn;
        private System.Windows.Forms.Button deleteDesigners_btn;
        private System.Windows.Forms.Button showClientsConfiguration_btn;
        private System.Windows.Forms.Button createClients_brn;
        private System.Windows.Forms.Button modifyClients_btn;
        private System.Windows.Forms.Button deleteClients_btn;
        private System.Windows.Forms.MenuStrip leftMenuStrip;
    }
}