namespace Gui.FormChild
{
    partial class ALinkNode
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ALinkNode));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.moreOptionButton = new FontAwesome.Sharp.IconButton();
            this.MoreOption = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.linkInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeSubjectNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pinToTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.TitileLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.MoreOption.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.moreOptionButton, 2, 0);
            this.tableLayoutPanel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(234, 95);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ALinkNode_MouseClick);
            this.tableLayoutPanel1.MouseEnter += new System.EventHandler(this.ALinkNode_MouseEnter);
            this.tableLayoutPanel1.MouseLeave += new System.EventHandler(this.ALinkNode_MouseLeave);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.pictureBox, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(46, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(140, 95);
            this.tableLayoutPanel2.TabIndex = 0;
            this.tableLayoutPanel2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ALinkNode_MouseClick);
            this.tableLayoutPanel2.MouseEnter += new System.EventHandler(this.ALinkNode_MouseEnter);
            this.tableLayoutPanel2.MouseLeave += new System.EventHandler(this.ALinkNode_MouseLeave);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(3, 7);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(134, 65);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ALinkNode_MouseClick);
            this.pictureBox.MouseEnter += new System.EventHandler(this.ALinkNode_MouseEnter);
            this.pictureBox.MouseLeave += new System.EventHandler(this.ALinkNode_MouseLeave);
            // 
            // moreOptionButton
            // 
            this.moreOptionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.moreOptionButton.BackColor = System.Drawing.Color.Transparent;
            this.moreOptionButton.ContextMenuStrip = this.MoreOption;
            this.moreOptionButton.FlatAppearance.BorderSize = 0;
            this.moreOptionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.moreOptionButton.IconChar = FontAwesome.Sharp.IconChar.Buffer;
            this.moreOptionButton.IconColor = System.Drawing.Color.Black;
            this.moreOptionButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.moreOptionButton.IconSize = 25;
            this.moreOptionButton.Location = new System.Drawing.Point(189, 3);
            this.moreOptionButton.Name = "moreOptionButton";
            this.moreOptionButton.Size = new System.Drawing.Size(42, 29);
            this.moreOptionButton.TabIndex = 1;
            this.moreOptionButton.UseVisualStyleBackColor = false;
            this.moreOptionButton.Click += new System.EventHandler(this.iconButton1_Click);
            this.moreOptionButton.MouseEnter += new System.EventHandler(this.ALinkNode_MouseEnter);
            this.moreOptionButton.MouseLeave += new System.EventHandler(this.ALinkNode_MouseLeave);
            // 
            // MoreOption
            // 
            this.MoreOption.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MoreOption.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.linkInformationToolStripMenuItem,
            this.changeSubjectNameToolStripMenuItem,
            this.pinToTopToolStripMenuItem});
            this.MoreOption.Name = "contextMenuStrip1";
            this.MoreOption.Size = new System.Drawing.Size(211, 76);
            this.MoreOption.Opening += new System.ComponentModel.CancelEventHandler(this.MoreOption_Opening);
            this.MoreOption.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MoreOption_ItemClicked);
            this.MoreOption.MouseEnter += new System.EventHandler(this.ALinkNode_MouseEnter);
            this.MoreOption.MouseLeave += new System.EventHandler(this.ALinkNode_MouseLeave);
            // 
            // linkInformationToolStripMenuItem
            // 
            this.linkInformationToolStripMenuItem.Name = "linkInformationToolStripMenuItem";
            this.linkInformationToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.linkInformationToolStripMenuItem.Text = " Link Information";
            // 
            // changeSubjectNameToolStripMenuItem
            // 
            this.changeSubjectNameToolStripMenuItem.Name = "changeSubjectNameToolStripMenuItem";
            this.changeSubjectNameToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.changeSubjectNameToolStripMenuItem.Text = "Change information";
            // 
            // pinToTopToolStripMenuItem
            // 
            this.pinToTopToolStripMenuItem.Name = "pinToTopToolStripMenuItem";
            this.pinToTopToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.pinToTopToolStripMenuItem.Text = "Pin to top";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 96F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel3.Controls.Add(this.TitileLabel, 1, 0);
            this.tableLayoutPanel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 95);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(234, 60);
            this.tableLayoutPanel3.TabIndex = 1;
            this.tableLayoutPanel3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ALinkNode_MouseClick);
            this.tableLayoutPanel3.MouseEnter += new System.EventHandler(this.ALinkNode_MouseEnter);
            this.tableLayoutPanel3.MouseLeave += new System.EventHandler(this.ALinkNode_MouseLeave);
            // 
            // TitileLabel
            // 
            this.TitileLabel.BackColor = System.Drawing.Color.Transparent;
            this.TitileLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TitileLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TitileLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TitileLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TitileLabel.ForeColor = System.Drawing.Color.Black;
            this.TitileLabel.Location = new System.Drawing.Point(7, 0);
            this.TitileLabel.Name = "TitileLabel";
            this.TitileLabel.Size = new System.Drawing.Size(218, 60);
            this.TitileLabel.TabIndex = 0;
            this.TitileLabel.Text = "label1";
            this.TitileLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TitileLabel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ALinkNode_MouseClick);
            this.TitileLabel.MouseEnter += new System.EventHandler(this.ALinkNode_MouseEnter);
            this.TitileLabel.MouseLeave += new System.EventHandler(this.ALinkNode_MouseLeave);
            // 
            // ALinkNode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Name = "ALinkNode";
            this.Size = new System.Drawing.Size(234, 155);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ALinkNode_MouseClick);
            this.MouseEnter += new System.EventHandler(this.ALinkNode_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.ALinkNode_MouseLeave);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.MoreOption.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private PictureBox pictureBox;
        private TableLayoutPanel tableLayoutPanel3;
        private Label TitileLabel;
        private FontAwesome.Sharp.IconButton moreOptionButton;
        private ContextMenuStrip MoreOption;
        private ToolStripMenuItem changeSubjectNameToolStripMenuItem;
        private ToolStripMenuItem pinToTopToolStripMenuItem;
        private ToolStripMenuItem linkInformationToolStripMenuItem;
    }
}
