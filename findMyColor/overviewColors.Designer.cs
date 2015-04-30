namespace findMyColor
{
    partial class overviewColors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(overviewColors));
            this.btnBack = new System.Windows.Forms.Button();
            this.lblColor1 = new System.Windows.Forms.Label();
            this.colorBox1 = new System.Windows.Forms.PictureBox();
            this.colorBox2 = new System.Windows.Forms.PictureBox();
            this.lblColor2 = new System.Windows.Forms.Label();
            this.colorBox3 = new System.Windows.Forms.PictureBox();
            this.lblColor3 = new System.Windows.Forms.Label();
            this.colorBox4 = new System.Windows.Forms.PictureBox();
            this.lblColor4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.colorBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBack.Location = new System.Drawing.Point(174, 442);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(310, 74);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "LET\'S GO BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.btnBack.MouseEnter += new System.EventHandler(this.btnBack_MouseEnter);
            this.btnBack.MouseLeave += new System.EventHandler(this.btnBack_MouseLeave);
            // 
            // lblColor1
            // 
            this.lblColor1.AutoSize = true;
            this.lblColor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor1.Location = new System.Drawing.Point(124, 25);
            this.lblColor1.Name = "lblColor1";
            this.lblColor1.Size = new System.Drawing.Size(83, 20);
            this.lblColor1.TabIndex = 1;
            this.lblColor1.Text = "<color1>";
            // 
            // colorBox1
            // 
            this.colorBox1.Location = new System.Drawing.Point(28, 56);
            this.colorBox1.Name = "colorBox1";
            this.colorBox1.Size = new System.Drawing.Size(261, 153);
            this.colorBox1.TabIndex = 2;
            this.colorBox1.TabStop = false;
            // 
            // colorBox2
            // 
            this.colorBox2.Location = new System.Drawing.Point(366, 56);
            this.colorBox2.Name = "colorBox2";
            this.colorBox2.Size = new System.Drawing.Size(261, 153);
            this.colorBox2.TabIndex = 4;
            this.colorBox2.TabStop = false;
            // 
            // lblColor2
            // 
            this.lblColor2.AutoSize = true;
            this.lblColor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor2.Location = new System.Drawing.Point(462, 25);
            this.lblColor2.Name = "lblColor2";
            this.lblColor2.Size = new System.Drawing.Size(83, 20);
            this.lblColor2.TabIndex = 3;
            this.lblColor2.Text = "<color2>";
            // 
            // colorBox3
            // 
            this.colorBox3.Location = new System.Drawing.Point(28, 265);
            this.colorBox3.Name = "colorBox3";
            this.colorBox3.Size = new System.Drawing.Size(261, 153);
            this.colorBox3.TabIndex = 6;
            this.colorBox3.TabStop = false;
            // 
            // lblColor3
            // 
            this.lblColor3.AutoSize = true;
            this.lblColor3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor3.Location = new System.Drawing.Point(124, 234);
            this.lblColor3.Name = "lblColor3";
            this.lblColor3.Size = new System.Drawing.Size(83, 20);
            this.lblColor3.TabIndex = 5;
            this.lblColor3.Text = "<color3>";
            // 
            // colorBox4
            // 
            this.colorBox4.Location = new System.Drawing.Point(366, 265);
            this.colorBox4.Name = "colorBox4";
            this.colorBox4.Size = new System.Drawing.Size(261, 153);
            this.colorBox4.TabIndex = 8;
            this.colorBox4.TabStop = false;
            // 
            // lblColor4
            // 
            this.lblColor4.AutoSize = true;
            this.lblColor4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor4.Location = new System.Drawing.Point(462, 234);
            this.lblColor4.Name = "lblColor4";
            this.lblColor4.Size = new System.Drawing.Size(83, 20);
            this.lblColor4.TabIndex = 7;
            this.lblColor4.Text = "<color4>";
            // 
            // overviewColors
            // 
            this.AcceptButton = this.btnBack;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.CancelButton = this.btnBack;
            this.ClientSize = new System.Drawing.Size(655, 528);
            this.Controls.Add(this.colorBox4);
            this.Controls.Add(this.lblColor4);
            this.Controls.Add(this.colorBox3);
            this.Controls.Add(this.lblColor3);
            this.Controls.Add(this.colorBox2);
            this.Controls.Add(this.lblColor2);
            this.Controls.Add(this.colorBox1);
            this.Controls.Add(this.lblColor1);
            this.Controls.Add(this.btnBack);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(673, 575);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(673, 575);
            this.Name = "overviewColors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Let\'s go over all colors again";
            this.Load += new System.EventHandler(this.overviewColors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.colorBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblColor1;
        private System.Windows.Forms.PictureBox colorBox1;
        private System.Windows.Forms.PictureBox colorBox2;
        private System.Windows.Forms.Label lblColor2;
        private System.Windows.Forms.PictureBox colorBox3;
        private System.Windows.Forms.Label lblColor3;
        private System.Windows.Forms.PictureBox colorBox4;
        private System.Windows.Forms.Label lblColor4;
    }
}