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
            myPen.Color = Color.Red;
            myPen.Width = 6;
        }
        if (side == "bottom" && cell.bottomSideIsHighlighted == true)
        {
            myPen.Color = Color.Red;
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
        using (Brush myBrush = new SolidBrush(Color.Blue))
        {
            if (cell.isExit == true)
            {
                e.Graphics.FillRectangle(myBrush, cell.bottomSideStartX, cell.rightSideStartY, theMap.cellSize, theMap.cellSize);
            }
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
        }

    }
}
