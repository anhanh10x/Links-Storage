using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Gui.CustomControl
{
    public class MyCustomCheckBox : CheckBox
    {
        //Field
        private Color colorCharacter;
        private Color borderColor;
        private int borderSize;
        private string character;
        private int fontSize;
        private string fontType;
        private bool isMouseEnter = false;
        //Properties
        public Color ColorCharacter
        {
            get { return this.colorCharacter; }
            set { this.colorCharacter = value; this.Invalidate(); }
        }
        public Color BorderColor
        {
            get { return this.borderColor; }
            set { this.borderColor = value; this.Invalidate(); }
        }
        public int BorderSize
        {
            get { return this.borderSize; }
            set { this.borderSize = value; this.Invalidate(); }
        }
        public string Character
        {
            get { return this.character; }
            set { this.character = value; this.Invalidate(); }
        }
        public int FontSize
        {
            get { return this.fontSize; }
            set { this.fontSize = value; this.Invalidate(); }
        }
        public string FontType
        {
            get { return this.fontType; }
            set { this.fontType = value; this.Invalidate(); }
        }
        public bool IsMouseEnter
        {
            get { return this.isMouseEnter; }
            set { this.isMouseEnter = value; }
        }
        //Contructor
        public MyCustomCheckBox()
        {
            this.colorCharacter = Color.Green;
            this.borderColor = Color.Black;
            this.borderSize = 1;
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.fontType= "Segoe UI Emoji";
            this.fontSize = 7;
            this.AutoSize = false;
            this.Text = "";
            this.Size = new Size(20, 20);
            this.MinimumSize = new Size(15, 15);
            this.character = "✔️";
            this.Resize += this.CheckBox_Resize;
        }
        //Method
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.Clear(this.BackColor);
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            Bitmap bitmap = new Bitmap(this.Width, this.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            bitmap.MakeTransparent();
            Graphics graph = Graphics.FromImage(bitmap);
            GraphicsPath path = new GraphicsPath();
            Rectangle OuterRect = new Rectangle(1, 1, 20, 20);
            path.StartFigure();
            path.AddEllipse(OuterRect);
            path.CloseFigure();
            Font font = new Font(FontType, FontSize);
            pevent.Graphics.FillPath(new SolidBrush(this.BackColor),path);
            if(BorderSize>0)
                pevent.Graphics.DrawPath(new Pen(BorderColor, BorderSize), path);
            if (this.Checked == true)
                pevent.Graphics.DrawString(Character, font, new SolidBrush(this.ColorCharacter), 1, 2);
            if (this.IsMouseEnter == true  && this.Checked == false)
                pevent.Graphics.FillEllipse(new SolidBrush(this.ColorCharacter), Rectangle.Inflate(OuterRect, -4, -4));
            this.BackgroundImage = bitmap;
            graph.Dispose();
        }
        private void CheckBox_Resize(object sender, EventArgs e)
        {
            this.Height = this.Width;
            this.Width = this.Height;
        }
        
    }
}