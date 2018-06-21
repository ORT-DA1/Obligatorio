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
            this.drawGridButtonPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.finishDesignBtn = new System.Windows.Forms.Button();
            this.totalConstructionCostlbl = new System.Windows.Forms.Label();
            this.costLbl = new System.Windows.Forms.Label();
            this.moneyLbl = new System.Windows.Forms.Label();
            this.back_btn = new System.Windows.Forms.Button();
            this.addDecorativeColumnBtn = new System.Windows.Forms.Button();
            this.deleteDecorativeColumnBtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.signatureList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.createNewOpening = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.newOpeningBtn = new System.Windows.Forms.Button();
            this.selectOpeningLbl = new System.Windows.Forms.Label();
            this.selectGridTypeLbl = new System.Windows.Forms.Label();
            this.elementPanel = new System.Windows.Forms.Panel();
            this.drawGridButtonPanel.SuspendLayout();
            this.elementPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridPanel
            // 
            this.gridPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gridPanel.Location = new System.Drawing.Point(216, 10);
            this.gridPanel.Margin = new System.Windows.Forms.Padding(2);
            this.gridPanel.Name = "gridPanel";
            this.gridPanel.Size = new System.Drawing.Size(492, 430);
            this.gridPanel.TabIndex = 0;
            this.gridPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.generateLines);
            this.gridPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gridPanel_MouseClick);
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuPanel.Location = new System.Drawing.Point(9, 10);
            this.menuPanel.Margin = new System.Windows.Forms.Padding(2);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(202, 261);
            this.menuPanel.TabIndex = 1;
            // 
            // deleteDoorBtn
            // 
            this.deleteDoorBtn.Location = new System.Drawing.Point(2, 168);
            this.deleteDoorBtn.Margin = new System.Windows.Forms.Padding(2);
            this.deleteDoorBtn.Name = "deleteDoorBtn";
            this.deleteDoorBtn.Size = new System.Drawing.Size(198, 30);
            this.deleteDoorBtn.TabIndex = 5;
            this.deleteDoorBtn.Text = "Quitar Puerta";
            this.deleteDoorBtn.UseVisualStyleBackColor = true;
            // 
            // deleteWindowBtn
            // 
            this.deleteWindowBtn.Location = new System.Drawing.Point(2, 134);
            this.deleteWindowBtn.Margin = new System.Windows.Forms.Padding(2);
            this.deleteWindowBtn.Name = "deleteWindowBtn";
            this.deleteWindowBtn.Size = new System.Drawing.Size(198, 30);
            this.deleteWindowBtn.TabIndex = 4;
            this.deleteWindowBtn.Text = "Quitar Ventana";
            this.deleteWindowBtn.UseVisualStyleBackColor = true;
            // 
            // deleteWallBtn
            // 
            this.deleteWallBtn.Location = new System.Drawing.Point(2, 102);
            this.deleteWallBtn.Margin = new System.Windows.Forms.Padding(2);
            this.deleteWallBtn.Name = "deleteWallBtn";
            this.deleteWallBtn.Size = new System.Drawing.Size(198, 28);
            this.deleteWallBtn.TabIndex = 3;
            this.deleteWallBtn.Text = "Quitar Pared";
            this.deleteWallBtn.UseVisualStyleBackColor = true;
            // 
            // doorBtn
            // 
            this.doorBtn.Location = new System.Drawing.Point(2, 69);
            this.doorBtn.Margin = new System.Windows.Forms.Padding(2);
            this.doorBtn.Name = "doorBtn";
            this.doorBtn.Size = new System.Drawing.Size(198, 29);
            this.doorBtn.TabIndex = 2;
            this.doorBtn.Text = "Agregar Ventana";
            this.doorBtn.UseVisualStyleBackColor = true;
            // 
            // windowBtn
            // 
            this.windowBtn.Location = new System.Drawing.Point(2, 36);
            this.windowBtn.Margin = new System.Windows.Forms.Padding(2);
            this.windowBtn.Name = "windowBtn";
            this.windowBtn.Size = new System.Drawing.Size(198, 29);
            this.windowBtn.TabIndex = 1;
            this.windowBtn.Text = "Agregar Puerta";
            this.windowBtn.UseVisualStyleBackColor = true;
            // 
            // wallBtn
            // 
            this.wallBtn.Location = new System.Drawing.Point(2, 2);
            this.wallBtn.Margin = new System.Windows.Forms.Padding(2);
            this.wallBtn.Name = "wallBtn";
            this.wallBtn.Size = new System.Drawing.Size(198, 30);
            this.wallBtn.TabIndex = 0;
            this.wallBtn.Text = "Agregar Pared";
            this.wallBtn.UseVisualStyleBackColor = true;
            // 
            // drawGridButtonPanel
            // 
            this.drawGridButtonPanel.Controls.Add(this.wallBtn);
            this.drawGridButtonPanel.Controls.Add(this.windowBtn);
            this.drawGridButtonPanel.Controls.Add(this.doorBtn);
            this.drawGridButtonPanel.Controls.Add(this.deleteWallBtn);
            this.drawGridButtonPanel.Controls.Add(this.deleteWindowBtn);
            this.drawGridButtonPanel.Controls.Add(this.deleteDoorBtn);
            this.drawGridButtonPanel.Controls.Add(this.finishDesignBtn);
            this.drawGridButtonPanel.Location = new System.Drawing.Point(9, 10);
            this.drawGridButtonPanel.Margin = new System.Windows.Forms.Padding(2);
            this.drawGridButtonPanel.Name = "drawGridButtonPanel";
            this.drawGridButtonPanel.Size = new System.Drawing.Size(203, 261);
            this.drawGridButtonPanel.TabIndex = 6;
            // 
            // finishDesignBtn
            // 
            this.finishDesignBtn.Location = new System.Drawing.Point(2, 202);
            this.finishDesignBtn.Margin = new System.Windows.Forms.Padding(2);
            this.finishDesignBtn.Name = "finishDesignBtn";
            this.finishDesignBtn.Size = new System.Drawing.Size(198, 59);
            this.finishDesignBtn.TabIndex = 6;
            this.finishDesignBtn.Text = "Finalizar y Guardar Diseño";
            this.finishDesignBtn.UseVisualStyleBackColor = true;
            // 
            // totalConstructionCostlbl
            // 
            this.totalConstructionCostlbl.AutoSize = true;
            this.totalConstructionCostlbl.Location = new System.Drawing.Point(4, 287);
            this.totalConstructionCostlbl.Name = "totalConstructionCostlbl";
            this.totalConstructionCostlbl.Size = new System.Drawing.Size(144, 13);
            this.totalConstructionCostlbl.TabIndex = 7;
            this.totalConstructionCostlbl.Text = "Costo Total de Construccion:";
            // 
            // costLbl
            // 
            this.costLbl.AutoSize = true;
            this.costLbl.Location = new System.Drawing.Point(155, 287);
            this.costLbl.Name = "costLbl";
            this.costLbl.Size = new System.Drawing.Size(19, 13);
            this.costLbl.TabIndex = 8;
            this.costLbl.Text = "$$";
            // 
            // moneyLbl
            // 
            this.moneyLbl.AutoSize = true;
            this.moneyLbl.Location = new System.Drawing.Point(194, 287);
            this.moneyLbl.Name = "moneyLbl";
            this.moneyLbl.Size = new System.Drawing.Size(19, 13);
            this.moneyLbl.TabIndex = 9;
            this.moneyLbl.Text = "$$";
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(7, 319);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(202, 28);
            this.back_btn.TabIndex = 10;
            this.back_btn.Text = "Volver";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // addDecorativeColumnBtn
            // 
            this.addDecorativeColumnBtn.Location = new System.Drawing.Point(6, 397);
            this.addDecorativeColumnBtn.Margin = new System.Windows.Forms.Padding(2);
            this.addDecorativeColumnBtn.Name = "addDecorativeColumnBtn";
            this.addDecorativeColumnBtn.Size = new System.Drawing.Size(202, 19);
            this.addDecorativeColumnBtn.TabIndex = 11;
            this.addDecorativeColumnBtn.Text = "Agregar Columna Decorativa";
            this.addDecorativeColumnBtn.UseVisualStyleBackColor = true;
            // 
            // deleteDecorativeColumnBtn
            // 
            this.deleteDecorativeColumnBtn.Location = new System.Drawing.Point(6, 421);
            this.deleteDecorativeColumnBtn.Margin = new System.Windows.Forms.Padding(2);
            this.deleteDecorativeColumnBtn.Name = "deleteDecorativeColumnBtn";
            this.deleteDecorativeColumnBtn.Size = new System.Drawing.Size(202, 19);
            this.deleteDecorativeColumnBtn.TabIndex = 12;
            this.deleteDecorativeColumnBtn.Text = "Quitar Columna Decorativa";
            this.deleteDecorativeColumnBtn.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Grilla de líneas completas",
            "Grilla de líneas punteadas",
            "Sin grilla visual"});
            this.comboBox1.Location = new System.Drawing.Point(8, 373);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // signatureList
            // 
            this.signatureList.FormattingEnabled = true;
            this.signatureList.Location = new System.Drawing.Point(725, 264);
            this.signatureList.Name = "signatureList";
            this.signatureList.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.signatureList.Size = new System.Drawing.Size(256, 173);
            this.signatureList.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(722, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Firma de Arquitectos:";
            // 
            // createNewOpening
            // 
            this.createNewOpening.Location = new System.Drawing.Point(28, 29);
            this.createNewOpening.Margin = new System.Windows.Forms.Padding(2);
            this.createNewOpening.Name = "createNewOpening";
            this.createNewOpening.Size = new System.Drawing.Size(178, 30);
            this.createNewOpening.TabIndex = 16;
            this.createNewOpening.Text = "Crear nueva Abertura";
            this.createNewOpening.UseVisualStyleBackColor = true;
            this.createNewOpening.Click += new System.EventHandler(this.createNewOpening_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(28, 102);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(178, 21);
            this.comboBox2.TabIndex = 17;
            // 
            // newOpeningBtn
            // 
            this.newOpeningBtn.Location = new System.Drawing.Point(28, 126);
            this.newOpeningBtn.Margin = new System.Windows.Forms.Padding(2);
            this.newOpeningBtn.Name = "newOpeningBtn";
            this.newOpeningBtn.Size = new System.Drawing.Size(177, 29);
            this.newOpeningBtn.TabIndex = 18;
            this.newOpeningBtn.Text = "Agregar nueva Abertura";
            this.newOpeningBtn.UseVisualStyleBackColor = true;
            // 
            // selectOpeningLbl
            // 
            this.selectOpeningLbl.AutoSize = true;
            this.selectOpeningLbl.Location = new System.Drawing.Point(40, 85);
            this.selectOpeningLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.selectOpeningLbl.Name = "selectOpeningLbl";
            this.selectOpeningLbl.Size = new System.Drawing.Size(156, 13);
            this.selectOpeningLbl.TabIndex = 19;
            this.selectOpeningLbl.Text = "Seleccione una nueva abertura";
            // 
            // selectGridTypeLbl
            // 
            this.selectGridTypeLbl.AutoSize = true;
            this.selectGridTypeLbl.Location = new System.Drawing.Point(44, 358);
            this.selectGridTypeLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.selectGridTypeLbl.Name = "selectGridTypeLbl";
            this.selectGridTypeLbl.Size = new System.Drawing.Size(130, 13);
            this.selectGridTypeLbl.TabIndex = 20;
            this.selectGridTypeLbl.Text = "Seleccione el tipo de grilla";
            // 
            // elementPanel
            // 
            this.elementPanel.Controls.Add(this.selectOpeningLbl);
            this.elementPanel.Controls.Add(this.newOpeningBtn);
            this.elementPanel.Controls.Add(this.comboBox2);
            this.elementPanel.Controls.Add(this.createNewOpening);
            this.elementPanel.Location = new System.Drawing.Point(732, 17);
            this.elementPanel.Name = "elementPanel";
            this.elementPanel.Size = new System.Drawing.Size(234, 204);
            this.elementPanel.TabIndex = 21;
            this.elementPanel.Visible = false;
            // 
            // GridForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(993, 449);
            this.Controls.Add(this.elementPanel);
            this.Controls.Add(this.selectGridTypeLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.signatureList);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.deleteDecorativeColumnBtn);
            this.Controls.Add(this.addDecorativeColumnBtn);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.moneyLbl);
            this.Controls.Add(this.costLbl);
            this.Controls.Add(this.totalConstructionCostlbl);
            this.Controls.Add(this.drawGridButtonPanel);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.gridPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GridForm";
            this.Text = "Grid";
            this.drawGridButtonPanel.ResumeLayout(false);
            this.elementPanel.ResumeLayout(false);
            this.elementPanel.PerformLayout();
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
        private System.Windows.Forms.FlowLayoutPanel drawGridButtonPanel;
        private System.Windows.Forms.Button finishDesignBtn;
        private System.Windows.Forms.Label totalConstructionCostlbl;
        private System.Windows.Forms.Label costLbl;
        private System.Windows.Forms.Label moneyLbl;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Button addDecorativeColumnBtn;
        private System.Windows.Forms.Button deleteDecorativeColumnBtn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox signatureList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button createNewOpening;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button newOpeningBtn;
        private System.Windows.Forms.Label selectOpeningLbl;
        private System.Windows.Forms.Label selectGridTypeLbl;
        private System.Windows.Forms.Panel elementPanel;
    }
}