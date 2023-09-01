namespace Gui.FormChild
{
    partial class PromotoForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.rjCircularPictureBox1 = new Gui.CustomControl.RJCircularPictureBox();
            this.CountDownTime = new System.Windows.Forms.Label();
            this.CountUpTime = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.NormalStart = new FontAwesome.Sharp.IconButton();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.HardStart = new FontAwesome.Sharp.IconButton();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.resetButton = new FontAwesome.Sharp.IconButton();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.CountDownTime, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.CountUpTime, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel7, 0, 6);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(250, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 210F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.66667F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(300, 450);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel3.Controls.Add(this.rjCircularPictureBox1, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 13);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(300, 210);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // rjCircularPictureBox1
            // 
            this.rjCircularPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.rjCircularPictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.rjCircularPictureBox1.BorderColor = System.Drawing.Color.RoyalBlue;
            this.rjCircularPictureBox1.BorderColor2 = System.Drawing.Color.HotPink;
            this.rjCircularPictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.rjCircularPictureBox1.BorderSize = 3;
            this.rjCircularPictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rjCircularPictureBox1.GradientAngle = 50F;
            this.rjCircularPictureBox1.Location = new System.Drawing.Point(45, 0);
            this.rjCircularPictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.rjCircularPictureBox1.Name = "rjCircularPictureBox1";
            this.rjCircularPictureBox1.Size = new System.Drawing.Size(210, 210);
            this.rjCircularPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rjCircularPictureBox1.TabIndex = 0;
            this.rjCircularPictureBox1.TabStop = false;
            // 
            // CountDownTime
            // 
            this.CountDownTime.BackColor = System.Drawing.Color.Transparent;
            this.CountDownTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CountDownTime.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CountDownTime.ForeColor = System.Drawing.Color.Salmon;
            this.CountDownTime.Location = new System.Drawing.Point(0, 223);
            this.CountDownTime.Margin = new System.Windows.Forms.Padding(0);
            this.CountDownTime.Name = "CountDownTime";
            this.CountDownTime.Size = new System.Drawing.Size(300, 40);
            this.CountDownTime.TabIndex = 1;
            this.CountDownTime.Text = "25:00";
            this.CountDownTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CountUpTime
            // 
            this.CountUpTime.AutoSize = true;
            this.CountUpTime.BackColor = System.Drawing.Color.Transparent;
            this.CountUpTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CountUpTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CountUpTime.ForeColor = System.Drawing.Color.OliveDrab;
            this.CountUpTime.Location = new System.Drawing.Point(0, 263);
            this.CountUpTime.Margin = new System.Windows.Forms.Padding(0);
            this.CountUpTime.Name = "CountUpTime";
            this.CountUpTime.Size = new System.Drawing.Size(300, 40);
            this.CountUpTime.TabIndex = 2;
            this.CountUpTime.Text = "00:00:00";
            this.CountUpTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel4.Controls.Add(this.NormalStart, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 303);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(300, 40);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // NormalStart
            // 
            this.NormalStart.BackColor = System.Drawing.Color.Transparent;
            this.NormalStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NormalStart.FlatAppearance.BorderSize = 0;
            this.NormalStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.NormalStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.NormalStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NormalStart.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NormalStart.ForeColor = System.Drawing.Color.Silver;
            this.NormalStart.IconChar = FontAwesome.Sharp.IconChar.None;
            this.NormalStart.IconColor = System.Drawing.Color.Black;
            this.NormalStart.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.NormalStart.Location = new System.Drawing.Point(45, 0);
            this.NormalStart.Margin = new System.Windows.Forms.Padding(0);
            this.NormalStart.Name = "NormalStart";
            this.NormalStart.Size = new System.Drawing.Size(210, 40);
            this.NormalStart.TabIndex = 3;
            this.NormalStart.Text = "Normal Start";
            this.NormalStart.UseVisualStyleBackColor = false;
            this.NormalStart.Click += new System.EventHandler(this.NormalStart_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel5.Controls.Add(this.HardStart, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 343);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(300, 40);
            this.tableLayoutPanel5.TabIndex = 4;
            // 
            // HardStart
            // 
            this.HardStart.BackColor = System.Drawing.Color.Transparent;
            this.HardStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HardStart.FlatAppearance.BorderSize = 0;
            this.HardStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.HardStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.HardStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HardStart.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HardStart.ForeColor = System.Drawing.Color.Silver;
            this.HardStart.IconChar = FontAwesome.Sharp.IconChar.None;
            this.HardStart.IconColor = System.Drawing.Color.Black;
            this.HardStart.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.HardStart.Location = new System.Drawing.Point(48, 3);
            this.HardStart.Name = "HardStart";
            this.HardStart.Size = new System.Drawing.Size(204, 34);
            this.HardStart.TabIndex = 0;
            this.HardStart.Text = "Hard Start";
            this.HardStart.UseVisualStyleBackColor = false;
            this.HardStart.Click += new System.EventHandler(this.HardStart_Click);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.00001F));
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // iconButton3
            // 
            this.iconButton3.BackColor = System.Drawing.Color.Transparent;
            this.iconButton3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton3.IconColor = System.Drawing.Color.Black;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.Location = new System.Drawing.Point(24, 0);
            this.iconButton3.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(150, 100);
            this.iconButton3.TabIndex = 3;
            this.iconButton3.Text = "iconButton3";
            this.iconButton3.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.Transparent;
            this.resetButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resetButton.FlatAppearance.BorderSize = 0;
            this.resetButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.resetButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.resetButton.ForeColor = System.Drawing.Color.Silver;
            this.resetButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.resetButton.IconColor = System.Drawing.Color.Black;
            this.resetButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.resetButton.Location = new System.Drawing.Point(48, 3);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(204, 34);
            this.resetButton.TabIndex = 0;
            this.resetButton.Text = "Restart";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel7.ColumnCount = 3;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel7.Controls.Add(this.resetButton, 1, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(0, 383);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(300, 40);
            this.tableLayoutPanel7.TabIndex = 5;
            // 
            // PromotoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PromotoForm";
            this.Text = "PromotoForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label CountDownTime;
        private Label CountUpTime;
        private TableLayoutPanel tableLayoutPanel4;
        private FontAwesome.Sharp.IconButton NormalStart;
        private TableLayoutPanel tableLayoutPanel5;
        private FontAwesome.Sharp.IconButton HardStart;
        private TableLayoutPanel tableLayoutPanel6;
        private FontAwesome.Sharp.IconButton iconButton3;
        private System.Windows.Forms.Timer timer1;
        private TableLayoutPanel tableLayoutPanel3;
        public CustomControl.RJCircularPictureBox rjCircularPictureBox1;
        private System.Windows.Forms.Timer timer2;
        private TableLayoutPanel tableLayoutPanel7;
        private FontAwesome.Sharp.IconButton resetButton;
    }
}