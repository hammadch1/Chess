using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class King:Piece
    {
        public King(MYCOLOR  c,string n):base(c,n)
        {
        
        }

        public override bool AmIKing()
        {
            return true;
        }

        public override bool IsLegal(int sr, int sc, int er, int ec, Piece[,] Ps)
        {
            int deltaR, deltaC;
            deltaR = er - sr;
            deltaC = ec - sc;
            return (((IsVertical(sr, sc, er, ec) && IsVerticallyClear(sr, sc, er, ec, Ps) == true) || (IsHorizontal(sr, sc, er, ec) && IsHorizontallyClear(sr, sc, er, ec, Ps) == true))
                ||
                (IsDiagonal(sr, sc, er, ec) && (IsDiagonallyClear(sr, sc, er, ec, Ps)) == true) )
                && 
                (deltaR == -1 || deltaC == -1 || deltaR == 1 || deltaC == 1);
        }
    }
}
