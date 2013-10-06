using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public class Drawer
{
    public PictureBox thePictureBox;
    public Map theMap;
    public Image exit = Image.FromFile("D:/CPIT/BCPR283/NickDesign/NickLevelDesigner/Resources/Images/Exit.jpg");
    public Image theseus = Image.FromFile("D:/CPIT/BCPR283/NickDesign/NickLevelDesigner/Resources/Images/Theseus.jpg");
    public Image minotaur = Image.FromFile("D:/CPIT/BCPR283/NickDesign/NickLevelDesigner/Resources/Images/Minotaur.jpg");

	public Drawer()
	{
       
	}

    public void constructGrid(PictureBox thePictureBox, Map theMap)
    {
        this.thePictureBox = thePictureBox;
        this.theMap = theMap;
        thePictureBox.Invalidate();
        thePictureBox.Paint += new PaintEventHandler(paintGrid);
    }
    
    public Pen setPen(Cell cell, string side)
    {
        Pen myPen = new Pen(Brushes.Gray, 3);
        if (side == "right" && cell.rightSideIsHighlighted == true)
        {
            myPen.Color = Color.Orange;
            myPen.Width = 6;
        }
        if (side == "bottom" && cell.bottomSideIsHighlighted == true)
        {
            myPen.Color = Color.Orange;
            myPen.Width = 6;
        }

        if (side == "right" && cell.hasRightWall == true)
        {
            myPen.Color = Color.Black;
            myPen.Width = 6;
        }

        if (side == "bottom" && cell.hasBottomWall == true)
        {
            myPen.Color = Color.Black;
            myPen.Width = 6;
        }


        return myPen;
    }

    public void drawExit(PaintEventArgs e, Cell cell)
    {
     
        if (cell.isExit == true)
        {
            e.Graphics.DrawImage(this.exit, cell.bottomSideStartX + 5, cell.rightSideStartY + 5, theMap.cellSize - 10, theMap.cellSize - 10);
        }
        
    }

    public void drawCharacters(PaintEventArgs e, Cell cell)
    {
        if (cell.containsMinotaur == true)
        {
            e.Graphics.DrawImage(this.minotaur, cell.bottomSideStartX + 5, cell.rightSideStartY + 5, theMap.cellSize - 10, theMap.cellSize - 10);
        }

        if (cell.containsTheseus == true)
        {
            e.Graphics.DrawImage(this.theseus, cell.bottomSideStartX + 5, cell.rightSideStartY + 5, theMap.cellSize - 10, theMap.cellSize - 10);
        }
    }

    public void paintGrid(object sender, PaintEventArgs e)
    {
        
        List<int> rowNumbers = new List<int>();
        int mapHeight = thePictureBox.Height;
        int mapWidth = thePictureBox.Width;
        int numOfCells = theMap.numberOfRows;
        int cellSize = theMap.cellSize;
        
            // Draw grid
        
        foreach (Cell cell in theMap.myCells)
        {
            
            e.Graphics.DrawLine(setPen(cell, "right"), cell.rightSideStartX, cell.rightSideStartY, cell.rightSideEndX, cell.rightSideEndY);
            e.Graphics.DrawLine(setPen(cell, "bottom"), cell.bottomSideStartX, cell.bottomSideStartY, cell.bottomSideEndX, cell.bottomSideEndY);
            this.drawExit(e, cell);
            this.drawCharacters(e, cell);
        }

    }
}
