namespace Gui.UserControls.ABMClientScreen
{
    partial class ABMClientScreenModify
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
            this.clientList = new System.Windows.Forms.ListBox();
            this.titleTxt = new System.Windows.Forms.Label();
            this.dataLbl = new System.Windows.Forms.Label();
            this.userNameLbl = new System.Windows.Forms.Label();
            this.userNameTxt = new System.Windows.Forms.TextBox();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.surnameTxt = new System.Windows.Forms.TextBox();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.surnameLbl = new System.Windows.Forms.Label();
            this.idTxt = new System.Windows.Forms.TextBox();
            this.idLbl = new System.Windows.Forms.Label();
            this.phoneTxt = new System.Windows.Forms.TextBox();
            this.phoneLbl = new System.Windows.Forms.Label();
            this.addressLbl = new System.Windows.Forms.Label();
            this.addressTxt = new System.Windows.Forms.TextBox();
            this.modifyClient_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clientList
            // 
            this.clientList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clientList.FormattingEnabled = true;
            this.clientList.Location = new System.Drawing.Point(21, 67);
            this.clientList.Name = "clientList";
            this.clientList.Size = new System.Drawing.Size(170, 238);
            this.clientList.TabIndex = 0;
            this.clientList.SelectedIndexChanged += new System.EventHandler(this.renderModifyView);
            // 
            // titleTxt
            // 
            this.titleTxt.AutoSize = true;
            this.titleTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTxt.Location = new System.Drawing.Point(17, 10);
            this.titleTxt.Name = "titleTxt";
            this.titleTxt.Size = new System.Drawing.Size(38, 20);
            this.titleTxt.TabIndex = 1;
            this.titleTxt.Text = "Title";
            // 
            // dataLbl
            // 
            this.dataLbl.AutoSize = true;
            this.dataLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataLbl.Location = new System.Drawing.Point(377, 30);
            this.dataLbl.Name = "dataLbl";
            this.dataLbl.Size = new System.Drawing.Size(56, 20);
            this.dataLbl.TabIndex = 2;
            this.dataLbl.Text = "Datos:";
            // 
            // userNameLbl
            // 
            this.userNameLbl.AutoSize = true;
            this.userNameLbl.Location = new System.Drawing.Point(211, 82);
            this.userNameLbl.Name = "userNameLbl";
            this.userNameLbl.Size = new System.Drawing.Size(58, 13);
            this.userNameLbl.TabIndex = 3;
            this.userNameLbl.Text = "Username:";
            // 
            // userNameTxt
            // 
            this.userNameTxt.Location = new System.Drawing.Point(275, 79);
            this.userNameTxt.Name = "userNameTxt";
            this.userNameTxt.Size = new System.Drawing.Size(106, 20);
            this.userNameTxt.TabIndex = 1;
            // 
            // passwordTxt
            // 
            this.passwordTxt.Location = new System.Drawing.Point(275, 114);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(106, 20);
            this.passwordTxt.TabIndex = 2;
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(275, 152);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(106, 20);
            this.nameTxt.TabIndex = 3;
            // 
            // surnameTxt
            // 
            this.surnameTxt.Location = new System.Drawing.Point(275, 192);
            this.surnameTxt.Name = "surnameTxt";
            this.surnameTxt.Size = new System.Drawing.Size(106, 20);
            this.surnameTxt.TabIndex = 4;
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Location = new System.Drawing.Point(205, 117);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(64, 13);
            this.passwordLbl.TabIndex = 5;
            this.passwordLbl.Text = "Contraseña:";
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(222, 155);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(47, 13);
            this.nameLbl.TabIndex = 6;
            this.nameLbl.Text = "Nombre:";
            // 
            // surnameLbl
            // 
            this.surnameLbl.AutoSize = true;
            this.surnameLbl.Location = new System.Drawing.Point(222, 195);
            this.surnameLbl.Name = "surnameLbl";
            this.surnameLbl.Size = new System.Drawing.Size(47, 13);
            this.surnameLbl.TabIndex = 7;
            this.surnameLbl.Text = "Apellido:";
            // 
            // idTxt
            // 
            this.idTxt.Location = new System.Drawing.Point(463, 79);
            this.idTxt.Name = "idTxt";
            this.idTxt.Size = new System.Drawing.Size(106, 20);
            this.idTxt.TabIndex = 5;
            // 
            // idLbl
            // 
            this.idLbl.AutoSize = true;
            this.idLbl.Location = new System.Drawing.Point(414, 82);
            this.idLbl.Name = "idLbl";
            this.idLbl.Size = new System.Drawing.Size(43, 13);
            this.idLbl.TabIndex = 8;
            this.idLbl.Text = "Cedula:";
            // 
            // phoneTxt
            // 
            this.phoneTxt.Location = new System.Drawing.Point(463, 120);
            this.phoneTxt.Name = "phoneTxt";
            this.phoneTxt.Size = new System.Drawing.Size(106, 20);
            this.phoneTxt.TabIndex = 6;
            // 
            // phoneLbl
            // 
            this.phoneLbl.AutoSize = true;
            this.phoneLbl.Location = new System.Drawing.Point(405, 123);
            this.phoneLbl.Name = "phoneLbl";
            this.phoneLbl.Size = new System.Drawing.Size(52, 13);
            this.phoneLbl.TabIndex = 10;
            this.phoneLbl.Text = "Telefono:";
            // 
            // addressLbl
            // 
            this.addressLbl.AutoSize = true;
            this.addressLbl.Location = new System.Drawing.Point(402, 159);
            this.addressLbl.Name = "addressLbl";
            this.addressLbl.Size = new System.Drawing.Size(55, 13);
            this.addressLbl.TabIndex = 11;
            this.addressLbl.Text = "Direccion:";
            // 
            // addressTxt
            // 
            this.addressTxt.Location = new System.Drawing.Point(463, 156);
            this.addressTxt.Name = "addressTxt";
            this.addressTxt.Size = new System.Drawing.Size(106, 20);
            this.addressTxt.TabIndex = 7;
            // 
            // modifyClient_btn
            // 
            this.modifyClient_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modifyClient_btn.Enabled = false;
            this.modifyClient_btn.Location = new System.Drawing.Point(358, 253);
            this.modifyClient_btn.Name = "modifyClient_btn";
            this.modifyClient_btn.Size = new System.Drawing.Size(109, 31);
            this.modifyClient_btn.TabIndex = 8;
            this.modifyClient_btn.Text = "Modificar Cliente";
            this.modifyClient_btn.UseVisualStyleBackColor = true;
            this.modifyClient_btn.Click += new System.EventHandler(this.modifyClient);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Seleccione el Cliente que desea modificar:";
            // 
            // ABMClientScreenModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.modifyClient_btn);
            this.Controls.Add(this.addressTxt);
            this.Controls.Add(this.addressLbl);
            this.Controls.Add(this.phoneLbl);
            this.Controls.Add(this.phoneTxt);
            this.Controls.Add(this.idLbl);
            this.Controls.Add(this.idTxt);
            this.Controls.Add(this.surnameLbl);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.surnameTxt);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.userNameTxt);
            this.Controls.Add(this.userNameLbl);
            this.Controls.Add(this.dataLbl);
            this.Controls.Add(this.titleTxt);
            this.Controls.Add(this.clientList);
            this.Name = "ABMClientScreenModify";
            this.Size = new System.Drawing.Size(634, 317);
            this.Leave += new System.EventHandler(this.LeaveController);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox clientList;
        private System.Windows.Forms.Label titleTxt;
        private System.Windows.Forms.Label dataLbl;
        private System.Windows.Forms.Label userNameLbl;
        private System.Windows.Forms.TextBox userNameTxt;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.TextBox surnameTxt;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label surnameLbl;
        private System.Windows.Forms.TextBox idTxt;
        private System.Windows.Forms.Label idLbl;
        private System.Windows.Forms.TextBox phoneTxt;
        private System.Windows.Forms.Label phoneLbl;
        private System.Windows.Forms.Label addressLbl;
        private System.Windows.Forms.TextBox addressTxt;
        private System.Windows.Forms.Button modifyClient_btn;
        private System.Windows.Forms.Label label2;
    }
}
