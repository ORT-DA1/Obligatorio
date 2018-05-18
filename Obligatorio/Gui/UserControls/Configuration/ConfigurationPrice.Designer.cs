namespace Gui.UserControls.Configuration
{
    partial class ConfigurationPrice
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
            this.elementList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CostTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.priceConfig_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleTxt
            // 
            this.titleTxt.AutoSize = true;
            this.titleTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTxt.Location = new System.Drawing.Point(43, 28);
            this.titleTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleTxt.Name = "titleTxt";
            this.titleTxt.Size = new System.Drawing.Size(49, 25);
            this.titleTxt.TabIndex = 0;
            this.titleTxt.Text = "Title";
            // 
            // elementList
            // 
            this.elementList.FormattingEnabled = true;
            this.elementList.Items.AddRange(new object[] {
            "Pared",
            "Viga",
            "Ventana",
            "Puerta"});
            this.elementList.Location = new System.Drawing.Point(324, 86);
            this.elementList.Margin = new System.Windows.Forms.Padding(4);
            this.elementList.Name = "elementList";
            this.elementList.Size = new System.Drawing.Size(187, 24);
            this.elementList.TabIndex = 1;
            this.elementList.SelectedIndexChanged += new System.EventHandler(this.setUpEnvironment);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccione una abertura:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 165);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Costo:";
            // 
            // CostTextBox
            // 
            this.CostTextBox.Location = new System.Drawing.Point(323, 161);
            this.CostTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.Size = new System.Drawing.Size(44, 22);
            this.CostTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(371, 170);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "$";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(531, 170);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "$";
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(483, 161);
            this.PriceTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(44, 22);
            this.PriceTextBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(421, 165);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Precio:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(396, 159);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 29);
            this.label6.TabIndex = 9;
            this.label6.Text = "/";
            // 
            // priceConfig_btn
            // 
            this.priceConfig_btn.Location = new System.Drawing.Point(351, 229);
            this.priceConfig_btn.Margin = new System.Windows.Forms.Padding(4);
            this.priceConfig_btn.Name = "priceConfig_btn";
            this.priceConfig_btn.Size = new System.Drawing.Size(136, 39);
            this.priceConfig_btn.TabIndex = 10;
            this.priceConfig_btn.Text = "Guardar";
            this.priceConfig_btn.UseVisualStyleBackColor = true;
            this.priceConfig_btn.Click += new System.EventHandler(this.savePriceConfiguration);
            // 
            // ConfigurationPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.priceConfig_btn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CostTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.elementList);
            this.Controls.Add(this.titleTxt);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ConfigurationPrice";
            this.Size = new System.Drawing.Size(636, 306);
            this.Leave += new System.EventHandler(this.leaveComponent);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleTxt;
        private System.Windows.Forms.ComboBox elementList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CostTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button priceConfig_btn;
    }
}
