namespace Gui.Forms
{
    partial class CreateGridForm
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
            this.components = new System.ComponentModel.Container();
            this.gridNameLbl = new System.Windows.Forms.Label();
            this.gridNameTxt = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clientUsernameLbl = new System.Windows.Forms.Label();
            this.widthLbl = new System.Windows.Forms.Label();
            this.heightLbl = new System.Windows.Forms.Label();
            this.createGridBtn = new System.Windows.Forms.Button();
            this.createGridTittleLbl = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.gridPropertiesLbl = new System.Windows.Forms.Label();
            this.heightTxt = new System.Windows.Forms.TextBox();
            this.widthTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // gridNameLbl
            // 
            this.gridNameLbl.AutoSize = true;
            this.gridNameLbl.Font = new System.Drawing.Font("Adam", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridNameLbl.Location = new System.Drawing.Point(29, 104);
            this.gridNameLbl.Name = "gridNameLbl";
            this.gridNameLbl.Size = new System.Drawing.Size(93, 17);
            this.gridNameLbl.TabIndex = 0;
            this.gridNameLbl.Text = "Grid Name";
            // 
            // gridNameTxt
            // 
            this.gridNameTxt.Location = new System.Drawing.Point(185, 101);
            this.gridNameTxt.Name = "gridNameTxt";
            this.gridNameTxt.Size = new System.Drawing.Size(150, 22);
            this.gridNameTxt.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // clientUsernameLbl
            // 
            this.clientUsernameLbl.AutoSize = true;
            this.clientUsernameLbl.Font = new System.Drawing.Font("Adam", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientUsernameLbl.Location = new System.Drawing.Point(29, 155);
            this.clientUsernameLbl.Name = "clientUsernameLbl";
            this.clientUsernameLbl.Size = new System.Drawing.Size(136, 17);
            this.clientUsernameLbl.TabIndex = 3;
            this.clientUsernameLbl.Text = "Client Username";
            // 
            // widthLbl
            // 
            this.widthLbl.AutoSize = true;
            this.widthLbl.Font = new System.Drawing.Font("Adam", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthLbl.Location = new System.Drawing.Point(102, 303);
            this.widthLbl.Name = "widthLbl";
            this.widthLbl.Size = new System.Drawing.Size(53, 17);
            this.widthLbl.TabIndex = 5;
            this.widthLbl.Text = "Width";
            // 
            // heightLbl
            // 
            this.heightLbl.AutoSize = true;
            this.heightLbl.Font = new System.Drawing.Font("Adam", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heightLbl.Location = new System.Drawing.Point(102, 266);
            this.heightLbl.Name = "heightLbl";
            this.heightLbl.Size = new System.Drawing.Size(59, 17);
            this.heightLbl.TabIndex = 6;
            this.heightLbl.Text = "Height";
            // 
            // createGridBtn
            // 
            this.createGridBtn.Location = new System.Drawing.Point(119, 360);
            this.createGridBtn.Name = "createGridBtn";
            this.createGridBtn.Size = new System.Drawing.Size(119, 42);
            this.createGridBtn.TabIndex = 7;
            this.createGridBtn.Text = "Create";
            this.createGridBtn.UseVisualStyleBackColor = true;
            this.createGridBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.createGridBtn_MouseClick);
            // 
            // createGridTittleLbl
            // 
            this.createGridTittleLbl.AutoSize = true;
            this.createGridTittleLbl.Font = new System.Drawing.Font("Blacklisted", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createGridTittleLbl.Location = new System.Drawing.Point(35, 20);
            this.createGridTittleLbl.Name = "createGridTittleLbl";
            this.createGridTittleLbl.Size = new System.Drawing.Size(291, 46);
            this.createGridTittleLbl.TabIndex = 8;
            this.createGridTittleLbl.Text = "Create a new Grid";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(185, 148);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(150, 24);
            this.comboBox1.TabIndex = 9;
            // 
            // gridPropertiesLbl
            // 
            this.gridPropertiesLbl.AutoSize = true;
            this.gridPropertiesLbl.Font = new System.Drawing.Font("Adam", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridPropertiesLbl.Location = new System.Drawing.Point(101, 221);
            this.gridPropertiesLbl.Name = "gridPropertiesLbl";
            this.gridPropertiesLbl.Size = new System.Drawing.Size(151, 20);
            this.gridPropertiesLbl.TabIndex = 10;
            this.gridPropertiesLbl.Text = "Grid Properties";
            // 
            // heightTxt
            // 
            this.heightTxt.Location = new System.Drawing.Point(202, 261);
            this.heightTxt.Name = "heightTxt";
            this.heightTxt.Size = new System.Drawing.Size(50, 22);
            this.heightTxt.TabIndex = 11;
            // 
            // widthTxt
            // 
            this.widthTxt.Location = new System.Drawing.Point(202, 298);
            this.widthTxt.Name = "widthTxt";
            this.widthTxt.Size = new System.Drawing.Size(50, 22);
            this.widthTxt.TabIndex = 12;
            // 
            // CreateGridForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 414);
            this.Controls.Add(this.widthTxt);
            this.Controls.Add(this.heightTxt);
            this.Controls.Add(this.gridPropertiesLbl);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.createGridTittleLbl);
            this.Controls.Add(this.createGridBtn);
            this.Controls.Add(this.heightLbl);
            this.Controls.Add(this.widthLbl);
            this.Controls.Add(this.clientUsernameLbl);
            this.Controls.Add(this.gridNameTxt);
            this.Controls.Add(this.gridNameLbl);
            this.Name = "CreateGridForm";
            this.Text = "CreateGridForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gridNameLbl;
        private System.Windows.Forms.TextBox gridNameTxt;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label clientUsernameLbl;
        private System.Windows.Forms.Label widthLbl;
        private System.Windows.Forms.Label heightLbl;
        private System.Windows.Forms.Button createGridBtn;
        private System.Windows.Forms.Label createGridTittleLbl;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label gridPropertiesLbl;
        private System.Windows.Forms.TextBox heightTxt;
        private System.Windows.Forms.TextBox widthTxt;
    }
}