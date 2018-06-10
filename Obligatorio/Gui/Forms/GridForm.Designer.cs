namespace Gui.Forms
{
    partial class GridForm
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
            this.totalConstructionCostlbl = new System.Windows.Forms.Label();
            this.costLbl = new System.Windows.Forms.Label();
            this.moneyLbl = new System.Windows.Forms.Label();
            this.back_btn = new System.Windows.Forms.Button();
            this.addDecorativeColumnBtn = new System.Windows.Forms.Button();
            this.deleteDecorativeColumnBtn = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridPanel
            // 
            this.gridPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gridPanel.Location = new System.Drawing.Point(288, 12);
            this.gridPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridPanel.Name = "gridPanel";
            this.gridPanel.Size = new System.Drawing.Size(763, 529);
            this.gridPanel.TabIndex = 0;
            this.gridPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.generateLines);
            this.gridPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gridPanel_MouseClick);
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuPanel.Location = new System.Drawing.Point(12, 12);
            this.menuPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(269, 321);
            this.menuPanel.TabIndex = 1;
            // 
            // deleteDoorBtn
            // 
            this.deleteDoorBtn.Location = new System.Drawing.Point(3, 202);
            this.deleteDoorBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteDoorBtn.Name = "deleteDoorBtn";
            this.deleteDoorBtn.Size = new System.Drawing.Size(264, 37);
            this.deleteDoorBtn.TabIndex = 5;
            this.deleteDoorBtn.Text = "Quitar Puerta";
            this.deleteDoorBtn.UseVisualStyleBackColor = true;
            // 
            // deleteWindowBtn
            // 
            this.deleteWindowBtn.Location = new System.Drawing.Point(3, 161);
            this.deleteWindowBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteWindowBtn.Name = "deleteWindowBtn";
            this.deleteWindowBtn.Size = new System.Drawing.Size(264, 37);
            this.deleteWindowBtn.TabIndex = 4;
            this.deleteWindowBtn.Text = "Quitar Ventana";
            this.deleteWindowBtn.UseVisualStyleBackColor = true;
            // 
            // deleteWallBtn
            // 
            this.deleteWallBtn.Location = new System.Drawing.Point(3, 123);
            this.deleteWallBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteWallBtn.Name = "deleteWallBtn";
            this.deleteWallBtn.Size = new System.Drawing.Size(264, 34);
            this.deleteWallBtn.TabIndex = 3;
            this.deleteWallBtn.Text = "Quitar Pared";
            this.deleteWallBtn.UseVisualStyleBackColor = true;
            // 
            // doorBtn
            // 
            this.doorBtn.Location = new System.Drawing.Point(3, 83);
            this.doorBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.doorBtn.Name = "doorBtn";
            this.doorBtn.Size = new System.Drawing.Size(264, 36);
            this.doorBtn.TabIndex = 2;
            this.doorBtn.Text = "Agregar Puerta";
            this.doorBtn.UseVisualStyleBackColor = true;
            // 
            // windowBtn
            // 
            this.windowBtn.Location = new System.Drawing.Point(3, 43);
            this.windowBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.windowBtn.Name = "windowBtn";
            this.windowBtn.Size = new System.Drawing.Size(264, 36);
            this.windowBtn.TabIndex = 1;
            this.windowBtn.Text = "Agregar Ventana";
            this.windowBtn.UseVisualStyleBackColor = true;
            // 
            // wallBtn
            // 
            this.wallBtn.Location = new System.Drawing.Point(3, 2);
            this.wallBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.wallBtn.Name = "wallBtn";
            this.wallBtn.Size = new System.Drawing.Size(264, 37);
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
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(271, 321);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // finishDesignBtn
            // 
            this.finishDesignBtn.Location = new System.Drawing.Point(3, 243);
            this.finishDesignBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.finishDesignBtn.Name = "finishDesignBtn";
            this.finishDesignBtn.Size = new System.Drawing.Size(264, 73);
            this.finishDesignBtn.TabIndex = 6;
            this.finishDesignBtn.Text = "Finalizar y Guardar Diseño";
            this.finishDesignBtn.UseVisualStyleBackColor = true;
            // 
            // totalConstructionCostlbl
            // 
            this.totalConstructionCostlbl.AutoSize = true;
            this.totalConstructionCostlbl.Location = new System.Drawing.Point(5, 353);
            this.totalConstructionCostlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalConstructionCostlbl.Name = "totalConstructionCostlbl";
            this.totalConstructionCostlbl.Size = new System.Drawing.Size(190, 17);
            this.totalConstructionCostlbl.TabIndex = 7;
            this.totalConstructionCostlbl.Text = "Costo Total de Construccion:";
            // 
            // costLbl
            // 
            this.costLbl.AutoSize = true;
            this.costLbl.Location = new System.Drawing.Point(207, 353);
            this.costLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.costLbl.Name = "costLbl";
            this.costLbl.Size = new System.Drawing.Size(24, 17);
            this.costLbl.TabIndex = 8;
            this.costLbl.Text = "$$";
            // 
            // moneyLbl
            // 
            this.moneyLbl.AutoSize = true;
            this.moneyLbl.Location = new System.Drawing.Point(259, 353);
            this.moneyLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.moneyLbl.Name = "moneyLbl";
            this.moneyLbl.Size = new System.Drawing.Size(24, 17);
            this.moneyLbl.TabIndex = 9;
            this.moneyLbl.Text = "$$";
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(9, 393);
            this.back_btn.Margin = new System.Windows.Forms.Padding(4);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(269, 34);
            this.back_btn.TabIndex = 10;
            this.back_btn.Text = "Volver";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // addDecorativeColumnBtn
            // 
            this.addDecorativeColumnBtn.Location = new System.Drawing.Point(9, 462);
            this.addDecorativeColumnBtn.Name = "addDecorativeColumnBtn";
            this.addDecorativeColumnBtn.Size = new System.Drawing.Size(269, 23);
            this.addDecorativeColumnBtn.TabIndex = 11;
            this.addDecorativeColumnBtn.Text = "Agregar Pared Decorativa";
            this.addDecorativeColumnBtn.UseVisualStyleBackColor = true;
            // 
            // deleteDecorativeColumnBtn
            // 
            this.deleteDecorativeColumnBtn.Location = new System.Drawing.Point(8, 504);
            this.deleteDecorativeColumnBtn.Name = "deleteDecorativeColumnBtn";
            this.deleteDecorativeColumnBtn.Size = new System.Drawing.Size(270, 23);
            this.deleteDecorativeColumnBtn.TabIndex = 12;
            this.deleteDecorativeColumnBtn.Text = "Quitar Pared Decorativa";
            this.deleteDecorativeColumnBtn.UseVisualStyleBackColor = true;
            // 
            // GridForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1028, 553);
            this.Controls.Add(this.deleteDecorativeColumnBtn);
            this.Controls.Add(this.addDecorativeColumnBtn);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.moneyLbl);
            this.Controls.Add(this.costLbl);
            this.Controls.Add(this.totalConstructionCostlbl);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.gridPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GridForm";
            this.Text = "Grid";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label totalConstructionCostlbl;
        private System.Windows.Forms.Label costLbl;
        private System.Windows.Forms.Label moneyLbl;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Button addDecorativeColumnBtn;
        private System.Windows.Forms.Button deleteDecorativeColumnBtn;
    }
}