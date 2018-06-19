namespace Gui.UserControls.ABMArchitectScreen
{
    partial class ABMArchitectScreenModify
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.titleLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.modifyArchitect_btn = new System.Windows.Forms.Button();
            this.surnameLbl = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.surnameTxt = new System.Windows.Forms.TextBox();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.userNameTxt = new System.Windows.Forms.TextBox();
            this.userNameLbl = new System.Windows.Forms.Label();
            this.dataLbl = new System.Windows.Forms.Label();
            this.architectList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.Location = new System.Drawing.Point(28, 22);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(38, 20);
            this.titleLbl.TabIndex = 44;
            this.titleLbl.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Seleccione el Arquitecto que desea modificar:";
            // 
            // modifyArchitect_btn
            // 
            this.modifyArchitect_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modifyArchitect_btn.Enabled = false;
            this.modifyArchitect_btn.Location = new System.Drawing.Point(368, 260);
            this.modifyArchitect_btn.Name = "modifyArchitect_btn";
            this.modifyArchitect_btn.Size = new System.Drawing.Size(109, 31);
            this.modifyArchitect_btn.TabIndex = 42;
            this.modifyArchitect_btn.Text = "Modificar Arquitecto";
            this.modifyArchitect_btn.UseVisualStyleBackColor = true;
            this.modifyArchitect_btn.Click += new System.EventHandler(this.modifyArchitect);
            // 
            // surnameLbl
            // 
            this.surnameLbl.AutoSize = true;
            this.surnameLbl.Location = new System.Drawing.Point(318, 213);
            this.surnameLbl.Name = "surnameLbl";
            this.surnameLbl.Size = new System.Drawing.Size(47, 13);
            this.surnameLbl.TabIndex = 41;
            this.surnameLbl.Text = "Apellido:";
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(318, 173);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(47, 13);
            this.nameLbl.TabIndex = 40;
            this.nameLbl.Text = "Nombre:";
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Location = new System.Drawing.Point(301, 135);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(64, 13);
            this.passwordLbl.TabIndex = 39;
            this.passwordLbl.Text = "Contraseña:";
            // 
            // surnameTxt
            // 
            this.surnameTxt.Location = new System.Drawing.Point(371, 210);
            this.surnameTxt.Name = "surnameTxt";
            this.surnameTxt.Size = new System.Drawing.Size(106, 20);
            this.surnameTxt.TabIndex = 35;
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(371, 170);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(106, 20);
            this.nameTxt.TabIndex = 34;
            // 
            // passwordTxt
            // 
            this.passwordTxt.Location = new System.Drawing.Point(371, 132);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.PasswordChar = '*';
            this.passwordTxt.Size = new System.Drawing.Size(106, 20);
            this.passwordTxt.TabIndex = 33;
            // 
            // userNameTxt
            // 
            this.userNameTxt.Location = new System.Drawing.Point(371, 97);
            this.userNameTxt.Name = "userNameTxt";
            this.userNameTxt.Size = new System.Drawing.Size(106, 20);
            this.userNameTxt.TabIndex = 32;
            // 
            // userNameLbl
            // 
            this.userNameLbl.AutoSize = true;
            this.userNameLbl.Location = new System.Drawing.Point(307, 100);
            this.userNameLbl.Name = "userNameLbl";
            this.userNameLbl.Size = new System.Drawing.Size(58, 13);
            this.userNameLbl.TabIndex = 38;
            this.userNameLbl.Text = "Username:";
            // 
            // dataLbl
            // 
            this.dataLbl.AutoSize = true;
            this.dataLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataLbl.Location = new System.Drawing.Point(387, 43);
            this.dataLbl.Name = "dataLbl";
            this.dataLbl.Size = new System.Drawing.Size(56, 20);
            this.dataLbl.TabIndex = 37;
            this.dataLbl.Text = "Datos:";
            // 
            // architectList
            // 
            this.architectList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.architectList.FormattingEnabled = true;
            this.architectList.Location = new System.Drawing.Point(31, 80);
            this.architectList.Name = "architectList";
            this.architectList.Size = new System.Drawing.Size(170, 238);
            this.architectList.TabIndex = 36;
            this.architectList.SelectedIndexChanged += new System.EventHandler(this.renderModifiedView);
            // 
            // ABMArchitectScreenModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.modifyArchitect_btn);
            this.Controls.Add(this.surnameLbl);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.surnameTxt);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.userNameTxt);
            this.Controls.Add(this.userNameLbl);
            this.Controls.Add(this.dataLbl);
            this.Controls.Add(this.architectList);
            this.Name = "ABMArchitectScreenModify";
            this.Size = new System.Drawing.Size(523, 335);
            this.Leave += new System.EventHandler(this.LeaveController);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button modifyArchitect_btn;
        private System.Windows.Forms.Label surnameLbl;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.TextBox surnameTxt;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.TextBox userNameTxt;
        private System.Windows.Forms.Label userNameLbl;
        private System.Windows.Forms.Label dataLbl;
        private System.Windows.Forms.ListBox architectList;
    }
}
