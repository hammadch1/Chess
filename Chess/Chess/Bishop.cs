using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Bishop:Piece
    {
        public Bishop(MYCOLOR c, string n) : base(c, n)
        {
        
        }
        public override bool IsLegal(int sr, int sc, int er, int ec, Piece[,] Ps)
        {
            return (IsDiagonal(sr,sc,er,ec) && (IsDiagonallyClear(sr,sc,er,ec,Ps))==true);
        }
    }
}
