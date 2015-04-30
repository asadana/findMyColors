namespace findMyColor
{
    partial class learnWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(learnWindow));
            this.btnNext = new System.Windows.Forms.Button();
            this.lblColor = new System.Windows.Forms.Label();
            this.dispColor = new System.Windows.Forms.PictureBox();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnLetsStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dispColor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.Black;
            this.btnNext.Location = new System.Drawing.Point(513, 69);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 339);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            this.btnNext.MouseEnter += new System.EventHandler(this.btnNext_MouseEnter);
            this.btnNext.MouseLeave += new System.EventHandler(this.btnNext_MouseLeave);
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblColor.Location = new System.Drawing.Point(246, 28);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(133, 29);
            this.lblColor.TabIndex = 2;
            this.lblColor.Text = "<COLOR>";
            this.lblColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dispColor
            // 
            this.dispColor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dispColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dispColor.Location = new System.Drawing.Point(86, 69);
            this.dispColor.Name = "dispColor";
            this.dispColor.Size = new System.Drawing.Size(432, 339);
            this.dispColor.TabIndex = 3;
            this.dispColor.TabStop = false;
            // 
            // btnPrev
            // 
            this.btnPrev.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev.ForeColor = System.Drawing.Color.Black;
            this.btnPrev.Location = new System.Drawing.Point(12, 69);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(75, 339);
            this.btnPrev.TabIndex = 4;
            this.btnPrev.Text = "<";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            this.btnPrev.MouseEnter += new System.EventHandler(this.btnPrev_MouseEnter);
            this.btnPrev.MouseLeave += new System.EventHandler(this.btnPrev_MouseLeave);
            // 
            // btnLetsStart
            // 
            this.btnLetsStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLetsStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLetsStart.ForeColor = System.Drawing.Color.Black;
            this.btnLetsStart.Location = new System.Drawing.Point(152, 414);
            this.btnLetsStart.Name = "btnLetsStart";
            this.btnLetsStart.Size = new System.Drawing.Size(299, 54);
            this.btnLetsStart.TabIndex = 5;
            this.btnLetsStart.Text = "Let\'s Start !";
            this.btnLetsStart.UseVisualStyleBackColor = true;
            this.btnLetsStart.Click += new System.EventHandler(this.btnLetsStart_Click);
            this.btnLetsStart.MouseEnter += new System.EventHandler(this.btnLetsStart_MouseEnter);
            this.btnLetsStart.MouseLeave += new System.EventHandler(this.btnLetsStart_MouseLeave);
            // 
            // learnWindow
            // 
            this.AcceptButton = this.btnNext;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(600, 480);
            this.Controls.Add(this.btnLetsStart);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.dispColor);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.btnNext);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(618, 527);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(618, 527);
            this.Name = "learnWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Learning Colors";
            this.Load += new System.EventHandler(this.learnWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dispColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.PictureBox dispColor;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnLetsStart;
    }
}