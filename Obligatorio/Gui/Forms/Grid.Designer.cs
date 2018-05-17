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
            this.deleteDoorBtn = new System.Windows.Forms.Button();
            this.deleteWindowBtn = new System.Windows.Forms.Button();
            this.deleteWallBtn = new System.Windows.Forms.Button();
            this.doorBtn = new System.Windows.Forms.Button();
            this.windowBtn = new System.Windows.Forms.Button();
            this.wallBtn = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.finishDesignBtn = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
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
            this.menuPanel.Location = new System.Drawing.Point(12, 12);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(270, 529);
            this.menuPanel.TabIndex = 1;
            // 
            // deleteDoorBtn
            // 
            this.deleteDoorBtn.Location = new System.Drawing.Point(3, 285);
            this.deleteDoorBtn.Name = "deleteDoorBtn";
            this.deleteDoorBtn.Size = new System.Drawing.Size(264, 50);
            this.deleteDoorBtn.TabIndex = 5;
            this.deleteDoorBtn.Text = "Quitar Puerta";
            this.deleteDoorBtn.UseVisualStyleBackColor = true;
            // 
            // deleteWindowBtn
            // 
            this.deleteWindowBtn.Location = new System.Drawing.Point(3, 235);
            this.deleteWindowBtn.Name = "deleteWindowBtn";
            this.deleteWindowBtn.Size = new System.Drawing.Size(264, 50);
            this.deleteWindowBtn.TabIndex = 4;
            this.deleteWindowBtn.Text = "Quitar Ventana";
            this.deleteWindowBtn.UseVisualStyleBackColor = true;
            // 
            // deleteWallBtn
            // 
            this.deleteWallBtn.Location = new System.Drawing.Point(3, 180);
            this.deleteWallBtn.Name = "deleteWallBtn";
            this.deleteWallBtn.Size = new System.Drawing.Size(264, 50);
            this.deleteWallBtn.TabIndex = 3;
            this.deleteWallBtn.Text = "Quitar Pared";
            this.deleteWallBtn.UseVisualStyleBackColor = true;
            // 
            // doorBtn
            // 
            this.doorBtn.Location = new System.Drawing.Point(3, 122);
            this.doorBtn.Name = "doorBtn";
            this.doorBtn.Size = new System.Drawing.Size(264, 50);
            this.doorBtn.TabIndex = 2;
            this.doorBtn.Text = "Agregar Puerta";
            this.doorBtn.UseVisualStyleBackColor = true;
            // 
            // windowBtn
            // 
            this.windowBtn.Location = new System.Drawing.Point(3, 64);
            this.windowBtn.Name = "windowBtn";
            this.windowBtn.Size = new System.Drawing.Size(264, 50);
            this.windowBtn.TabIndex = 1;
            this.windowBtn.Text = "Agregar Ventana";
            this.windowBtn.UseVisualStyleBackColor = true;
            // 
            // wallBtn
            // 
            this.wallBtn.Location = new System.Drawing.Point(3, 3);
            this.wallBtn.Name = "wallBtn";
            this.wallBtn.Size = new System.Drawing.Size(264, 50);
            this.wallBtn.TabIndex = 0;
            this.wallBtn.Text = "Agregar Pared";
            this.wallBtn.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.wallBtn);
            this.flowLayoutPanel1.Controls.Add(this.windowBtn);
            this.flowLayoutPanel1.Controls.Add(this.doorBtn);
            this.flowLayoutPanel1.Controls.Add(this.deleteWallBtn);
            this.flowLayoutPanel1.Controls.Add(this.deleteWindowBtn);
            this.flowLayoutPanel1.Controls.Add(this.deleteDoorBtn);
            this.flowLayoutPanel1.Controls.Add(this.finishDesignBtn);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(267, 529);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // finishDesignBtn
            // 
            this.finishDesignBtn.Location = new System.Drawing.Point(3, 341);
            this.finishDesignBtn.Name = "finishDesignBtn";
            this.finishDesignBtn.Size = new System.Drawing.Size(264, 185);
            this.finishDesignBtn.TabIndex = 6;
            this.finishDesignBtn.Text = "Finalizar Diseño";
            this.finishDesignBtn.UseVisualStyleBackColor = true;
            // 
            // Grid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1062, 553);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.gridPanel);
            this.Name = "Grid";
            this.Text = "Grid";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel gridPanel;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Button deleteWallBtn;
        private System.Windows.Forms.Button doorBtn;
        private System.Windows.Forms.Button windowBtn;
        private System.Windows.Forms.Button wallBtn;
        private System.Windows.Forms.Button deleteDoorBtn;
        private System.Windows.Forms.Button deleteWindowBtn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button finishDesignBtn;
    }
}