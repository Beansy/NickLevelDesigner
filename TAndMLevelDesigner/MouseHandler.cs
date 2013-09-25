using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public class MouseHandler
{
    int forgiveness = 10;
    int mouseX;
    int mouseY;

    public void onMouseClick(EventArgs e, Map theMap)
    {

        foreach (Cell cell in theMap.myCells)
        {
            if (cell.bottomSideIsHighlighted == true)
                if (cell.hasBottomWall == false)
                {
                    cell.hasBottomWall = true;
                }
                else
                {
                    cell.hasBottomWall = false;
                }
            if (cell.rightSideIsHighlighted == true)
                if (cell.hasRightWall == false)
                {
                    cell.hasRightWall = true;
                }
                else
                {
                    cell.hasRightWall = false;
                }
                 
                 
        }
    }

    public void onDoubleClick(Map theMap)
    {
        foreach (Cell cell in theMap.myCells)
        {
            if ((this.mouseX >= cell.bottomSideStartX && this.mouseX <= cell.bottomSideEndX) && (this.mouseY >= cell.rightSideStartY && this.mouseY <= cell.rightSideEndY))
            {
                if (cell.isExit == false)
                {
                    cell.isExit = true;
                }
                else
                {
                    cell.isExit = false;
                }
            }
        }
    }

    public void onMouseHover(MouseEventArgs e, Map theMap)
    {
        this.mouseX = e.X;
        this.mouseY = e.Y;
        
        try
        {
            foreach (Cell cell in theMap.myCells)
            {

                if ((e.X >= cell.bottomSideStartX && e.X <= cell.bottomSideEndX) && (e.Y <= cell.bottomSideStartY + forgiveness && e.Y >= cell.bottomSideStartY - forgiveness))
                {
                    
                    cell.bottomSideIsHighlighted = true;
                }
                else
                {
                    cell.bottomSideIsHighlighted = false;
                }

                if ((e.Y >= cell.rightSideStartY && e.Y <= cell.rightSideEndY) && (e.X <= cell.rightSideStartX + forgiveness && e.X >= cell.rightSideStartX - forgiveness))
                {
                    
                    cell.rightSideIsHighlighted = true;
                }
                else
                {
                    cell.rightSideIsHighlighted = false;
                }

            }
        }
        catch (NullReferenceException)
        {
            
        }
    }
}
