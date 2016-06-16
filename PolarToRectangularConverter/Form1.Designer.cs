namespace PolarToRectangularConverter
{
    partial class FrmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtXY = new System.Windows.Forms.TextBox();
            this.txtRTheta = new System.Windows.Forms.TextBox();
            this.lblXY = new System.Windows.Forms.Label();
            this.lblRTheta = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.txtIntro = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(504, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // txtXY
            // 
            this.txtXY.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXY.Location = new System.Drawing.Point(88, 209);
            this.txtXY.Name = "txtXY";
            this.txtXY.Size = new System.Drawing.Size(100, 38);
            this.txtXY.TabIndex = 1;
            // 
            // txtRTheta
            // 
            this.txtRTheta.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRTheta.Location = new System.Drawing.Point(321, 209);
            this.txtRTheta.Name = "txtRTheta";
            this.txtRTheta.Size = new System.Drawing.Size(100, 38);
            this.txtRTheta.TabIndex = 2;
            // 
            // lblXY
            // 
            this.lblXY.AutoSize = true;
            this.lblXY.Location = new System.Drawing.Point(117, 189);
            this.lblXY.Name = "lblXY";
            this.lblXY.Size = new System.Drawing.Size(40, 17);
            this.lblXY.TabIndex = 3;
            this.lblXY.Text = "(X,Y)";
            // 
            // lblRTheta
            // 
            this.lblRTheta.AutoSize = true;
            this.lblRTheta.Location = new System.Drawing.Point(351, 189);
            this.lblRTheta.Name = "lblRTheta";
            this.lblRTheta.Size = new System.Drawing.Size(35, 17);
            this.lblRTheta.TabIndex = 4;
            this.lblRTheta.Text = "(r,θ)";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(214, 209);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 38);
            this.btnCalc.TabIndex = 5;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            // 
            // txtIntro
            // 
            this.txtIntro.AllowDrop = true;
            this.txtIntro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIntro.Location = new System.Drawing.Point(88, 43);
            this.txtIntro.Multiline = true;
            this.txtIntro.Name = "txtIntro";
            this.txtIntro.ReadOnly = true;
            this.txtIntro.Size = new System.Drawing.Size(386, 127);
            this.txtIntro.TabIndex = 6;
            this.txtIntro.Text = "Instructions:\r\n\r\n1. Enter your values in the appropriate textbox\r\n2. Check the fo" +
    "rmat of the data\r\n3. Click Calculate to find coordinates";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 428);
            this.Controls.Add(this.txtIntro);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.lblRTheta);
            this.Controls.Add(this.lblXY);
            this.Controls.Add(this.txtRTheta);
            this.Controls.Add(this.txtXY);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "Polar Coordinate Converter ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TextBox txtXY;
        private System.Windows.Forms.TextBox txtRTheta;
        private System.Windows.Forms.Label lblXY;
        private System.Windows.Forms.Label lblRTheta;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.TextBox txtIntro;
    }
}

