using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public class MouseEventHandler
{
    Map theMap;
    public MouseEventHandler(Map theMap)
	{
        this.theMap = theMap;
	}
    
    
    public void onMouseHover(MouseEventArgs e)
    {
        foreach (Cell cell in theMap.myCells)
        {
            //int[] mapData = myMapController.getMapData(i, cells);
            int column = cell.column;
            int row = cell.row;
            //int right = mapData[2];
            //int bottom = mapData[3];
            int forgiveness = 10;

            if (e.X > column + theMap.cellSize - forgiveness &&
                e.X < column + theMap.cellSize + forgiveness &&
                e.Y > row && e.Y < row + theMap.cellSize)
            {
                cell.rightSideIsHighlighted = true;
                
            }
            else
            {
                cell.rightSideIsHighlighted = false;
            }

            if (e.Y > row + theMap.cellSize - forgiveness &&
                e.Y < row + theMap.cellSize + forgiveness &&
                e.X > column && e.X < column + theMap.cellSize)
            {
                cell.bottomSideIsHighlighted = true;
            }
            else
            {
                cell.bottomSideIsHighlighted = false;
            }
        }
    }

    public void onMouseClick(MouseEventArgs e)
        {
            foreach (Cell cell in theMap.myCells)
            {
                //int[] mapData = myMapController.getMapData(i, cells);
                int column = cell.column;
                int row = cell.row;
                //int right = mapData[2];
                //int bottom = mapData[3];
                int forgiveness = 10;

                if (e.X > column + theMap.cellSize - forgiveness &&
                    e.X < column + theMap.cellSize + forgiveness &&
                    e.Y > row && e.Y < row + theMap.cellSize)
                {
                    if (cell.hasRightWall == true)
                    {
                        cell.hasRightWall = false;
                    }
                    else
                    {
                        cell.hasRightWall = true;
                    }
                }

                if (e.Y > row + theMap.cellSize - forgiveness &&
                    e.Y < row + theMap.cellSize + forgiveness &&
                    e.X > column && e.X < column + theMap.cellSize)
                {
                    if (cell.hasBottomWall == true)
                    {
                        cell.hasBottomWall = false;
                    }
                    else
                    {
                        cell.hasBottomWall = true;
                    }
                }
            }
        }
    }

