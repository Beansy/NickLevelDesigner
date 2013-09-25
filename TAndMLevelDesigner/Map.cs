using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;

public class Map
{
    public Drawer drawer;
    public List<Cell> myCells = new List<Cell>();
    public int height{ get; set;}
    public int width{ get; set; } 
    public int numberOfRows;
    public int numberOfColumns;
    public int cellSize;

	public Map()
	{
        this.drawer = new Drawer();

	}

    public void buildMap()
    {
        this.setCellPositions();
    }

    
    private void setCellPositions()
    {

        for (int row = 1; row <= this.numberOfRows; row++)
        {
            for (int column = 1; column <= this.numberOfColumns; column++)
            {
                Cell cell = new Cell();
                cell.column = column;
                cell.row = row;
                
                cell.bottomSideStartX = (column * this.cellSize) - this.cellSize;
                cell.bottomSideStartY = (row * this.cellSize);
                cell.bottomSideEndX = (column * this.cellSize);
                cell.bottomSideEndY = (row * this.cellSize);
                
                cell.rightSideStartX = (column * this.cellSize);
                cell.rightSideStartY = (row * this.cellSize) - this.cellSize;
                cell.rightSideEndX = (column * this.cellSize);
                cell.rightSideEndY = (row * this.cellSize);

                if (cell.rightSideStartY == 0)
                {
                    cell.hasTopWall = true;
                }

                if (cell.bottomSideStartX == 0)
                {
                    cell.hasLeftWall = true;
                }

                if (cell.bottomSideEndY == this.height)
                {
                    cell.hasBottomWall = true;
                }

                if (cell.rightSideEndX == this.width)
                {
                    cell.hasRightWall = true;
                }



                this.myCells.Add(cell);

            }

        }
           
    }

    
}
