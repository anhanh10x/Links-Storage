using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gui.CustomControl
{
    public partial class CustomTextBox : UserControl
    {
        //Fields
        private int radius = 1;
        
        private Color borderColor = Color.MediumSlateBlue;
        private int borderSize = 2;
        private bool underlinedStyle = false;
        private Color borderFocusColor = Color.HotPink;
        private bool isFocused = false;
        private string textGround="Nothing";
        private Color textGroundColor = Color.FloralWhite;
        private bool isBlankText = true;
        private Color loseFocusColor = Color.DarkGray;

        private bool isLoseText = true;
        public bool IsLoseText
        {
            get { return isLoseText; }
            set { isLoseText = value; }
        }
        public Color LoseFocusColor
        {
            get { return loseFocusColor; }
            set { loseFocusColor = value; }
        }
        public Color textBackColor
        {
            get { return this.textBox1.BackColor; }
            set { this.textBox1.BackColor = value; this.Invalidate(); }
        }
        public int TextWidth
        {
            get { return this.textBox1.Width; }
            set { this.textBox1.Width = value; this.textBox1.Invalidate(); }
        }

        //Constructor
        public CustomTextBox()
        {
            InitializeComponent();
        }
        //Properties
        [Category("RJ Code Advance")]
        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }
        [Category("RJ Code Advance")]
        public int BorderSize
        {
            get { return borderSize; }
            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }

        [Category("RJ Code Advance")]
        public bool UnderlinedStyle
        {
            get { return underlinedStyle; }
            set
            {
                underlinedStyle = value;
                this.Invalidate();
            }
        }
        public int Radius
        {
            get { return this.radius; }
            set { this.radius = value; this.Invalidate(); }
        }
        [Category("RJ Code Advance")]
        public bool PasswordChar
        {
            get { return textBox1.UseSystemPasswordChar; }
            set { textBox1.UseSystemPasswordChar = value; }
        }

        [Category("RJ Code Advance")]
        public bool Multiline
        {
            get { return textBox1.Multiline; }
            set { textBox1.Multiline = value; }
        }

 
        [Category("RJ Code Advance")]
        public override Color ForeColor
        {
            get { return base.ForeColor; }
            set
            {
                base.ForeColor = value;
                textBox1.ForeColor = value;
            }
        }

        [Category("RJ Code Advance")]
        public override Font Font
        {
            get { return base.Font; }
            set
            {
                base.Font = value;
                textBox1.Font = value;
                if (this.DesignMode)
                    UpdateControlHeight();
            }
        }
        [Category("RJ Code Advance")]
        public Color BorderFocusColor
        {
            get { return borderFocusColor; }
            set { borderFocusColor = value; }
        }
        public string TextGround
        {
            get { return this.textGround; }
            set { this.textGround = value; }
        }
        public bool IsFocus
        {
            get { return this.isFocused; }
            set { this.isFocused = value; }
        }
        public Color TextGroundColor
        {
            get { return this.textGroundColor; }
            set { this.textGroundColor = value; }
        }
        public string Texs
        {
            get { return this.textBox1.Text; }
            set { this.textBox1.Text = value;}
        }

        public bool IsBlankText { get => isBlankText; set => isBlankText = value; }

        //Overridden methods

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;
            //Draw border
            Pen penBorder = new Pen(borderColor, borderSize);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.Clear(this.Parent.BackColor);
            Rectangle motherRect = new Rectangle(0, 0, this.Width-2, this.Height-2);
            penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(new Rectangle(0, 0, this.Radius * 2, this.Radius * 2), 180, 90);
            path.AddArc(new Rectangle(motherRect.Width - this.Radius * 2, 0, this.Radius * 2, this.Radius * 2), 270, 90);
            path.AddArc(new Rectangle(motherRect.Width - this.Radius * 2, motherRect.Height - this.Radius * 2, this.Radius * 2, this.Radius * 2), 0, 90);
            path.AddArc(new Rectangle(0, motherRect.Height - this.Radius * 2, this.Radius * 2, this.Radius * 2), 90, 90);
            path.CloseFigure();
            e.Graphics.DrawPath(new Pen(this.BorderColor, this.BorderSize), path);
            
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (this.DesignMode)
                UpdateControlHeight();
        }

        protected override void OnLoad(EventArgs e)
        {
            this.Texs = this.TextGround;
            base.OnLoad(e);
            UpdateControlHeight();
        }
        //Private methods
        private void UpdateControlHeight()
        {
            if (textBox1.Multiline == false)
            {
                int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 5;
                textBox1.Multiline = true;
                textBox1.MinimumSize = new Size(0, txtHeight);
                textBox1.Multiline = false;
                this.Height = textBox1.Height + this.Padding.Top + this.Padding.Bottom;
            }
        }
        //TextBox events
        private void textBox1_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            this.OnMouseEnter(e);
            this.Invalidate();
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            this.OnMouseLeave(e);
            this.Invalidate();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            isFocused = true;
            if(this.textBox1.Text == this.TextGround && this.isLoseText == true)
            {
                this.textBox1.Text = "";
                this.Texs = "";
                this.textBox1.Invalidate();
            }
            this.BorderColor = this.BorderFocusColor;
            
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            isFocused = false;
            this.BorderColor = this.LoseFocusColor;
            if(textBox1.Text=="")
            {
                this.IsBlankText = true;
                this.Texs = this.TextGround;
            }
            else
            {
                this.IsBlankText = false;
            }
            this.Invalidate();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            this.OnKeyDown(e);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.OnKeyPress(e);
        }
    }
}

