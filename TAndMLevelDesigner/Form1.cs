using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TAndMLevelDesigner
{
    
    public partial class Form1 : Form
    {
        bool mapDrawn = false;
        public int numberOfRowsInput { get; set; }
        public int numberOfColumnsInput { get; set; }
        public int PictureBoxHeight;
        public int PictureBoxWidth;
        public Map theMap;
        public MapBuilder mapBuilder;
        public Drawer drawer;
        public MouseHandler myMouseHandler;
        
        public Form1()
        {
            InitializeComponent();
            this.PictureBoxHeight = pictureBox1.Height;
            this.PictureBoxWidth = pictureBox1.Width;
            myMouseHandler = new MouseHandler();
            
        }
        private void paintMap()
        {
            drawer = new Drawer();
            drawer.constructGrid(pictureBox1, theMap);
        }

        private void constructMap()
        {
            mapBuilder = new MapBuilder();
            mapBuilder.construct(this.PictureBoxHeight,this.PictureBoxWidth,  this.numberOfColumnsInput, this.numberOfRowsInput);
            this.theMap = mapBuilder.returnMap();
            this.paintMap();
            this.mapDrawn = true;
            pictureBox1.Invalidate();
        }

        private void pictureBox1_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (this.mapDrawn == true)
            {
                myMouseHandler.onMouseHover(e, this.theMap);
                this.paintMap();
                pictureBox1.Invalidate();
            }
        }

        private void btnChangeSize_Click(object sender, EventArgs e)
        {
            this.numberOfRowsInput = Convert.ToInt32(txtRows.Text);
            this.numberOfColumnsInput = Convert.ToInt32(txtColumns.Text);
            txtColumns.Clear();
            txtRows.Clear();
            this.constructMap();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (this.mapDrawn == true)
            {
                myMouseHandler.onMouseClick(e, this.theMap);
            }
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            myMouseHandler.onDoubleClick(theMap);
        }
 
    }
}
