using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess
{
    public partial class Chess : Form
    {
        const int Dimension = 8;
        Piece[,] Ps=new Piece[Dimension,Dimension];
        Cell[,] Cs = new Cell[Dimension, Dimension];
        MYCOLOR Player;
        bool SelectSource = true;
        Cell Source,Destination;


        public Chess()
        {
            InitializeComponent();
        }
        void INIT()
        {
            for(int r=0; r<Dimension; r++)
            {
                for(int c=0; c<Dimension; c++)
                {
                    if (r == 1)
                        Ps[r,c] = new Pawn(MYCOLOR.BLACK, "Black_Pawn.png");
                    else if ( r == 6)
                        Ps[r, c] = new Pawn(MYCOLOR.WHITE, "White_Pawn.png");
                    else if(r==0 && (c==0||c==7))
                        Ps[r, c] = new Rook(MYCOLOR.BLACK, "Black_Rook.png");
                    else if (r == 7 && (c == 0 || c == 7))
                        Ps[r, c] = new Rook(MYCOLOR.WHITE, "White_Rook.png");
                    else if (r == 0 && (c == 1 || c == 6))
                        Ps[r, c] = new Horse(MYCOLOR.BLACK, "Black_Knight.png");
                    else if (r == 7 && (c == 1 || c == 6))
                        Ps[r, c] = new Horse(MYCOLOR.WHITE, "White_Knight.png");
                    else if (r == 0 && (c == 2 || c == 5))
                        Ps[r, c] = new Bishop(MYCOLOR.BLACK, "Black_Bishop.png");
                    else if (r == 7 && (c == 2 || c ==5))
                        Ps[r, c] = new Bishop(MYCOLOR.WHITE, "White_Bishop.png");
                    else if(r==0 && c==3)
                        Ps[r, c] = new Queen(MYCOLOR.BLACK, "Black_Queen.png");
                    else if (r == 7 && c == 3)
                        Ps[r, c] = new Queen(MYCOLOR.WHITE, "White_Queen.png");
                    else if (r == 0 && c == 4)
                        Ps[r, c] = new King(MYCOLOR.BLACK, "Black_King.png");
                    else if (r == 7 && c == 4)
                        Ps[r, c] = new King(MYCOLOR.WHITE, "White_King.png");
                    else
                    {
                        Ps[r, c] = null;
                    }
                    

                    MYCOLOR cc = (((r + c) % 2 == 0) ? MYCOLOR.WHITE : MYCOLOR.BLACK);
                    Cs[r, c] = new Cell(r, c, cc, Ps[r, c], ChessPanel.Width, ChessPanel.Height, Dimension);
                    Cs[r, c].Click += new System.EventHandler(CellSelected);
                    ChessPanel.Controls.Add(Cs[r, c]);
                }
               
            }
        }

        private void  SourceSelection(object sender,EventArgs e)
        {
            Source = (Cell)sender;
            
            if (Source.aP == null)
            {
                MessageBox.Show("You can't select blank box for source");
            }
        }

        private void DestinationSelection(object sender, EventArgs e)
        {
            Destination = (Cell)sender;
        }

        void MovePiece()
        {
            Piece SP = Source.aP;
            Source.aP = null;

            Destination.aP = SP;
            int sr = Source.ri, sc = Source.ci;
            int er = Destination.ri, ec = Destination.ci;

            Ps[er, ec] = Ps[sr, sc];
            Ps[sr, sc] = null;
            Destination.aP.Draw(Destination);
            Source.Image = null;
           /* if (SelfCheckBasedLegality() == false)
            {
                Destination.aP.Draw(Destination);
                Source.Image = null;
            }
            else if (SelfCheckBasedLegality() == true)
            {
                Destination.aP = null;
                Source.aP = SP;
                HighlightClear();
                TurnChange();
            }*/
        }

        bool IsValidPieceSelection()
        {
            if(Source.aP==null)
            {
                return false;
            }
            else if(Source.aP.clr != Player)
            {
                return false;
            }
            return true;
        }
        bool IsValidPieceDestination()
        {
            return (Destination.aP==null||Destination.aP.clr != Player);
        }

        bool SelfCheckBasedLegality()
        {
            //TurnChange();
            if(Check())
            {
                return true;
            }
            return false;
        }

        bool CanOpponentKill(int r,int c)
        {
            for (int ri = 7; ri >=0; ri--)
            {
                for (int ci = 7; ci >=0; ci--)
                {
                    if(Ps[ri,ci]!=null && Ps[ri, ci].clr != Player)
                        if (Ps[ri, ci].IsLegal(ri, ci, r, c, Ps) == true)
                        {
                            if ((r + c) % 2 == 0)
                                Cs[r, c].BackColor = Color.White;
                            else
                                Cs[r, c].BackColor = Color.Gray;
                            return true;
                        }
                }
            }
            return false;
        }

        bool Check()
        {  
            for (int r = 0; r < Dimension; r++)
            {
                for (int c = 0; c < Dimension; c++)
                {
                    if (Cs[r, c].aP != null && Cs[r, c].aP.clr == Player)
                    {
                        if (Cs[r, c].aP.AmIKing() == true)
                        {
                            if (CanOpponentKill(r, c) == true)
                                return true;
                            return false;
                        }
                    }
                }
            }
            return false;
        }

        void Highlight()
        {
            Piece aP = Source.aP;
            for (int r = 0; r < Dimension; r++)
            {
                for (int c = 0; c < Dimension; c++)
                {
                    if (aP.IsLegal(Source.ri, Source.ci, r, c, Ps) == true && Ps[r, c] == null)
                    {
                        Cs[r, c].BackColor = Color.Navy;
                    }
                    else if (aP.IsLegal(Source.ri, Source.ci, r, c, Ps) == true && Ps[r, c].clr != Player)
                    {
                        Cs[r, c].BackColor = Color.Red;
                    }
                }
            }
        }

        void HighlightClear()
        {
            Piece aP = Source.aP; 
            for (int r = 0; r < Dimension; r++)
            {
                for (int c = 0; c < Dimension; c++)
                {
                    if (Cs[r, c].BackColor == Color.Navy || Cs[r, c].BackColor == Color.Red)
                    {
                        if ((r + c) % 2 == 0)
                            Cs[r, c].BackColor = Color.White;
                        else
                            Cs[r, c].BackColor = Color.Gray;
                    }
                }
            }
        }

        private void CellSelected(object sender,EventArgs e)
        {
            if (SelectSource) //SelectSource is boolean
            {
                SourceSelection(sender, e);
                if (Check() == true)
                {
                    Conditions.BackColor = Color.Gold;
                    Conditions.ForeColor = Color.Maroon;
                    Conditions.Text = "CHECK";
                } 
                if (IsValidPieceSelection() )
                {
                    SelectSource = false;
                    Highlight();
                }
                else
                    MessageBox.Show("2 Numbriii :p");
            }  
            else
            {
                DestinationSelection(sender, e);
                if (IsValidPieceDestination() && Source.aP.IsLegal(Source.ri, Source.ci, Destination.ri, Destination.ci, Ps) == true)
                {
                    MovePiece();
                    HighlightClear();
                    if (Check() == false)
                    {
                        Conditions.Text = "";
                    }
                    Source.aP = null;
                    TurnChange();
                }
                else
                {
                    MessageBox.Show("Wrong Destination !!!");
                    HighlightClear();
                }
                SelectSource = true;
            }
        }
        void TurnChange()
        {
            if (Player == MYCOLOR.WHITE)
            {
                Player = MYCOLOR.BLACK;
                PlayerTurnBox.BackColor = Color.White;
                PlayerTurnBox.ForeColor = Color.Black;
                PlayerTurnBox.Text = "Player Black's Turn";
            }
            else
            {
                Player = MYCOLOR.WHITE;
                PlayerTurnBox.BackColor = Color.Black;
                PlayerTurnBox.ForeColor = Color.White;
                PlayerTurnBox.Text = "Player White's Turn";
            }
        }


        private void START_Click(object sender, EventArgs e)
        {
            ChessPanel.BackgroundImage = null;
            ChessPanel.Controls.Clear();
           
        }

        private void ChessBoard_Paint(object sender, PaintEventArgs e)
        {
            //ChessBoard.Hide();
        }

        private void Chess_Load(object sender, EventArgs e)
        {
            
        }

        private void START_Click_1(object sender, EventArgs e)
        {
            if (WhitePieces.Checked == true)
            {
                panel1.Controls.Clear(); STARTpanel.Controls.Clear();
                Player = (MYCOLOR)(MYCOLOR.WHITE);
                PlayerTurnBox.BackColor = Color.Black;
                PlayerTurnBox.ForeColor = Color.White;
                PlayerTurnBox.Text = "Player White's Turn";
            }
            else if (BlackPieces.Checked == true)
            {
                panel1.Controls.Clear(); STARTpanel.Controls.Clear();
                Player = (MYCOLOR)MYCOLOR.BLACK;
                PlayerTurnBox.BackColor = Color.White;
                PlayerTurnBox.ForeColor = Color.Black;
                PlayerTurnBox.Text = "Player Black's Turn";
            }
            else
            {
                MessageBox.Show("Please Select A Piece Color");
                return;
            }
            INIT();
        }
        bool Legalmove(int sr,int sc,int er,int ec,Piece [,]Ps)
        {
            return Ps[sr,sc].IsLegal(sr, sc, er, ec, Ps);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void WhitePieces_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BlackPieces_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void PieceTurn_Click(object sender, EventArgs e)
        {

        }

        private void PlayerTurnBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Conditions_TextChanged(object sender, EventArgs e)
        {

        }
      

    }
}
