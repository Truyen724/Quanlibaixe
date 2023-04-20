using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlibaixe.Custom_Toolbox
{
    [ToolboxBitmap(typeof(Button))]
    internal class ButtonS : Button
    {
        int bra = 20;
        StringAlignment ha = StringAlignment.Center;
        StringAlignment va = StringAlignment.Center;
        public StringAlignment HorizontalAlignment
        {
            get { return ha; }
            set { ha = value; Invalidate(); }
        }
        public StringAlignment VerticalAlignment
        {
            get { return va; }
            set { va = value; Invalidate(); }
        }
        public int BorderRadius
        {
            get { return bra; }
            set { bra = value; this.Invalidate(); }
        }
        public ButtonS() 
        { 
            BackColor = Color.White; ForeColor = Color.Black; Font = new Font("Segoe UI", 13, FontStyle.Bold); 
        }
        static int GetFontWidth(int textlength, Font font)
        {
            return textlength * (int)font.Size;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            // Draw default button
            base.OnPaint(e);
            // High quality smoothing mode
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            //Clear the Windows button graphics
            e.Graphics.Clear(Parent.BackColor);
            if (bra < 2)
            {
                SolidBrush s = new SolidBrush(BackColor);
                e.Graphics.FillRectangle(s, ClientRectangle);
            }
            else
            {
                GraphicsPath path = new GraphicsPath();
                path.AddArc(new Rectangle(0, 0, bra, bra), 180, 90);
                path.AddArc(new Rectangle(Width - bra, 0, bra, bra), -90, 90);
                path.AddArc(new Rectangle(Width - bra, Height - bra, bra, bra), 0, 90);
                path.AddArc(new Rectangle(0, Height - bra, bra, bra), 90, 90);
                e.Graphics.FillPath(new SolidBrush(BackColor), path);
            }
            // Draw text with his font
            e.Graphics.DrawString(Text, Font, new SolidBrush(ForeColor), ClientRectangle, new StringFormat() { LineAlignment = ha, Alignment = va });
            // If Image property is not null, draw image with his align
            if (Image != null)
            {
                if (ImageAlign == ContentAlignment.TopLeft)
                {
                    e.Graphics.DrawImage(Image, new Point(16, 16));
                }
                else if (ImageAlign == ContentAlignment.TopCenter)
                {
                    e.Graphics.DrawImage(Image, new Point(this.Width / 2 - Image.Width / 2, 16));
                }
                else if (ImageAlign == ContentAlignment.TopRight)
                {
                    e.Graphics.DrawImage(Image, new Point(this.Width - Image.Width - 16, 16));
                }
                else if (ImageAlign == ContentAlignment.MiddleLeft)
                {
                    e.Graphics.DrawImage(Image, new Point(16, this.Height / 2 - Image.Height / 2));
                }
                else if (ImageAlign == ContentAlignment.MiddleCenter)
                {
                    e.Graphics.DrawImage(Image, new Point(this.Width / 2 - Image.Width / 2, this.Height / 2 - Image.Height / 2));
                }
                else if (ImageAlign == ContentAlignment.MiddleRight)
                {
                    e.Graphics.DrawImage(Image, new Point(this.Width - Image.Width - 16, this.Height / 2 - Image.Height / 2));
                }
                else if (ImageAlign == ContentAlignment.BottomLeft)
                {
                    e.Graphics.DrawImage(Image, new Point(16, this.Height - Image.Height - 16));
                }
                else if (ImageAlign == ContentAlignment.BottomCenter)
                {
                    e.Graphics.DrawImage(Image, new Point(this.Width / 2 - Image.Width / 2, this.Height - Image.Height - 16));
                }
                else if (ImageAlign == ContentAlignment.BottomRight)
                {
                    e.Graphics.DrawImage(Image, new Point(this.Width - Image.Width - 16, this.Height - Image.Height - 16));
                }
            }
        }
    }
}
