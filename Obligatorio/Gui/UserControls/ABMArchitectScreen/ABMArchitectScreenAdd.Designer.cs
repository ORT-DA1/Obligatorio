namespace Gui.UserControls.ABMArchitectScreen
{
    partial class ABMArchitectScreenAdd
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
            this.titleTxt = new System.Windows.Forms.Label();
            this.addArchitect = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.surnameTxt = new System.Windows.Forms.TextBox();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.usernameTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // titleTxt
            // 
            this.titleTxt.AutoSize = true;
            this.titleTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTxt.Location = new System.Drawing.Point(57, 36);
            this.titleTxt.Name = "titleTxt";
            this.titleTxt.Size = new System.Drawing.Size(38, 20);
            this.titleTxt.TabIndex = 39;
            this.titleTxt.Text = "Title";
            // 
            // addArchitect
            // 
            this.addArchitect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addArchitect.Location = new System.Drawing.Point(219, 284);
            this.addArchitect.Name = "addArchitect";
            this.addArchitect.Size = new System.Drawing.Size(119, 28);
            this.addArchitect.TabIndex = 5;
            this.addArchitect.Text = "Guardar";
            this.addArchitect.UseVisualStyleBackColor = true;
            this.addArchitect.Click += new System.EventHandler(this.addArchitect_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(163, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Apellido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Contraseña:";
            // 
            // surnameTxt
            // 
            this.surnameTxt.Location = new System.Drawing.Point(219, 225);
            this.surnameTxt.Name = "surnameTxt";
            this.surnameTxt.Size = new System.Drawing.Size(119, 20);
            this.surnameTxt.TabIndex = 4;
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(219, 181);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(119, 20);
            this.nameTxt.TabIndex = 3;
            // 
            // passwordTxt
            // 
            this.passwordTxt.Location = new System.Drawing.Point(219, 133);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.PasswordChar = '*';
            this.passwordTxt.Size = new System.Drawing.Size(119, 20);
            this.passwordTxt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Username:";
            // 
            // usernameTxt
            // 
            this.usernameTxt.Location = new System.Drawing.Point(219, 89);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(119, 20);
            this.usernameTxt.TabIndex = 1;
            // 
            // ABMArchitectScreenAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.titleTxt);
            this.Controls.Add(this.addArchitect);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.surnameTxt);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usernameTxt);
            this.Name = "ABMArchitectScreenAdd";
            this.Size = new System.Drawing.Size(499, 361);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleTxt;
        private System.Windows.Forms.Button addArchitect;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox surnameTxt;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox usernameTxt;
    }
}
