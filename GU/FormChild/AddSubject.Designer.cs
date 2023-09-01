namespace Gui.FormChild
{
    partial class AddSubjet
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
            this.TurnOff = new FontAwesome.Sharp.IconButton();
            this.ChooseColor = new FontAwesome.Sharp.IconButton();
            this.SaveButton = new FontAwesome.Sharp.IconButton();
            this.TitileLabel = new System.Windows.Forms.Label();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.IconCombobox = new System.Windows.Forms.ComboBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.NameBox = new Gui.CustomControl.CustomTextBox();
            this.SemesterBox = new Gui.CustomControl.CustomTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
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
            this.TurnOff.Location = new System.Drawing.Point(319, 0);
            this.TurnOff.Margin = new System.Windows.Forms.Padding(0);
            this.TurnOff.Name = "TurnOff";
            this.TurnOff.Size = new System.Drawing.Size(38, 36);
            this.TurnOff.TabIndex = 4;
            this.TurnOff.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.TurnOff.UseVisualStyleBackColor = false;
            this.TurnOff.Click += new System.EventHandler(this.TurnOff_Click);
            // 
            // ChooseColor
            // 
            this.ChooseColor.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ChooseColor.FlatAppearance.BorderSize = 0;
            this.ChooseColor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.ChooseColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChooseColor.ForeColor = System.Drawing.Color.Transparent;
            this.ChooseColor.IconChar = FontAwesome.Sharp.IconChar.PaintBrush;
            this.ChooseColor.IconColor = System.Drawing.Color.White;
            this.ChooseColor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ChooseColor.IconSize = 25;
            this.ChooseColor.Location = new System.Drawing.Point(46, 272);
            this.ChooseColor.Margin = new System.Windows.Forms.Padding(0);
            this.ChooseColor.Name = "ChooseColor";
            this.ChooseColor.Size = new System.Drawing.Size(135, 37);
            this.ChooseColor.TabIndex = 9;
            this.ChooseColor.Text = "Choose color";
            this.ChooseColor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ChooseColor.UseVisualStyleBackColor = false;
            this.ChooseColor.Click += new System.EventHandler(this.ChooseColor_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.LightSlateGray;
            this.SaveButton.FlatAppearance.BorderSize = 0;
            this.SaveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.ForeColor = System.Drawing.Color.Transparent;
            this.SaveButton.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.SaveButton.IconColor = System.Drawing.Color.White;
            this.SaveButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SaveButton.IconSize = 25;
            this.SaveButton.Location = new System.Drawing.Point(109, 330);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(0);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(135, 37);
            this.SaveButton.TabIndex = 10;
            this.SaveButton.Text = "Save subject";
            this.SaveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // TitileLabel
            // 
            this.TitileLabel.AutoSize = true;
            this.TitileLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(145)))));
            this.TitileLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TitileLabel.ForeColor = System.Drawing.Color.White;
            this.TitileLabel.Location = new System.Drawing.Point(82, 0);
            this.TitileLabel.Name = "TitileLabel";
            this.TitileLabel.Size = new System.Drawing.Size(201, 36);
            this.TitileLabel.TabIndex = 11;
            this.TitileLabel.Text = "Create a new subject";
            this.TitileLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TitileLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Titile_MouseDown);
            this.TitileLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Titile_MouseMove);
            this.TitileLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Titile_MouseUp);
            // 
            // ColorLabel
            // 
            this.ColorLabel.Location = new System.Drawing.Point(187, 282);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(15, 15);
            this.ColorLabel.TabIndex = 12;
            // 
            // IconCombobox
            // 
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
            this.IconCombobox.Location = new System.Drawing.Point(46, 222);
            this.IconCombobox.Margin = new System.Windows.Forms.Padding(0);
            this.IconCombobox.Name = "IconCombobox";
            this.IconCombobox.Size = new System.Drawing.Size(236, 31);
            this.IconCombobox.TabIndex = 13;
            this.IconCombobox.Text = "Icon choice";
            this.IconCombobox.SelectionChangeCommitted += new System.EventHandler(this.IconCombobox_SelectionChangeCommitted);
            this.IconCombobox.TextUpdate += new System.EventHandler(this.IconCombobox_TextUpdate);
            this.IconCombobox.SelectedValueChanged += new System.EventHandler(this.IconCombobox_SelectedValueChanged);
            this.IconCombobox.TextChanged += new System.EventHandler(this.IconCombobox_TextChanged);
            this.IconCombobox.Enter += new System.EventHandler(this.IconCombobox_Enter);
            this.IconCombobox.Leave += new System.EventHandler(this.IconCombobox_Leave);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 31;
            this.iconPictureBox1.Location = new System.Drawing.Point(285, 222);
            this.iconPictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(31, 31);
            this.iconPictureBox1.TabIndex = 14;
            this.iconPictureBox1.TabStop = false;
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
            this.panel1.TabIndex = 15;
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(319, 36);
            this.tableLayoutPanel1.TabIndex = 5;
            this.tableLayoutPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Titile_MouseDown);
            this.tableLayoutPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Titile_MouseMove);
            this.tableLayoutPanel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Titile_MouseUp);
            // 
            // NameBox
            // 
            this.NameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.NameBox.BorderColor = System.Drawing.Color.LightGray;
            this.NameBox.BorderFocusColor = System.Drawing.Color.White;
            this.NameBox.BorderSize = 2;
            this.NameBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NameBox.ForeColor = System.Drawing.Color.SteelBlue;
            this.NameBox.IsBlankText = true;
            this.NameBox.IsFocus = false;
            this.NameBox.IsLoseText = true;
            this.NameBox.Location = new System.Drawing.Point(46, 92);
            this.NameBox.LoseFocusColor = System.Drawing.Color.LightGray;
            this.NameBox.Margin = new System.Windows.Forms.Padding(0);
            this.NameBox.Multiline = false;
            this.NameBox.Name = "NameBox";
            this.NameBox.Padding = new System.Windows.Forms.Padding(7);
            this.NameBox.PasswordChar = false;
            this.NameBox.Radius = 8;
            this.NameBox.Size = new System.Drawing.Size(270, 42);
            this.NameBox.TabIndex = 16;
            this.NameBox.Texs = "Titile";
            this.NameBox.textBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.NameBox.TextGround = "Titile";
            this.NameBox.TextGroundColor = System.Drawing.Color.IndianRed;
            this.NameBox.TextWidth = 250;
            this.NameBox.UnderlinedStyle = false;
            // 
            // SemesterBox
            // 
            this.SemesterBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SemesterBox.BorderColor = System.Drawing.Color.LightGray;
            this.SemesterBox.BorderFocusColor = System.Drawing.Color.White;
            this.SemesterBox.BorderSize = 2;
            this.SemesterBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SemesterBox.ForeColor = System.Drawing.Color.SteelBlue;
            this.SemesterBox.IsBlankText = true;
            this.SemesterBox.IsFocus = false;
            this.SemesterBox.IsLoseText = true;
            this.SemesterBox.Location = new System.Drawing.Point(46, 157);
            this.SemesterBox.LoseFocusColor = System.Drawing.Color.LightGray;
            this.SemesterBox.Margin = new System.Windows.Forms.Padding(0);
            this.SemesterBox.Multiline = false;
            this.SemesterBox.Name = "SemesterBox";
            this.SemesterBox.Padding = new System.Windows.Forms.Padding(7);
            this.SemesterBox.PasswordChar = false;
            this.SemesterBox.Radius = 8;
            this.SemesterBox.Size = new System.Drawing.Size(270, 42);
            this.SemesterBox.TabIndex = 17;
            this.SemesterBox.Texs = "Semester";
            this.SemesterBox.textBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SemesterBox.TextGround = "Semester";
            this.SemesterBox.TextGroundColor = System.Drawing.Color.IndianRed;
            this.SemesterBox.TextWidth = 250;
            this.SemesterBox.UnderlinedStyle = false;
            // 
            // AddSubjet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(357, 395);
            this.Controls.Add(this.SemesterBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.IconCombobox);
            this.Controls.Add(this.ColorLabel);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.ChooseColor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddSubjet";
            this.Text = "AddSubjet";
            this.Load += new System.EventHandler(this.AddSubjet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton TurnOff;
        private FontAwesome.Sharp.IconButton ChooseColor;
        private FontAwesome.Sharp.IconButton SaveButton;
        private Label ColorLabel;
        private ComboBox IconCombobox;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        public Label TitileLabel;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        public CustomControl.CustomTextBox NameBox;
        public CustomControl.CustomTextBox SemesterBox;
    }
}