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
        this.myMap.buildMap();
    }

    public Map returnMap()
    {
        return this.myMap;
    }
}
