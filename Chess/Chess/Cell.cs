using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Chess
{
    class Cell:Button
    {
        public int ri, ci;
        public MYCOLOR clo;
        public Piece aP;

        public Cell(int r,int c,MYCOLOR C,Piece P,int W,int H,int D)
        {
            ri = r; ci = c;
            clo = C; 
            aP = P;
            this.Width = W / D - 9;
            this.Height = H / D - 17;
            if (C == MYCOLOR.BLACK)
            {
                this.BackColor = Color.Gray;
            }
            if (aP != null)
            {
                aP.Draw(this);
            }
        }
    }
}
