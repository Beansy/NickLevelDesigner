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
        public Image theseus = Image.FromFile("D:/CPIT/BCPR283/NickDesign/NickLevelDesigner/Resources/Images/Theseus.jpg");
        public Image minotaur = Image.FromFile("D:/CPIT/BCPR283/NickDesign/NickLevelDesigner/Resources/Images/Minotaur.jpg");
        public bool theseusPictureClicked = false;
        public bool minotaurPictureClicked = false;
        public Map theMap;
        public MapBuilder mapBuilder;
        public Drawer drawer;
        public MouseHandler myMouseHandler;
        
        public Form1()
        {
            InitializeComponent();
            this.PictureBoxHeight = pictureBox1.Height;
            this.PictureBoxWidth = pictureBox1.Width;
            this.pictureBoxTheseus.Image = this.theseus;
            this.pictureBoxMinotaur.Image = this.minotaur;
            myMouseHandler = new MouseHandler();
            drawer = new Drawer();
            mapBuilder = new MapBuilder();
            
        }
        private void paintMap()
        {
            
            drawer.constructGrid(pictureBox1, theMap);
        }

        private void constructMap()
        {
            
            mapBuilder.construct(this.PictureBoxHeight,this.PictureBoxWidth,  this.numberOfColumnsInput, this.numberOfRowsInput);
            this.theMap = mapBuilder.returnMap();
            this.paintMap();
            this.mapDrawn = true;
            
        }

        private void pictureBox1_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (this.mapDrawn == true)
            {
                myMouseHandler.onMouseHover(e, this.theMap);
                this.paintMap();
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
                myMouseHandler.onMouseClick(e, this.theMap, this.theseusPictureClicked, this.minotaurPictureClicked);
            }
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            if (this.mapDrawn == true)
            {
                myMouseHandler.onDoubleClick(theMap);
            }
        }

        private void pictureBoxTheseus_Click(object sender, EventArgs e)
        {
            if (this.theseusPictureClicked == false && this.minotaurPictureClicked == false)
            {
                this.theseusPictureClicked = true;
                this.thesuesImageBackPanel.BackColor = Color.Orange;
            }
            else
            {
                this.theseusPictureClicked = false;
                this.thesuesImageBackPanel.BackColor = Color.Empty;
            }
        }

        private void pictureBoxMinotaur_Click(object sender, EventArgs e)
        {
            if (this.minotaurPictureClicked == false && this.theseusPictureClicked == false)
            {
                this.minotaurPictureClicked = true;
                this.minotaurImageBackPanel.BackColor = Color.Orange;
            }
            else
            {
                this.minotaurPictureClicked = false;
                this.minotaurImageBackPanel.BackColor = Color.Empty;
            }
        }
 
    }
}
