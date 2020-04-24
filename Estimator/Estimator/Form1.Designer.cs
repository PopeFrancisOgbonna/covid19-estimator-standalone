namespace Estimator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.headerPane = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ImagePane = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.loginPane = new System.Windows.Forms.Panel();
            this.btnEstimate = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.timelbl = new System.Windows.Forms.Label();
            this.datelbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.headerPane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ImagePane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.loginPane.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPane
            // 
            this.headerPane.BackColor = System.Drawing.Color.Silver;
            this.headerPane.Controls.Add(this.label1);
            this.headerPane.Controls.Add(this.pictureBox1);
            this.headerPane.Location = new System.Drawing.Point(12, 12);
            this.headerPane.Name = "headerPane";
            this.headerPane.Size = new System.Drawing.Size(888, 84);
            this.headerPane.TabIndex = 0;
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
            // ImagePane
            // 
            this.ImagePane.BackColor = System.Drawing.Color.Silver;
            this.ImagePane.Controls.Add(this.pictureBox2);
            this.ImagePane.Location = new System.Drawing.Point(473, 149);
            this.ImagePane.Name = "ImagePane";
            this.ImagePane.Size = new System.Drawing.Size(427, 273);
            this.ImagePane.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(418, 262);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // loginPane
            // 
            this.loginPane.BackColor = System.Drawing.Color.Silver;
            this.loginPane.Controls.Add(this.richTextBox1);
            this.loginPane.Location = new System.Drawing.Point(12, 102);
            this.loginPane.Name = "loginPane";
            this.loginPane.Size = new System.Drawing.Size(455, 263);
            this.loginPane.TabIndex = 0;
            // 
            // btnEstimate
            // 
            this.btnEstimate.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEstimate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEstimate.Font = new System.Drawing.Font("Tempus Sans ITC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstimate.ForeColor = System.Drawing.Color.Transparent;
            this.btnEstimate.Location = new System.Drawing.Point(13, 375);
            this.btnEstimate.Name = "btnEstimate";
            this.btnEstimate.Size = new System.Drawing.Size(196, 47);
            this.btnEstimate.TabIndex = 1;
            this.btnEstimate.Text = "Estimate Impact";
            this.btnEstimate.UseVisualStyleBackColor = false;
            this.btnEstimate.Click += new System.EventHandler(this.btnEstimate_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(10, 9);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 3, 33, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(435, 244);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // timelbl
            // 
            this.timelbl.AutoSize = true;
            this.timelbl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.timelbl.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timelbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.timelbl.Location = new System.Drawing.Point(624, 122);
            this.timelbl.Name = "timelbl";
            this.timelbl.Size = new System.Drawing.Size(74, 24);
            this.timelbl.TabIndex = 2;
            this.timelbl.Text = "label2";
            // 
            // datelbl
            // 
            this.datelbl.AutoSize = true;
            this.datelbl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.datelbl.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datelbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.datelbl.Location = new System.Drawing.Point(557, 98);
            this.datelbl.Name = "datelbl";
            this.datelbl.Size = new System.Drawing.Size(74, 24);
            this.datelbl.TabIndex = 2;
            this.datelbl.Text = "label2";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(915, 434);
            this.Controls.Add(this.datelbl);
            this.Controls.Add(this.timelbl);
            this.Controls.Add(this.btnEstimate);
            this.Controls.Add(this.loginPane);
            this.Controls.Add(this.ImagePane);
            this.Controls.Add(this.headerPane);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.headerPane.ResumeLayout(false);
            this.headerPane.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ImagePane.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.loginPane.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel headerPane;
        private System.Windows.Forms.Panel ImagePane;
        private System.Windows.Forms.Panel loginPane;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnEstimate;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label timelbl;
        private System.Windows.Forms.Label datelbl;
        private System.Windows.Forms.Timer timer1;
    }
}

