using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
 
        public class CustomButton : Button
        {
            //Fields
            private int borderSize = 0;
            private int borderRadius = 40;
            private Color borderColor = Color.PaleVioletRed;

            [Category("RJ Code Advanced")]
            public int BorderSize
            {
                get {
                    return borderSize; 
                    }
                set
                    {
                        borderSize = value;
                        this.Invalidate();
                    }
            }
            [Category("RJ Code Advanced")]
            public int BorderRadius
            {
                get => borderRadius; 
            set
                {
                    if (value <= this.Height)
                        borderRadius = value;
                    else borderRadius = this.Height;

                    this.Invalidate();
                }
            }
            [Category("RJ Code Advanced")]
            public Color BorderColor
            {
                get => borderColor;
                set
                {
                    borderColor = value;
                    this.Invalidate();
                }
            }

            [Category("RJ Code Advanced")]
            public Color BackgroundColor
            {
            get => this.BackColor;
                set { this.BackColor = value; }
            }

            [Category("RJ Code Advanced")]
            public Color TextColor
            {
                get { return this.ForeColor; }
                set { this.ForeColor = value; }
            }

            //Constructor
            public CustomButton()
            {
                this.FlatStyle = FlatStyle.Flat;
                this.FlatAppearance.BorderSize = 0;
                this.Size = new Size(150, 40);
                this.BackColor = Color.MediumSlateBlue;
                this.ForeColor = Color.White;
                this.Font = new Font("Century Gothic", 12, FontStyle.Regular);
                this.Resize += new EventHandler(Button_Resize);
            }

            //Methods
            private GraphicsPath GetFigurePath(Rectangle rect, float radius)
            {
                GraphicsPath path = new GraphicsPath();
                path.StartFigure();
                path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                path.AddArc(rect.Width - radius, rect.Y, radius, radius, 270, 90);
                path.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90);
                path.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90);
                path.CloseFigure();

                return path;
            }

            protected override void OnPaint(PaintEventArgs pevent)
            {
                base.OnPaint(pevent);
                pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                RectangleF rectSurface = new RectangleF(0, 0, this.Width, this.Height);
                RectangleF rectBorder = new RectangleF(1, 1, this.Width - 0.8F, this.Height - 1);

                Rectangle rectSurfaceRound = Rectangle.Round(rectSurface);

                GraphicsPath pathSurface = GetFigurePath(rectSurfaceRound, borderRadius);


                if (borderRadius > 2) //Rounded Button
                {
                    using (pathSurface = GetFigurePath(rectSurfaceRound, borderRadius))
                    using (GraphicsPath pathBorder = GetFigurePath(rectSurfaceRound, borderRadius))
                    using (Pen penSurface = new Pen(this.Parent.BackColor, 2))
                    using (Pen penBorder = new Pen(borderColor, 2))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        //Button Surface
                        this.Region = new Region(pathSurface);
                        // Draw surface border for HD result
                        pevent.Graphics.DrawPath(penSurface, pathSurface);
                        //Button Border
                        if (borderRadius >= 1)
                        {
                            //Draw button border
                            pevent.Graphics.DrawPath(penBorder, pathBorder);
                        }
                    }
                }
                else //Normal Button
                {
                    //Button Surface
                    this.Region = new Region(rectSurface);
                    //Button border
                    if (borderSize >= 1)
                    {
                        using (Pen penBorder = new Pen(borderColor, borderSize))
                        {
                            penBorder.Alignment = PenAlignment.Inset;
                            pevent.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                        }
                    }
                }
            }
            protected override void OnHandleCreated(EventArgs e)
            {
                base.OnHandleCreated(e);
                this.Parent.BackColorChanged += new EventHandler(Container_BackcolorChanged);
            }

            private void Container_BackcolorChanged(object sender, EventArgs e)
            {
                if (this.DesignMode)
                    this.Invalidate();
            }
            private void Button_Resize(object sender, EventArgs e)
            {
                if (borderRadius > this.Height)
                    borderRadius = this.Height;
            }
        }

    }

