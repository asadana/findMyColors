namespace findMyColor
{
    partial class welcomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(welcomeForm));
            this.btnStart = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblMadaeBy = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnStart.Location = new System.Drawing.Point(103, 419);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(300, 60);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Let\'s Play!";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(57, 90);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(385, 32);
            this.lblWelcome.TabIndex = 2;
            this.lblWelcome.Text = "Welcome to Find My Colors";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWelcome.MouseEnter += new System.EventHandler(this.lblColorChange);
            this.lblWelcome.MouseLeave += new System.EventHandler(this.lblColorChange);
            // 
            // lblMadaeBy
            // 
            this.lblMadaeBy.AutoSize = true;
            this.lblMadaeBy.BackColor = System.Drawing.Color.Transparent;
            this.lblMadaeBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMadaeBy.Location = new System.Drawing.Point(140, 346);
            this.lblMadaeBy.Name = "lblMadaeBy";
            this.lblMadaeBy.Size = new System.Drawing.Size(219, 25);
            this.lblMadaeBy.TabIndex = 3;
            this.lblMadaeBy.Text = "Made By: Ankit Sadana";
            this.lblMadaeBy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMadaeBy.MouseEnter += new System.EventHandler(this.lblColorChange);
            this.lblMadaeBy.MouseLeave += new System.EventHandler(this.lblColorChange);
            // 
            // welcomeForm
            // 
            this.AcceptButton = this.btnStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CancelButton = this.btnStart;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.ControlBox = false;
            this.Controls.Add(this.lblMadaeBy);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnStart);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "welcomeForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome to Find My Color";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblMadaeBy;
    }
}