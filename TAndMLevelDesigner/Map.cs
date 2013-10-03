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

    
}
