using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



public class Cell
{
    public int row{ get; set; }
    public int column { get; set; }
    public int rightSideStartX { get; set; }
    public int rightSideStartY { get; set; }
    public int rightSideEndX { get; set; }
    public int rightSideEndY { get; set; }
    public int bottomSideStartX { get; set; }
    public int bottomSideStartY { get; set; }
    public int bottomSideEndX { get; set; }
    public int bottomSideEndY { get; set; }
    
    public bool hasRightWall { get; set; }
    public bool hasBottomWall { get; set; }
    public bool hasTopWall { get; set; }
    public bool hasLeftWall { get; set; }
    public bool isExit { get; set; }

    public bool containsMinotaur { get; set; }
    public bool containsTheseus { get; set; }

    public bool rightSideIsHighlighted { get; set; }
    public bool bottomSideIsHighlighted { get; set; }


	public Cell()
	{
       
	}

    
}
