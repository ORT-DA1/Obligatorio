namespace Gui.Forms
{
    partial class Grid
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridPanel = new System.Windows.Forms.Panel();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.quitarVentanaBtn = new System.Windows.Forms.Button();
            this.quitarPuertaBtn = new System.Windows.Forms.Button();
            this.quitarParedBtn = new System.Windows.Forms.Button();
            this.puertaBtn = new System.Windows.Forms.Button();
            this.ventanaBtn = new System.Windows.Forms.Button();
            this.paredBtn = new System.Windows.Forms.Button();
            this.menuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridPanel
            // 
            this.gridPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gridPanel.Location = new System.Drawing.Point(288, 12);
            this.gridPanel.Name = "gridPanel";
            this.gridPanel.Size = new System.Drawing.Size(762, 529);
            this.gridPanel.TabIndex = 0;
            this.gridPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.generateLines);
            this.gridPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gridPanel_MouseClick);
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuPanel.Controls.Add(this.quitarVentanaBtn);
            this.menuPanel.Controls.Add(this.quitarPuertaBtn);
            this.menuPanel.Controls.Add(this.quitarParedBtn);
            this.menuPanel.Controls.Add(this.puertaBtn);
            this.menuPanel.Controls.Add(this.ventanaBtn);
            this.menuPanel.Controls.Add(this.paredBtn);
            this.menuPanel.Location = new System.Drawing.Point(12, 12);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(270, 529);
            this.menuPanel.TabIndex = 1;
            // 
            // quitarVentanaBtn
            // 
            this.quitarVentanaBtn.Location = new System.Drawing.Point(38, 392);
            this.quitarVentanaBtn.Name = "quitarVentanaBtn";
            this.quitarVentanaBtn.Size = new System.Drawing.Size(75, 23);
            this.quitarVentanaBtn.TabIndex = 5;
            this.quitarVentanaBtn.Text = "button6";
            this.quitarVentanaBtn.UseVisualStyleBackColor = true;
            // 
            // quitarPuertaBtn
            // 
            this.quitarPuertaBtn.Location = new System.Drawing.Point(51, 318);
            this.quitarPuertaBtn.Name = "quitarPuertaBtn";
            this.quitarPuertaBtn.Size = new System.Drawing.Size(75, 23);
            this.quitarPuertaBtn.TabIndex = 4;
            this.quitarPuertaBtn.Text = "button5";
            this.quitarPuertaBtn.UseVisualStyleBackColor = true;
            // 
            // quitarParedBtn
            // 
            this.quitarParedBtn.Location = new System.Drawing.Point(51, 270);
            this.quitarParedBtn.Name = "quitarParedBtn";
            this.quitarParedBtn.Size = new System.Drawing.Size(75, 23);
            this.quitarParedBtn.TabIndex = 3;
            this.quitarParedBtn.Text = "button4";
            this.quitarParedBtn.UseVisualStyleBackColor = true;
            // 
            // puertaBtn
            // 
            this.puertaBtn.Location = new System.Drawing.Point(51, 185);
            this.puertaBtn.Name = "puertaBtn";
            this.puertaBtn.Size = new System.Drawing.Size(75, 23);
            this.puertaBtn.TabIndex = 2;
            this.puertaBtn.Text = "button3";
            this.puertaBtn.UseVisualStyleBackColor = true;
            // 
            // ventanaBtn
            // 
            this.ventanaBtn.Location = new System.Drawing.Point(39, 114);
            this.ventanaBtn.Name = "ventanaBtn";
            this.ventanaBtn.Size = new System.Drawing.Size(75, 23);
            this.ventanaBtn.TabIndex = 1;
            this.ventanaBtn.Text = "button2";
            this.ventanaBtn.UseVisualStyleBackColor = true;
            // 
            // paredBtn
            // 
            this.paredBtn.Location = new System.Drawing.Point(39, 40);
            this.paredBtn.Name = "paredBtn";
            this.paredBtn.Size = new System.Drawing.Size(75, 23);
            this.paredBtn.TabIndex = 0;
            this.paredBtn.Text = "button1";
            this.paredBtn.UseVisualStyleBackColor = true;
            // 
            // GridForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1062, 553);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.gridPanel);
            this.Name = "GridForm";
            this.Text = "Grid";
            this.menuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel gridPanel;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Button quitarParedBtn;
        private System.Windows.Forms.Button puertaBtn;
        private System.Windows.Forms.Button ventanaBtn;
        private System.Windows.Forms.Button paredBtn;
        private System.Windows.Forms.Button quitarVentanaBtn;
        private System.Windows.Forms.Button quitarPuertaBtn;
    }
}