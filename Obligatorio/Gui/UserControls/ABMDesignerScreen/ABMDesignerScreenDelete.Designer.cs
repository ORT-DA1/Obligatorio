namespace Gui.UserControls.ABMDesignerScreen
{
    partial class ABMDesignerScreenDelete
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
            this.deleteDesigner_btn = new System.Windows.Forms.Button();
            this.titleTxt = new System.Windows.Forms.Label();
            this.designerList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // deleteDesigner_btn
            // 
            this.deleteDesigner_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteDesigner_btn.Location = new System.Drawing.Point(250, 277);
            this.deleteDesigner_btn.Name = "deleteDesigner_btn";
            this.deleteDesigner_btn.Size = new System.Drawing.Size(94, 28);
            this.deleteDesigner_btn.TabIndex = 5;
            this.deleteDesigner_btn.Text = "Borrar";
            this.deleteDesigner_btn.UseVisualStyleBackColor = true;
            this.deleteDesigner_btn.Click += new System.EventHandler(this.deleteDesigner);
            // 
            // titleTxt
            // 
            this.titleTxt.AutoSize = true;
            this.titleTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTxt.Location = new System.Drawing.Point(87, 29);
            this.titleTxt.Name = "titleTxt";
            this.titleTxt.Size = new System.Drawing.Size(38, 20);
            this.titleTxt.TabIndex = 4;
            this.titleTxt.Text = "Title";
            // 
            // designerList
            // 
            this.designerList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.designerList.FormattingEnabled = true;
            this.designerList.Location = new System.Drawing.Point(206, 63);
            this.designerList.Name = "designerList";
            this.designerList.Size = new System.Drawing.Size(168, 199);
            this.designerList.TabIndex = 3;
            // 
            // ABMDesignerScreenDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.deleteDesigner_btn);
            this.Controls.Add(this.titleTxt);
            this.Controls.Add(this.designerList);
            this.Name = "ABMDesignerScreenDelete";
            this.Size = new System.Drawing.Size(443, 348);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deleteDesigner_btn;
        private System.Windows.Forms.Label titleTxt;
        private System.Windows.Forms.ListBox designerList;
    }
}
