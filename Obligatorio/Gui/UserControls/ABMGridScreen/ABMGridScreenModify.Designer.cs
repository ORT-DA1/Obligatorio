namespace Gui.UserControls.ABMGridScreen
{
    partial class ABMGridScreenModify
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
            this.gridList = new System.Windows.Forms.ListBox();
            this.titleTxt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.modifyGrid_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gridList
            // 
            this.gridList.FormattingEnabled = true;
            this.gridList.Location = new System.Drawing.Point(253, 59);
            this.gridList.Name = "gridList";
            this.gridList.Size = new System.Drawing.Size(165, 225);
            this.gridList.TabIndex = 0;
            // 
            // titleTxt
            // 
            this.titleTxt.AutoSize = true;
            this.titleTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTxt.Location = new System.Drawing.Point(21, 22);
            this.titleTxt.Name = "titleTxt";
            this.titleTxt.Size = new System.Drawing.Size(38, 20);
            this.titleTxt.TabIndex = 1;
            this.titleTxt.Text = "Title";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccione el Plano que desea modificar:";
            // 
            // modifyGrid_btn
            // 
            this.modifyGrid_btn.Location = new System.Drawing.Point(282, 290);
            this.modifyGrid_btn.Name = "modifyGrid_btn";
            this.modifyGrid_btn.Size = new System.Drawing.Size(110, 33);
            this.modifyGrid_btn.TabIndex = 3;
            this.modifyGrid_btn.Text = "Modificar Plano";
            this.modifyGrid_btn.UseVisualStyleBackColor = true;
            this.modifyGrid_btn.Click += new System.EventHandler(this.modifyGrid);
            // 
            // ABMGridScreenModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.modifyGrid_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titleTxt);
            this.Controls.Add(this.gridList);
            this.Name = "ABMGridScreenModify";
            this.Size = new System.Drawing.Size(481, 373);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox gridList;
        private System.Windows.Forms.Label titleTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button modifyGrid_btn;
    }
}
