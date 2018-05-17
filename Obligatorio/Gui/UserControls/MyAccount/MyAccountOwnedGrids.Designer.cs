namespace Gui.UserControls.MyAccount
{
    partial class MyAccountOwnedGrids
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
            this.ownedGridlist = new System.Windows.Forms.ListBox();
            this.seeGrid_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleTxt
            // 
            this.titleTxt.AutoSize = true;
            this.titleTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTxt.Location = new System.Drawing.Point(38, 34);
            this.titleTxt.Name = "titleTxt";
            this.titleTxt.Size = new System.Drawing.Size(38, 20);
            this.titleTxt.TabIndex = 0;
            this.titleTxt.Text = "Title";
            // 
            // ownedGridlist
            // 
            this.ownedGridlist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ownedGridlist.FormattingEnabled = true;
            this.ownedGridlist.Location = new System.Drawing.Point(181, 55);
            this.ownedGridlist.Name = "ownedGridlist";
            this.ownedGridlist.Size = new System.Drawing.Size(187, 173);
            this.ownedGridlist.TabIndex = 1;
            // 
            // seeGrid_btn
            // 
            this.seeGrid_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.seeGrid_btn.Location = new System.Drawing.Point(218, 248);
            this.seeGrid_btn.Name = "seeGrid_btn";
            this.seeGrid_btn.Size = new System.Drawing.Size(117, 29);
            this.seeGrid_btn.TabIndex = 2;
            this.seeGrid_btn.Text = "Ver Plano";
            this.seeGrid_btn.UseVisualStyleBackColor = true;
            this.seeGrid_btn.Click += new System.EventHandler(this.seeGrid);
            // 
            // MyAccountOwnedGrids
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.seeGrid_btn);
            this.Controls.Add(this.ownedGridlist);
            this.Controls.Add(this.titleTxt);
            this.Name = "MyAccountOwnedGrids";
            this.Size = new System.Drawing.Size(462, 308);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleTxt;
        private System.Windows.Forms.ListBox ownedGridlist;
        private System.Windows.Forms.Button seeGrid_btn;
    }
}
