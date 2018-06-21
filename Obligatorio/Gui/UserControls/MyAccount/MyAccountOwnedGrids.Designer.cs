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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.signedGrids_btn = new System.Windows.Forms.Button();
            this.signedGrids_list = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // titleTxt
            // 
            this.titleTxt.AutoSize = true;
            this.titleTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTxt.Location = new System.Drawing.Point(9, 8);
            this.titleTxt.Name = "titleTxt";
            this.titleTxt.Size = new System.Drawing.Size(38, 20);
            this.titleTxt.TabIndex = 0;
            this.titleTxt.Text = "Title";
            // 
            // ownedGridlist
            // 
            this.ownedGridlist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ownedGridlist.FormattingEnabled = true;
            this.ownedGridlist.Location = new System.Drawing.Point(38, 75);
            this.ownedGridlist.Name = "ownedGridlist";
            this.ownedGridlist.Size = new System.Drawing.Size(187, 173);
            this.ownedGridlist.TabIndex = 1;
            // 
            // seeGrid_btn
            // 
            this.seeGrid_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.seeGrid_btn.Location = new System.Drawing.Point(60, 268);
            this.seeGrid_btn.Name = "seeGrid_btn";
            this.seeGrid_btn.Size = new System.Drawing.Size(150, 29);
            this.seeGrid_btn.TabIndex = 2;
            this.seeGrid_btn.Text = "Ver Plano en Desarrollo";
            this.seeGrid_btn.UseVisualStyleBackColor = true;
            this.seeGrid_btn.Click += new System.EventHandler(this.SeeGridInProgress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Planos en desarrollo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(332, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Planos Firmados y aprobados para construccion:";
            // 
            // signedGrids_btn
            // 
            this.signedGrids_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signedGrids_btn.Location = new System.Drawing.Point(357, 268);
            this.signedGrids_btn.Name = "signedGrids_btn";
            this.signedGrids_btn.Size = new System.Drawing.Size(150, 29);
            this.signedGrids_btn.TabIndex = 5;
            this.signedGrids_btn.Text = "Ver Plano Firmado";
            this.signedGrids_btn.UseVisualStyleBackColor = true;
            this.signedGrids_btn.Click += new System.EventHandler(this.SeeSignedGrids);
            // 
            // signedGrids_list
            // 
            this.signedGrids_list.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signedGrids_list.FormattingEnabled = true;
            this.signedGrids_list.Location = new System.Drawing.Point(335, 75);
            this.signedGrids_list.Name = "signedGrids_list";
            this.signedGrids_list.Size = new System.Drawing.Size(187, 173);
            this.signedGrids_list.TabIndex = 4;
            // 
            // MyAccountOwnedGrids
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.signedGrids_btn);
            this.Controls.Add(this.signedGrids_list);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.seeGrid_btn);
            this.Controls.Add(this.ownedGridlist);
            this.Controls.Add(this.titleTxt);
            this.Name = "MyAccountOwnedGrids";
            this.Size = new System.Drawing.Size(583, 341);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleTxt;
        private System.Windows.Forms.ListBox ownedGridlist;
        private System.Windows.Forms.Button seeGrid_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button signedGrids_btn;
        private System.Windows.Forms.ListBox signedGrids_list;
    }
}
