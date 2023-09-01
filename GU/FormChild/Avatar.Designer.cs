namespace Gui.FormChild
{
    partial class Avatar
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
            this.label1 = new System.Windows.Forms.Label();
            this.Save = new FontAwesome.Sharp.IconButton();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.AccountName = new System.Windows.Forms.Label();
            this.rjCircularPictureBox1 = new Gui.CustomControl.RJCircularPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(127, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Change information";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            // 
            // Save
            // 
            this.Save.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Save.BackColor = System.Drawing.Color.Transparent;
            this.Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Save.FlatAppearance.BorderSize = 0;
            this.Save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Save.ForeColor = System.Drawing.Color.Gray;
            this.Save.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Save.IconColor = System.Drawing.Color.White;
            this.Save.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Save.IconSize = 25;
            this.Save.Location = new System.Drawing.Point(162, 145);
            this.Save.Margin = new System.Windows.Forms.Padding(0);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(70, 37);
            this.Save.TabIndex = 26;
            this.Save.Text = "Saved";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // EmailLabel
            // 
            this.EmailLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmailLabel.Location = new System.Drawing.Point(127, 46);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(41, 19);
            this.EmailLabel.TabIndex = 25;
            this.EmailLabel.Text = "####";
            // 
            // AccountName
            // 
            this.AccountName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AccountName.AutoSize = true;
            this.AccountName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AccountName.Location = new System.Drawing.Point(127, 12);
            this.AccountName.Name = "AccountName";
            this.AccountName.Size = new System.Drawing.Size(56, 25);
            this.AccountName.TabIndex = 24;
            this.AccountName.Text = "####";
            // 
            // rjCircularPictureBox1
            // 
            this.rjCircularPictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rjCircularPictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.rjCircularPictureBox1.BorderColor = System.Drawing.Color.RoyalBlue;
            this.rjCircularPictureBox1.BorderColor2 = System.Drawing.Color.HotPink;
            this.rjCircularPictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.rjCircularPictureBox1.BorderSize = 2;
            this.rjCircularPictureBox1.GradientAngle = 50F;
            this.rjCircularPictureBox1.Location = new System.Drawing.Point(12, 12);
            this.rjCircularPictureBox1.Name = "rjCircularPictureBox1";
            this.rjCircularPictureBox1.Size = new System.Drawing.Size(98, 98);
            this.rjCircularPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rjCircularPictureBox1.TabIndex = 23;
            this.rjCircularPictureBox1.TabStop = false;
            // 
            // Avatar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(420, 200);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.AccountName);
            this.Controls.Add(this.rjCircularPictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Avatar";
            this.Text = "Avatar";
            this.Load += new System.EventHandler(this.AvatarForm_Load);
            this.Leave += new System.EventHandler(this.Avatar_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label EmailLabel;
        private Label AccountName;
        public CustomControl.RJCircularPictureBox rjCircularPictureBox1;
        public FontAwesome.Sharp.IconButton Save;
    }
}