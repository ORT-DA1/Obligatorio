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
            this.SuspendLayout();
            // 
            // clientList
            // 
            this.clientList.FormattingEnabled = true;
            this.clientList.Location = new System.Drawing.Point(41, 49);
            this.clientList.Name = "clientList";
            this.clientList.Size = new System.Drawing.Size(170, 238);
            this.clientList.TabIndex = 0;
            // 
            // titleTxt
            // 
            this.titleTxt.AutoSize = true;
            this.titleTxt.Location = new System.Drawing.Point(38, 15);
            this.titleTxt.Name = "titleTxt";
            this.titleTxt.Size = new System.Drawing.Size(0, 13);
            this.titleTxt.TabIndex = 1;
            // 
            // ABMClientScreenModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.titleTxt);
            this.Controls.Add(this.clientList);
            this.Name = "ABMClientScreenModify";
            this.Size = new System.Drawing.Size(435, 329);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox clientList;
        private System.Windows.Forms.Label titleTxt;
    }
}
