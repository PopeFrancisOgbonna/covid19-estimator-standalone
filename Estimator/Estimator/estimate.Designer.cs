namespace Estimator
{
    partial class estimate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(estimate));
            this.loginPane = new System.Windows.Forms.Panel();
            this.ImagePane = new System.Windows.Forms.Panel();
            this.headerPane = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.loginPane.SuspendLayout();
            this.headerPane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // loginPane
            // 
            this.loginPane.BackColor = System.Drawing.Color.Silver;
            this.loginPane.Controls.Add(this.groupBox1);
            this.loginPane.Location = new System.Drawing.Point(12, 97);
            this.loginPane.Name = "loginPane";
            this.loginPane.Size = new System.Drawing.Size(360, 358);
            this.loginPane.TabIndex = 3;
            // 
            // ImagePane
            // 
            this.ImagePane.BackColor = System.Drawing.Color.Silver;
            this.ImagePane.Location = new System.Drawing.Point(378, 97);
            this.ImagePane.Name = "ImagePane";
            this.ImagePane.Size = new System.Drawing.Size(598, 420);
            this.ImagePane.TabIndex = 4;
            // 
            // headerPane
            // 
            this.headerPane.BackColor = System.Drawing.Color.Silver;
            this.headerPane.Controls.Add(this.label1);
            this.headerPane.Controls.Add(this.pictureBox1);
            this.headerPane.Location = new System.Drawing.Point(12, 7);
            this.headerPane.Name = "headerPane";
            this.headerPane.Size = new System.Drawing.Size(964, 84);
            this.headerPane.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("News706 BT", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(79)))));
            this.label1.Location = new System.Drawing.Point(133, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(648, 57);
            this.label1.TabIndex = 1;
            this.label1.Text = "Covid-19 Impact Estimator";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 334);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // estimate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 529);
            this.Controls.Add(this.loginPane);
            this.Controls.Add(this.ImagePane);
            this.Controls.Add(this.headerPane);
            this.Name = "estimate";
            this.loginPane.ResumeLayout(false);
            this.headerPane.ResumeLayout(false);
            this.headerPane.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel loginPane;
        private System.Windows.Forms.Panel ImagePane;
        private System.Windows.Forms.Panel headerPane;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}