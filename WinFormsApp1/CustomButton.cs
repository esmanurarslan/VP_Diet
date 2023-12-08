using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace WinFormsApp1
{
    public class CustomButton : Button 
    {
        //Fields
        private int borderSize = 0;
        private int borderRadius = 40;
        private Color borderColor = Color.White;

        //Constructor
        public CustomButton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size= new Size(150, 40);
            this.BackColor = Color.FloralWhite;
            this.ForeColor = Color.Gray;

        }

        //Methods

        private GraphicsPath GetFigurePath(RectangleF rect, float radius) {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width-radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width-radius, rect.Height-radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height-radius, radius, radius, 90, 90);
            path.CloseFigure();
            return path;


        }
         protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            
            RectangleF recSurface = new RectangleF(0,0,this.Width,this.Height);
            RectangleF resBorder = new RectangleF(1,1,this.Width - 0.8F,this.Height-1);

            if(borderRadius > 2) //Rounded button
            {
                using (GraphicsPath pathSurface = GetFigurePath(recSurface, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(resBorder,borderRadius - 1F))
                using (Pen penSurface = new Pen(this.Parent.BackColor, 2))
                using (Pen penBorder = new Pen(borderColor,borderSize))
                {
                    penBorder.Alignment = PenAlignment.Inset;
                    this.Region = new Region(pathSurface);
                    
                    e.Graphics.DrawPath(penSurface, pathSurface);

                    if(borderSize >= 1) e.Graphics.DrawPath(penBorder, pathBorder);
                }
            }
            else // Normal button
            {
                //Button Surface
                this.Region = new Region(recSurface);
                //Button border
                if(borderSize >= 1)
                {
                    using (Pen penBorder = new Pen(borderColor, borderSize))
                    {
                        penBorder.Alignment= PenAlignment.Inset;
                        e.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
            }
         }
         protected override void OnHandleCreated(EventArgs e)
         {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
         }

        private void Container_BackColorChanged(object? sender, EventArgs e)
        {
            if (this.DesignMode) this.Invalidate();
        }
    }
}
