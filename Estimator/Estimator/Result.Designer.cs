namespace Estimator
{
    partial class Result
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Result));
            this.headerPane = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ImagePane = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.eRTab = new System.Windows.Forms.TabPage();
            this.dataG = new System.Windows.Forms.DataGridView();
            this.preventTab = new System.Windows.Forms.TabPage();
            this.richPrevent = new System.Windows.Forms.RichTextBox();
            this.spreadTab = new System.Windows.Forms.TabPage();
            this.richSpread = new System.Windows.Forms.RichTextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.headerPane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ImagePane.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.eRTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataG)).BeginInit();
            this.preventTab.SuspendLayout();
            this.spreadTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPane
            // 
            this.headerPane.BackColor = System.Drawing.Color.Silver;
            this.headerPane.Controls.Add(this.label1);
            this.headerPane.Controls.Add(this.pictureBox1);
            this.headerPane.Location = new System.Drawing.Point(12, 12);
            this.headerPane.Name = "headerPane";
            this.headerPane.Size = new System.Drawing.Size(788, 75);
            this.headerPane.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("News706 BT", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(79)))));
            this.label1.Location = new System.Drawing.Point(135, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(648, 57);
            this.label1.TabIndex = 1;
            this.label1.Text = "Covid-19 Impact Estimator";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ImagePane
            // 
            this.ImagePane.BackColor = System.Drawing.Color.Silver;
            this.ImagePane.Controls.Add(this.tabControl1);
            this.ImagePane.Location = new System.Drawing.Point(42, 93);
            this.ImagePane.Name = "ImagePane";
            this.ImagePane.Size = new System.Drawing.Size(707, 262);
            this.ImagePane.TabIndex = 4;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.eRTab);
            this.tabControl1.Controls.Add(this.preventTab);
            this.tabControl1.Controls.Add(this.spreadTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(13, 3, 3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(707, 262);
            this.tabControl1.TabIndex = 0;
            // 
            // eRTab
            // 
            this.eRTab.Controls.Add(this.dataG);
            this.eRTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eRTab.Location = new System.Drawing.Point(4, 27);
            this.eRTab.Name = "eRTab";
            this.eRTab.Padding = new System.Windows.Forms.Padding(3);
            this.eRTab.Size = new System.Drawing.Size(699, 231);
            this.eRTab.TabIndex = 0;
            this.eRTab.Text = "Estimation Results";
            this.eRTab.UseVisualStyleBackColor = true;
            // 
            // dataG
            // 
            this.dataG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataG.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataG.Location = new System.Drawing.Point(6, 7);
            this.dataG.Name = "dataG";
            this.dataG.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataG.Size = new System.Drawing.Size(687, 217);
            this.dataG.TabIndex = 0;
            // 
            // preventTab
            // 
            this.preventTab.Controls.Add(this.richPrevent);
            this.preventTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preventTab.Location = new System.Drawing.Point(4, 27);
            this.preventTab.Name = "preventTab";
            this.preventTab.Size = new System.Drawing.Size(699, 231);
            this.preventTab.TabIndex = 2;
            this.preventTab.Text = "Preventive Measures";
            this.preventTab.UseVisualStyleBackColor = true;
            // 
            // richPrevent
            // 
            this.richPrevent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richPrevent.Enabled = false;
            this.richPrevent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richPrevent.Location = new System.Drawing.Point(0, 0);
            this.richPrevent.Name = "richPrevent";
            this.richPrevent.ReadOnly = true;
            this.richPrevent.Size = new System.Drawing.Size(699, 231);
            this.richPrevent.TabIndex = 0;
            this.richPrevent.Text = resources.GetString("richPrevent.Text");
            // 
            // spreadTab
            // 
            this.spreadTab.Controls.Add(this.richSpread);
            this.spreadTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spreadTab.Location = new System.Drawing.Point(4, 27);
            this.spreadTab.Name = "spreadTab";
            this.spreadTab.Size = new System.Drawing.Size(699, 231);
            this.spreadTab.TabIndex = 3;
            this.spreadTab.Text = "How it Spreads";
            this.spreadTab.UseVisualStyleBackColor = true;
            // 
            // richSpread
            // 
            this.richSpread.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richSpread.Location = new System.Drawing.Point(0, 0);
            this.richSpread.Name = "richSpread";
            this.richSpread.ReadOnly = true;
            this.richSpread.Size = new System.Drawing.Size(699, 231);
            this.richSpread.TabIndex = 0;
            this.richSpread.Text = resources.GetString("richSpread.Text");
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(576, 368);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(69, 34);
            this.btnBack.TabIndex = 9;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSave.BackColor = System.Drawing.Color.MediumPurple;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(651, 368);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 34);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 414);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.ImagePane);
            this.Controls.Add(this.headerPane);
            this.MaximumSize = new System.Drawing.Size(828, 453);
            this.MinimumSize = new System.Drawing.Size(828, 453);
            this.Name = "Result";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.headerPane.ResumeLayout(false);
            this.headerPane.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ImagePane.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.eRTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataG)).EndInit();
            this.preventTab.ResumeLayout(false);
            this.spreadTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel headerPane;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel ImagePane;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage eRTab;
        private System.Windows.Forms.TabPage preventTab;
        private System.Windows.Forms.RichTextBox richPrevent;
        private System.Windows.Forms.TabPage spreadTab;
        private System.Windows.Forms.RichTextBox richSpread;
        public System.Windows.Forms.DataGridView dataG;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSave;
    }
}