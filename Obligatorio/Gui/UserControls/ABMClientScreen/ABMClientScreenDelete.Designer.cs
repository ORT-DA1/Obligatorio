namespace Gui.UserControls.ABMClientScreen
{
    partial class ABMClientScreenDelete
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
            this.deleteClient_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clientList
            // 
            this.clientList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clientList.FormattingEnabled = true;
            this.clientList.Location = new System.Drawing.Point(245, 50);
            this.clientList.Name = "clientList";
            this.clientList.Size = new System.Drawing.Size(168, 199);
            this.clientList.TabIndex = 0;
            // 
            // titleTxt
            // 
            this.titleTxt.AutoSize = true;
            this.titleTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTxt.Location = new System.Drawing.Point(27, 23);
            this.titleTxt.Name = "titleTxt";
            this.titleTxt.Size = new System.Drawing.Size(38, 20);
            this.titleTxt.TabIndex = 1;
            this.titleTxt.Text = "Title";
            // 
            // deleteClient_btn
            // 
            this.deleteClient_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteClient_btn.Location = new System.Drawing.Point(289, 264);
            this.deleteClient_btn.Name = "deleteClient_btn";
            this.deleteClient_btn.Size = new System.Drawing.Size(94, 28);
            this.deleteClient_btn.TabIndex = 2;
            this.deleteClient_btn.Text = "Borrar";
            this.deleteClient_btn.UseVisualStyleBackColor = true;
            this.deleteClient_btn.Click += new System.EventHandler(this.deleteClient);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Seleccione el Cliente que desea borrar:";
            // 
            // ABMClientScreenDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteClient_btn);
            this.Controls.Add(this.titleTxt);
            this.Controls.Add(this.clientList);
            this.Name = "ABMClientScreenDelete";
            this.Size = new System.Drawing.Size(451, 317);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox clientList;
        private System.Windows.Forms.Label titleTxt;
        private System.Windows.Forms.Button deleteClient_btn;
        private System.Windows.Forms.Label label1;
    }
}
