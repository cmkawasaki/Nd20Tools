using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace TacmapGenerator
{
    public partial class TacmapFrame : UserControl
    {
        public TacmapView tacmapView1;

        private int widthTiles;
        public int WidthTiles
        {
            get
            {
                return widthTiles;
            }
            set
            {
                widthTiles = value;
                //tacmapView1.ResizeControl(widthTiles, heightTiles);
            }
        }

        private int heightTiles;
        public int HeightTiles
        {
            get
            {
                return heightTiles;
            }
            set
            {
                heightTiles = value;
                //tacmapView1.ResizeControl(widthTiles, heightTiles);
            }
        }

        public TacmapFrame()
            : this(10, 10)
        {

        }

        public TacmapFrame(int widthTiles, int heightTiles)
        {
            InitializeComponent();
            WidthTiles = widthTiles;
            HeightTiles = heightTiles;

            tacmapView1 = new TacmapView(widthTiles, heightTiles);
            this.Controls.Add(tacmapView1);

            this.Width = tacmapView1.Width + 30;
            this.Height = tacmapView1.Height + 30;

            tacmapView1.Location = new Point(30, 0);

            this.InvokePaint(this, new PaintEventArgs(this.CreateGraphics(), this.DisplayRectangle));
        }

        public void ResizeControl(int _widthTiles, int _heightTiles)
        {
            this.WidthTiles = _widthTiles;
            this.HeightTiles = _heightTiles;

            tacmapView1.ResizeControl(this.WidthTiles, this.HeightTiles);

            this.Width = tacmapView1.Width + 30;
            this.Height = tacmapView1.Height + 30;

            tacmapView1.Location = new Point(30, 0);

            this.InvokePaint(this, new PaintEventArgs(this.CreateGraphics(), this.DisplayRectangle));
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics graphics = this.CreateGraphics();

            //Make vertical markings
            for (int i = 0; i < widthTiles; i++)
            {
                string itemToPrint = Number2String(i, true);
                graphics.DrawString(itemToPrint, new System.Drawing.Font(FontFamily.GenericMonospace, 12f), Brushes.Black, new PointF(i * 25 + 34, tacmapView1.Height + 3));
            }

            //Make Horizontal markings


            for (int i = 0; i < heightTiles; i++)
            {
                string itemToPrint = i.ToString("00");
                graphics.DrawString(itemToPrint, new System.Drawing.Font(FontFamily.GenericMonospace, 12f), Brushes.Black, new PointF(0, i * 25 + 3));
            }

            graphics.Save();
            graphics.Dispose();
        }

        private String Number2String(int number, bool isCaps)
        {
            Char c = (Char)((isCaps ? 65 : 97) + (number));

            return c.ToString();
        }
    }
}
