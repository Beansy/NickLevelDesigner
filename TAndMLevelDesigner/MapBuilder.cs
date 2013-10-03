using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public class MapBuilder
{
    private Map myMap = new Map();

	public MapBuilder()
	{
        
	}

    public void construct(int pictureBoxHeight, int pictureBoxWidth,  int columns, int rows)
    {
        this.myMap.width = pictureBoxWidth;
        this.myMap.height = pictureBoxHeight;
        this.myMap.numberOfRows = rows;
        this.myMap.numberOfColumns = columns;
        this.myMap.cellSize = this.myMap.height / this.myMap.numberOfRows;
        this.buildMap();
    }

    public Map returnMap()
    {
        return this.myMap;
    }

    public void buildMap()
    {
        this.setCellPositions();
    }

    private void setCellPositions()
    {

        for (int row = 1; row <= this.myMap.numberOfRows; row++)
        {
            for (int column = 1; column <= this.myMap.numberOfColumns; column++)
            {
                Cell cell = new Cell();
                cell.column = column;
                cell.row = row;

                cell.bottomSideStartX = (column * this.myMap.cellSize) - this.myMap.cellSize;
                cell.bottomSideStartY = (row * this.myMap.cellSize);
                cell.bottomSideEndX = (column * this.myMap.cellSize);
                cell.bottomSideEndY = (row * this.myMap.cellSize);

                cell.rightSideStartX = (column * this.myMap.cellSize);
                cell.rightSideStartY = (row * this.myMap.cellSize) - this.myMap.cellSize;
                cell.rightSideEndX = (column * this.myMap.cellSize);
                cell.rightSideEndY = (row * this.myMap.cellSize);

                if (cell.rightSideStartY == 0)
                {
                    cell.hasTopWall = true;
                }

                if (cell.bottomSideStartX == 0)
                {
                    cell.hasLeftWall = true;
                }

                if (cell.bottomSideEndY == this.myMap.height)
                {
                    cell.hasBottomWall = true;
                }

                if (cell.rightSideEndX == this.myMap.width)
                {
                    cell.hasRightWall = true;
                }



                this.myMap.myCells.Add(cell);

            }

        }

    }
}
