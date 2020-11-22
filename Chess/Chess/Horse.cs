using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Horse:Piece
    {
        public Horse(MYCOLOR  c,string n):base(c,n)
        {
        
        }
        public override bool IsLegal(int sr, int sc, int er, int ec, Piece[,] Ps)
        {
            int deltaR, deltaC;
            deltaR = Math.Abs(sr - er);
            deltaC = Math.Abs(sc - ec);
            return ((deltaR == 1 && deltaC == 2) || (deltaR == 2 && deltaC == 1));
        }
    }
}
