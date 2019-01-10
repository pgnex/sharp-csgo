namespace luxe_csgo {
    partial class modulegrabber {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.pnlBackground = new System.Windows.Forms.Panel();
            this.lblOnii = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblPlss = new System.Windows.Forms.Label();
            this.update_timer = new System.Windows.Forms.Timer(this.components);
            this.pnlBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBackground
            // 
            this.pnlBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(18)))), ((int)(((byte)(22)))));
            this.pnlBackground.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBackground.Controls.Add(this.lblOnii);
            this.pnlBackground.Controls.Add(this.pictureBox1);
            this.pnlBackground.Controls.Add(this.lblPlss);
            this.pnlBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBackground.Location = new System.Drawing.Point(0, 0);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(273, 153);
            this.pnlBackground.TabIndex = 0;
            // 
            // lblOnii
            // 
            this.lblOnii.AutoSize = true;
            this.lblOnii.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOnii.ForeColor = System.Drawing.SystemColors.Control;
            this.lblOnii.Location = new System.Drawing.Point(79, 16);
            this.lblOnii.Name = "lblOnii";
            this.lblOnii.Size = new System.Drawing.Size(113, 25);
            this.lblOnii.TabIndex = 2;
            this.lblOnii.Text = "onii-chan~";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::luxe_csgo.Properties.Resources._1;
            this.pictureBox1.Location = new System.Drawing.Point(85, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblPlss
            // 
            this.lblPlss.AutoSize = true;
            this.lblPlss.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlss.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPlss.Location = new System.Drawing.Point(23, 47);
            this.lblPlss.Name = "lblPlss";
            this.lblPlss.Size = new System.Drawing.Size(225, 25);
            this.lblPlss.TabIndex = 0;
            this.lblPlss.Text = "p-pls open csgo.. >//<";
            // 
            // update_timer
            // 
            this.update_timer.Interval = 500;
            this.update_timer.Tick += new System.EventHandler(this.update_timer_Tick);
            // 
            // modulegrabber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 153);
            this.Controls.Add(this.pnlBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "modulegrabber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnlBackground.ResumeLayout(false);
            this.pnlBackground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBackground;
        private System.Windows.Forms.Label lblPlss;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblOnii;
        private System.Windows.Forms.Timer update_timer;
    }
}

