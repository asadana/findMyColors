namespace findMyColor
{
    partial class mainGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainGame));
            this.color1 = new System.Windows.Forms.PictureBox();
            this.color2 = new System.Windows.Forms.PictureBox();
            this.color3 = new System.Windows.Forms.PictureBox();
            this.color4 = new System.Windows.Forms.PictureBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lblMsg = new System.Windows.Forms.Label();
            this.lblFind = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnLearnColors = new System.Windows.Forms.Button();
            this.picResponse = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.color1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.color2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.color3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.color4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResponse)).BeginInit();
            this.SuspendLayout();
            // 
            // color1
            // 
            this.color1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.color1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.color1.Location = new System.Drawing.Point(51, 80);
            this.color1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.color1.Name = "color1";
            this.color1.Size = new System.Drawing.Size(279, 180);
            this.color1.TabIndex = 0;
            this.color1.TabStop = false;
            this.color1.Click += new System.EventHandler(this.color1_Click);
            // 
            // color2
            // 
            this.color2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.color2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.color2.Location = new System.Drawing.Point(337, 80);
            this.color2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.color2.Name = "color2";
            this.color2.Size = new System.Drawing.Size(279, 180);
            this.color2.TabIndex = 1;
            this.color2.TabStop = false;
            this.color2.Click += new System.EventHandler(this.color2_Click);
            // 
            // color3
            // 
            this.color3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.color3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.color3.Location = new System.Drawing.Point(51, 266);
            this.color3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.color3.Name = "color3";
            this.color3.Size = new System.Drawing.Size(279, 180);
            this.color3.TabIndex = 2;
            this.color3.TabStop = false;
            this.color3.Click += new System.EventHandler(this.color3_Click);
            // 
            // color4
            // 
            this.color4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.color4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.color4.Location = new System.Drawing.Point(337, 266);
            this.color4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.color4.Name = "color4";
            this.color4.Size = new System.Drawing.Size(279, 180);
            this.color4.TabIndex = 3;
            this.color4.TabStop = false;
            this.color4.Click += new System.EventHandler(this.color4_Click);
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.progressBar.Location = new System.Drawing.Point(12, 513);
            this.progressBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBar.MarqueeAnimationSpeed = 50;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(757, 78);
            this.progressBar.Step = 13;
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 4;
            // 
            // lblMsg
            // 
            this.lblMsg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMsg.AutoSize = true;
            this.lblMsg.BackColor = System.Drawing.Color.Transparent;
            this.lblMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.ForeColor = System.Drawing.Color.Black;
            this.lblMsg.Location = new System.Drawing.Point(255, 486);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(297, 25);
            this.lblMsg.TabIndex = 5;
            this.lblMsg.Text = " Fill this up to get new Colors!";
            // 
            // lblFind
            // 
            this.lblFind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFind.AutoSize = true;
            this.lblFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFind.Location = new System.Drawing.Point(281, 22);
            this.lblFind.Name = "lblFind";
            this.lblFind.Size = new System.Drawing.Size(169, 25);
            this.lblFind.TabIndex = 6;
            this.lblFind.Text = "FIND <COLOR>";
            this.lblFind.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnQuit
            // 
            this.btnQuit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Location = new System.Drawing.Point(623, 266);
            this.btnQuit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(149, 180);
            this.btnQuit.TabIndex = 9;
            this.btnQuit.Text = "STOP PLAYING";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            this.btnQuit.MouseEnter += new System.EventHandler(this.btnQuit_MouseEnter);
            this.btnQuit.MouseLeave += new System.EventHandler(this.btnQuit_MouseLeave);
            // 
            // btnLearnColors
            // 
            this.btnLearnColors.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLearnColors.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLearnColors.Location = new System.Drawing.Point(623, 80);
            this.btnLearnColors.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLearnColors.Name = "btnLearnColors";
            this.btnLearnColors.Size = new System.Drawing.Size(149, 180);
            this.btnLearnColors.TabIndex = 10;
            this.btnLearnColors.Text = "SEE ALL COLORS AGAIN";
            this.btnLearnColors.UseVisualStyleBackColor = true;
            this.btnLearnColors.Click += new System.EventHandler(this.btnLearnColors_Click);
            this.btnLearnColors.MouseEnter += new System.EventHandler(this.btnLearnColors_MouseEnter);
            this.btnLearnColors.MouseLeave += new System.EventHandler(this.btnLearnColors_MouseLeave);
            // 
            // picResponse
            // 
            this.picResponse.BackColor = System.Drawing.Color.Transparent;
            this.picResponse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picResponse.Location = new System.Drawing.Point(272, 212);
            this.picResponse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picResponse.Name = "picResponse";
            this.picResponse.Size = new System.Drawing.Size(119, 103);
            this.picResponse.TabIndex = 11;
            this.picResponse.TabStop = false;
            // 
            // mainGame
            // 
            this.AcceptButton = this.btnLearnColors;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.CancelButton = this.btnQuit;
            this.ClientSize = new System.Drawing.Size(781, 601);
            this.Controls.Add(this.picResponse);
            this.Controls.Add(this.btnLearnColors);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.lblFind);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.color4);
            this.Controls.Add(this.color3);
            this.Controls.Add(this.color2);
            this.Controls.Add(this.color1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(799, 648);
            this.MinimumSize = new System.Drawing.Size(799, 648);
            this.Name = "mainGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Find My Color! By: Ankit Sadana";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainGame_FormClosing);
            this.Load += new System.EventHandler(this.mainGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.color1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.color2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.color3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.color4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResponse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox color1;
        private System.Windows.Forms.PictureBox color2;
        private System.Windows.Forms.PictureBox color3;
        private System.Windows.Forms.PictureBox color4;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Label lblFind;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnLearnColors;
        private System.Windows.Forms.PictureBox picResponse;
    }
}

