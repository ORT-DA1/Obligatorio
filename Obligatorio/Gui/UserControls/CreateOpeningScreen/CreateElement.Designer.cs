namespace Gui.UserControls.CreateOpeningScreen
{
    partial class CreateElement
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.createElementBtn = new System.Windows.Forms.Button();
            this.nameLbl = new System.Windows.Forms.Label();
            this.widthLbl = new System.Windows.Forms.Label();
            this.highFromGroundLbl = new System.Windows.Forms.Label();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.widthTextBox = new System.Windows.Forms.TextBox();
            this.typeLbl = new System.Windows.Forms.Label();
            this.highFromGroundTextBox = new System.Windows.Forms.TextBox();
            this.highLbl = new System.Windows.Forms.Label();
            this.highTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // createElementBtn
            // 
            this.createElementBtn.Location = new System.Drawing.Point(95, 282);
            this.createElementBtn.Name = "createElementBtn";
            this.createElementBtn.Size = new System.Drawing.Size(121, 23);
            this.createElementBtn.TabIndex = 0;
            this.createElementBtn.Text = "Crear Elemento";
            this.createElementBtn.UseVisualStyleBackColor = true;
            this.createElementBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.createElementBtn_MouseClick);
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(44, 123);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(58, 17);
            this.nameLbl.TabIndex = 1;
            this.nameLbl.Text = "Nombre";
            // 
            // widthLbl
            // 
            this.widthLbl.AutoSize = true;
            this.widthLbl.Location = new System.Drawing.Point(44, 155);
            this.widthLbl.Name = "widthLbl";
            this.widthLbl.Size = new System.Drawing.Size(48, 17);
            this.widthLbl.TabIndex = 2;
            this.widthLbl.Text = "Ancho";
            // 
            // highFromGroundLbl
            // 
            this.highFromGroundLbl.AutoSize = true;
            this.highFromGroundLbl.Location = new System.Drawing.Point(44, 241);
            this.highFromGroundLbl.Name = "highFromGroundLbl";
            this.highFromGroundLbl.Size = new System.Drawing.Size(118, 17);
            this.highFromGroundLbl.TabIndex = 3;
            this.highFromGroundLbl.Text = "Altura desde piso";
            // 
            // typeComboBox
            // 
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Items.AddRange(new object[] {
            "Puerta",
            "Ventana"});
            this.typeComboBox.Location = new System.Drawing.Point(116, 205);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(121, 24);
            this.typeComboBox.TabIndex = 4;
            this.typeComboBox.SelectedValueChanged += new System.EventHandler(this.typeComboBox_SelectedValueChanged);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(116, 123);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 22);
            this.nameTextBox.TabIndex = 5;
            // 
            // widthTextBox
            // 
            this.widthTextBox.Location = new System.Drawing.Point(116, 149);
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.Size = new System.Drawing.Size(100, 22);
            this.widthTextBox.TabIndex = 6;
            // 
            // typeLbl
            // 
            this.typeLbl.AutoSize = true;
            this.typeLbl.Location = new System.Drawing.Point(44, 208);
            this.typeLbl.Name = "typeLbl";
            this.typeLbl.Size = new System.Drawing.Size(36, 17);
            this.typeLbl.TabIndex = 7;
            this.typeLbl.Text = "Tipo";
            // 
            // highFromGroundTextBox
            // 
            this.highFromGroundTextBox.Location = new System.Drawing.Point(168, 242);
            this.highFromGroundTextBox.Name = "highFromGroundTextBox";
            this.highFromGroundTextBox.Size = new System.Drawing.Size(100, 22);
            this.highFromGroundTextBox.TabIndex = 8;
            // 
            // highLbl
            // 
            this.highLbl.AutoSize = true;
            this.highLbl.Location = new System.Drawing.Point(44, 181);
            this.highLbl.Name = "highLbl";
            this.highLbl.Size = new System.Drawing.Size(32, 17);
            this.highLbl.TabIndex = 9;
            this.highLbl.Text = "Alto";
            // 
            // highTextBox
            // 
            this.highTextBox.Location = new System.Drawing.Point(116, 178);
            this.highTextBox.Name = "highTextBox";
            this.highTextBox.Size = new System.Drawing.Size(100, 22);
            this.highTextBox.TabIndex = 10;
            // 
            // CreateElement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.highTextBox);
            this.Controls.Add(this.highLbl);
            this.Controls.Add(this.highFromGroundTextBox);
            this.Controls.Add(this.typeLbl);
            this.Controls.Add(this.widthTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.highFromGroundLbl);
            this.Controls.Add(this.widthLbl);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.createElementBtn);
            this.Name = "CreateElement";
            this.Size = new System.Drawing.Size(311, 332);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createElementBtn;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label widthLbl;
        private System.Windows.Forms.Label highFromGroundLbl;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox widthTextBox;
        private System.Windows.Forms.Label typeLbl;
        private System.Windows.Forms.TextBox highFromGroundTextBox;
        private System.Windows.Forms.Label highLbl;
        private System.Windows.Forms.TextBox highTextBox;
    }
}
