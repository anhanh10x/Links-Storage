namespace Gui.FormChild
{
    partial class AddLink
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
            this.IconCombobox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SaveButton = new FontAwesome.Sharp.IconButton();
            this.UrlBox = new Gui.CustomControl.CustomTextBox();
            this.NameBox = new Gui.CustomControl.CustomTextBox();
            this.TurnOff = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // IconCombobox
            // 
            this.IconCombobox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IconCombobox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.IconCombobox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.IconCombobox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.IconCombobox.DropDownHeight = 100;
            this.IconCombobox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IconCombobox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.IconCombobox.ForeColor = System.Drawing.Color.SteelBlue;
            this.IconCombobox.FormattingEnabled = true;
            this.IconCombobox.IntegralHeight = false;
            this.IconCombobox.ItemHeight = 23;
            this.IconCombobox.Location = new System.Drawing.Point(46, 219);
            this.IconCombobox.Margin = new System.Windows.Forms.Padding(0);
            this.IconCombobox.Name = "IconCombobox";
            this.IconCombobox.Size = new System.Drawing.Size(236, 31);
            this.IconCombobox.TabIndex = 23;
            this.IconCombobox.Text = "Icon choice";
            this.IconCombobox.SelectionChangeCommitted += new System.EventHandler(this.IconCombobox_SelectionChangeCommitted);
            this.IconCombobox.SelectedValueChanged += new System.EventHandler(this.IconCombobox_SelectedValueChanged);
            this.IconCombobox.Click += new System.EventHandler(this.IconCombobox_Click);
            this.IconCombobox.Enter += new System.EventHandler(this.IconCombobox_Enter);
            this.IconCombobox.Leave += new System.EventHandler(this.IconCombobox_Leave);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(145)))));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(98, -50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Create a new subject";
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.BackColor = System.Drawing.Color.LightSlateGray;
            this.SaveButton.FlatAppearance.BorderSize = 0;
            this.SaveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.ForeColor = System.Drawing.Color.Transparent;
            this.SaveButton.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.SaveButton.IconColor = System.Drawing.Color.White;
            this.SaveButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SaveButton.IconSize = 25;
            this.SaveButton.Location = new System.Drawing.Point(110, 299);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(0);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(135, 37);
            this.SaveButton.TabIndex = 20;
            this.SaveButton.Text = "Save link";
            this.SaveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // UrlBox
            // 
            this.UrlBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UrlBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.UrlBox.BorderColor = System.Drawing.Color.LightGray;
            this.UrlBox.BorderFocusColor = System.Drawing.Color.White;
            this.UrlBox.BorderSize = 2;
            this.UrlBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UrlBox.ForeColor = System.Drawing.Color.SteelBlue;
            this.UrlBox.IsBlankText = true;
            this.UrlBox.IsFocus = false;
            this.UrlBox.IsLoseText = true;
            this.UrlBox.Location = new System.Drawing.Point(46, 153);
            this.UrlBox.LoseFocusColor = System.Drawing.Color.LightGray;
            this.UrlBox.Margin = new System.Windows.Forms.Padding(0);
            this.UrlBox.Multiline = false;
            this.UrlBox.Name = "UrlBox";
            this.UrlBox.Padding = new System.Windows.Forms.Padding(7);
            this.UrlBox.PasswordChar = false;
            this.UrlBox.Radius = 8;
            this.UrlBox.Size = new System.Drawing.Size(270, 42);
            this.UrlBox.TabIndex = 18;
            this.UrlBox.Texs = "Url";
            this.UrlBox.textBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.UrlBox.TextGround = "Url";
            this.UrlBox.TextGroundColor = System.Drawing.Color.IndianRed;
            this.UrlBox.TextWidth = 250;
            this.UrlBox.UnderlinedStyle = false;
            // 
            // NameBox
            // 
            this.NameBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.NameBox.BorderColor = System.Drawing.Color.LightGray;
            this.NameBox.BorderFocusColor = System.Drawing.Color.White;
            this.NameBox.BorderSize = 2;
            this.NameBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NameBox.ForeColor = System.Drawing.Color.SteelBlue;
            this.NameBox.IsBlankText = true;
            this.NameBox.IsFocus = false;
            this.NameBox.IsLoseText = true;
            this.NameBox.Location = new System.Drawing.Point(46, 85);
            this.NameBox.LoseFocusColor = System.Drawing.Color.LightGray;
            this.NameBox.Margin = new System.Windows.Forms.Padding(0);
            this.NameBox.Multiline = false;
            this.NameBox.Name = "NameBox";
            this.NameBox.Padding = new System.Windows.Forms.Padding(7);
            this.NameBox.PasswordChar = false;
            this.NameBox.Radius = 8;
            this.NameBox.Size = new System.Drawing.Size(270, 42);
            this.NameBox.TabIndex = 17;
            this.NameBox.Texs = "Titile";
            this.NameBox.textBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.NameBox.TextGround = "Titile";
            this.NameBox.TextGroundColor = System.Drawing.Color.IndianRed;
            this.NameBox.TextWidth = 250;
            this.NameBox.UnderlinedStyle = false;
            // 
            // TurnOff
            // 
            this.TurnOff.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TurnOff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(145)))));
            this.TurnOff.FlatAppearance.BorderSize = 0;
            this.TurnOff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.TurnOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TurnOff.ForeColor = System.Drawing.Color.Transparent;
            this.TurnOff.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.TurnOff.IconColor = System.Drawing.Color.White;
            this.TurnOff.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.TurnOff.IconSize = 25;
            this.TurnOff.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.TurnOff.Location = new System.Drawing.Point(319, -59);
            this.TurnOff.Margin = new System.Windows.Forms.Padding(0);
            this.TurnOff.Name = "TurnOff";
            this.TurnOff.Size = new System.Drawing.Size(38, 35);
            this.TurnOff.TabIndex = 16;
            this.TurnOff.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.TurnOff.UseVisualStyleBackColor = false;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(145)))));
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.Color.Transparent;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 25;
            this.iconButton1.Location = new System.Drawing.Point(336, 0);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(38, 33);
            this.iconButton1.TabIndex = 25;
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.TurnOff_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(145)))));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(84, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 33);
            this.label2.TabIndex = 26;
            this.label2.Text = "Create a new link";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Titile_MouseDown);
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Titile_MouseMove);
            this.label2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Titile_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(291, 218);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(374, 33);
            this.panel1.TabIndex = 28;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(145)))));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(336, 33);
            this.tableLayoutPanel1.TabIndex = 26;
            this.tableLayoutPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Titile_MouseDown);
            this.tableLayoutPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Titile_MouseMove);
            this.tableLayoutPanel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Titile_MouseUp);
            // 
            // AddLink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(374, 364);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.IconCombobox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.UrlBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.TurnOff);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddLink";
            this.Text = "AddLink";
            this.Load += new System.EventHandler(this.AddLink_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComboBox IconCombobox;
        private Label label1;
        private FontAwesome.Sharp.IconButton SaveButton;
        private FontAwesome.Sharp.IconButton TurnOff;
        private FontAwesome.Sharp.IconButton iconButton1;
        private PictureBox pictureBox1;
        public CustomControl.CustomTextBox UrlBox;
        public CustomControl.CustomTextBox NameBox;
        public Label label2;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
    }
}