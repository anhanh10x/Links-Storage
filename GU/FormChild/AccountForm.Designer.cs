namespace Gui.FormChild
{
    partial class AccountForm
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
            this.TitileLabel = new System.Windows.Forms.Label();
            this.Save = new FontAwesome.Sharp.IconButton();
            this.ImageButton = new FontAwesome.Sharp.IconButton();
            this.EmailBox = new Gui.CustomControl.CustomTextBox();
            this.NameBox = new Gui.CustomControl.CustomTextBox();
            this.IconCombobox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TurnOff = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitileLabel
            // 
            this.TitileLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TitileLabel.AutoSize = true;
            this.TitileLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(145)))));
            this.TitileLabel.ForeColor = System.Drawing.Color.White;
            this.TitileLabel.Location = new System.Drawing.Point(79, 0);
            this.TitileLabel.Margin = new System.Windows.Forms.Padding(0);
            this.TitileLabel.Name = "TitileLabel";
            this.TitileLabel.Size = new System.Drawing.Size(206, 36);
            this.TitileLabel.TabIndex = 21;
            this.TitileLabel.Text = "Create a new account";
            this.TitileLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TitileLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Titile_MouseDown);
            this.TitileLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Titile_MouseMove);
            this.TitileLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Titile_MouseUp);
            // 
            // Save
            // 
            this.Save.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Save.BackColor = System.Drawing.Color.LightSlateGray;
            this.Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Save.FlatAppearance.BorderSize = 0;
            this.Save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save.ForeColor = System.Drawing.Color.Transparent;
            this.Save.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.Save.IconColor = System.Drawing.Color.White;
            this.Save.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Save.IconSize = 25;
            this.Save.Location = new System.Drawing.Point(98, 338);
            this.Save.Margin = new System.Windows.Forms.Padding(0);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(135, 37);
            this.Save.TabIndex = 20;
            this.Save.Text = "Save account";
            this.Save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // ImageButton
            // 
            this.ImageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageButton.BackColor = System.Drawing.Color.Silver;
            this.ImageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImageButton.FlatAppearance.BorderSize = 0;
            this.ImageButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.ImageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImageButton.ForeColor = System.Drawing.Color.Transparent;
            this.ImageButton.IconChar = FontAwesome.Sharp.IconChar.Image;
            this.ImageButton.IconColor = System.Drawing.Color.White;
            this.ImageButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ImageButton.IconSize = 25;
            this.ImageButton.Location = new System.Drawing.Point(35, 271);
            this.ImageButton.Margin = new System.Windows.Forms.Padding(0);
            this.ImageButton.Name = "ImageButton";
            this.ImageButton.Size = new System.Drawing.Size(198, 37);
            this.ImageButton.TabIndex = 22;
            this.ImageButton.Text = "Choose Avatar";
            this.ImageButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ImageButton.UseVisualStyleBackColor = false;
            this.ImageButton.Click += new System.EventHandler(this.ImageButton_Click);
            // 
            // EmailBox
            // 
            this.EmailBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmailBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.EmailBox.BorderColor = System.Drawing.Color.LightGray;
            this.EmailBox.BorderFocusColor = System.Drawing.Color.White;
            this.EmailBox.BorderSize = 2;
            this.EmailBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EmailBox.ForeColor = System.Drawing.Color.SteelBlue;
            this.EmailBox.IsBlankText = true;
            this.EmailBox.IsFocus = false;
            this.EmailBox.IsLoseText = true;
            this.EmailBox.Location = new System.Drawing.Point(35, 158);
            this.EmailBox.LoseFocusColor = System.Drawing.Color.LightGray;
            this.EmailBox.Margin = new System.Windows.Forms.Padding(0);
            this.EmailBox.Multiline = false;
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Padding = new System.Windows.Forms.Padding(7);
            this.EmailBox.PasswordChar = false;
            this.EmailBox.Radius = 8;
            this.EmailBox.Size = new System.Drawing.Size(270, 42);
            this.EmailBox.TabIndex = 23;
            this.EmailBox.Texs = "Email";
            this.EmailBox.textBackColor = System.Drawing.SystemColors.Control;
            this.EmailBox.TextGround = "Email";
            this.EmailBox.TextGroundColor = System.Drawing.Color.IndianRed;
            this.EmailBox.TextWidth = 250;
            this.EmailBox.UnderlinedStyle = false;
            // 
            // NameBox
            // 
            this.NameBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameBox.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.NameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.NameBox.BorderColor = System.Drawing.Color.LightGray;
            this.NameBox.BorderFocusColor = System.Drawing.Color.White;
            this.NameBox.BorderSize = 2;
            this.NameBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NameBox.ForeColor = System.Drawing.Color.SteelBlue;
            this.NameBox.IsBlankText = true;
            this.NameBox.IsFocus = false;
            this.NameBox.IsLoseText = true;
            this.NameBox.Location = new System.Drawing.Point(35, 95);
            this.NameBox.LoseFocusColor = System.Drawing.Color.LightGray;
            this.NameBox.Margin = new System.Windows.Forms.Padding(0);
            this.NameBox.Multiline = false;
            this.NameBox.Name = "NameBox";
            this.NameBox.Padding = new System.Windows.Forms.Padding(7);
            this.NameBox.PasswordChar = false;
            this.NameBox.Radius = 8;
            this.NameBox.Size = new System.Drawing.Size(270, 42);
            this.NameBox.TabIndex = 25;
            this.NameBox.Texs = "Account name";
            this.NameBox.textBackColor = System.Drawing.SystemColors.Control;
            this.NameBox.TextGround = "Account name";
            this.NameBox.TextGroundColor = System.Drawing.Color.IndianRed;
            this.NameBox.TextWidth = 250;
            this.NameBox.UnderlinedStyle = false;
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
            this.IconCombobox.Location = new System.Drawing.Point(35, 220);
            this.IconCombobox.Margin = new System.Windows.Forms.Padding(0);
            this.IconCombobox.Name = "IconCombobox";
            this.IconCombobox.Size = new System.Drawing.Size(270, 31);
            this.IconCombobox.TabIndex = 26;
            this.IconCombobox.Text = "Your hobby";
            this.IconCombobox.Enter += new System.EventHandler(this.IconCombobox_Enter);
            this.IconCombobox.Leave += new System.EventHandler(this.IconCombobox_Leave);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.TurnOff);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(357, 36);
            this.panel1.TabIndex = 27;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(145)))));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.TitileLabel, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(318, 36);
            this.tableLayoutPanel1.TabIndex = 26;
            this.tableLayoutPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Titile_MouseDown);
            this.tableLayoutPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Titile_MouseMove);
            this.tableLayoutPanel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Titile_MouseUp);
            // 
            // TurnOff
            // 
            this.TurnOff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(145)))));
            this.TurnOff.Dock = System.Windows.Forms.DockStyle.Right;
            this.TurnOff.FlatAppearance.BorderSize = 0;
            this.TurnOff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.TurnOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TurnOff.ForeColor = System.Drawing.Color.Transparent;
            this.TurnOff.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.TurnOff.IconColor = System.Drawing.Color.White;
            this.TurnOff.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.TurnOff.IconSize = 25;
            this.TurnOff.Location = new System.Drawing.Point(318, 0);
            this.TurnOff.Margin = new System.Windows.Forms.Padding(0);
            this.TurnOff.Name = "TurnOff";
            this.TurnOff.Size = new System.Drawing.Size(39, 36);
            this.TurnOff.TabIndex = 25;
            this.TurnOff.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.TurnOff.UseVisualStyleBackColor = false;
            this.TurnOff.Click += new System.EventHandler(this.TurnOff_Click_1);
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 395);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.IconCombobox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.ImageButton);
            this.Controls.Add(this.Save);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AccountForm";
            this.Text = "AccountForm";
            this.Load += new System.EventHandler(this.AccountForm_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public Label TitileLabel;
        private FontAwesome.Sharp.IconButton Save;
        private FontAwesome.Sharp.IconButton ImageButton;
        public CustomControl.CustomTextBox EmailBox;
        public CustomControl.CustomTextBox NameBox;
        private ComboBox IconCombobox;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private FontAwesome.Sharp.IconButton TurnOff;
    }
}