namespace Gui.UserControls.ABMArchitectScreen
{
    partial class ABMArchitectScreenDelete
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
            this.label1 = new System.Windows.Forms.Label();
            this.deleteArchitect_btn = new System.Windows.Forms.Button();
            this.titleTxt = new System.Windows.Forms.Label();
            this.architectList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Seleccione el Arquitecto que desea borrar:";
            // 
            // deleteArchitect_btn
            // 
            this.deleteArchitect_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteArchitect_btn.Location = new System.Drawing.Point(274, 257);
            this.deleteArchitect_btn.Name = "deleteArchitect_btn";
            this.deleteArchitect_btn.Size = new System.Drawing.Size(94, 28);
            this.deleteArchitect_btn.TabIndex = 10;
            this.deleteArchitect_btn.Text = "Borrar";
            this.deleteArchitect_btn.UseVisualStyleBackColor = true;
            this.deleteArchitect_btn.Click += new System.EventHandler(this.deleteArchitect);
            // 
            // titleTxt
            // 
            this.titleTxt.AutoSize = true;
            this.titleTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTxt.Location = new System.Drawing.Point(12, 16);
            this.titleTxt.Name = "titleTxt";
            this.titleTxt.Size = new System.Drawing.Size(38, 20);
            this.titleTxt.TabIndex = 9;
            this.titleTxt.Text = "Title";
            // 
            // architectList
            // 
            this.architectList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.architectList.FormattingEnabled = true;
            this.architectList.Location = new System.Drawing.Point(230, 43);
            this.architectList.Name = "architectList";
            this.architectList.Size = new System.Drawing.Size(168, 199);
            this.architectList.TabIndex = 8;
            // 
            // ABMArchitectScreenDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteArchitect_btn);
            this.Controls.Add(this.titleTxt);
            this.Controls.Add(this.architectList);
            this.Name = "ABMArchitectScreenDelete";
            this.Size = new System.Drawing.Size(439, 314);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deleteArchitect_btn;
        private System.Windows.Forms.Label titleTxt;
        private System.Windows.Forms.ListBox architectList;
    }
}
