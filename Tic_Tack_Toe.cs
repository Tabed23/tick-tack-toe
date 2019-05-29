using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gennalize_Tick_Tack_Toe
{
    public partial class Board : Form
    {
        Cells Cs;
        Cells[,] Grid;
        int Dim;
        Turn Player = Turn.BLUE;
        public Board()
        {
            InitializeComponent();
        }
        private void Initialize()
        {
            Grid_Board.Controls.Clear();
            this.Dim = Int32.Parse(Input.Text);
            Grid = new Cells[Dim, Dim];
            for(int ri=0; ri < this.Dim;ri++)
            {
                for(int ci=0; ci < this.Dim; ci++)
                {
                    Cells C = new Cells(ri, ci);
                    Grid[ri, ci] = C;
                    Grid[ri, ci].Height = Grid_Board.Height / this.Dim-6;
                    Grid[ri, ci].Width = Grid_Board.Width / this.Dim-6;
                    Grid[ri, ci].Click += new System.EventHandler(Cells_Click);
                    Grid_Board.Controls.Add(Grid[ri, ci]);
                }
            }
        }
        private void ChangeColor()
        {
            if(Player==Turn.BLUE)
            {
                Cs.BackColor = Color.AliceBlue;
                Cs.Value = Turn.BLUE;
            }
            else
            {
                Cs.BackColor = Color.PaleVioletRed;
                Cs.Value = Turn.RED;
            }
        }
        private void ChangeTurn()
        {
            if(Player==Turn.BLUE)
            {
                Player = Turn.RED;
            }
            else
            {
                Player = Turn.BLUE;
            }
        }
        private bool IsDraw()
        {
            for(int ri=0; ri < this.Dim; ri++)
            {
                for(int ci=0; ci < this.Dim; ci++)
                {
                    if(Grid[ri,ci].Value == Turn.EMPTY)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        private bool ISHorizentalWin(int C)
        {
            int Count=0;
            for(int r=0; r < this.Dim; r++)
            {
                if(Grid[r,C].Value !=Turn.EMPTY && Grid[r,C].Value ==Player)
                {
                    Count++;
                }
                if(Count==Dim)
                {
                    return true;
                }
            }
            return false;
        }
        private bool IsVerticalWin(int R)
        {
            int Count = 0;
            for(int c=0; c < this.Dim; c++)
            {
                if(Grid[R,c].Value !=Turn.EMPTY && Grid[R,c].Value==Player)
                {
                    Count++;
                }
                if(Count==Dim)
                {
                    return true;
                }
            }
            return false;
        }
        private bool IsDigonaWin(int r,int c)
        {
            int Count = 0;
            for(int i=0;i <this.Dim; i++)
            {
                if(Grid[i,(Dim-i)-1].Value!=Turn.EMPTY && Grid[i,(Dim-i)-1].Value ==Player)
                {
                    Count++;
                }
                if(Count==Dim)
                {
                    return true;
                }
            }
            return false;
        }
        private bool ISWin()
        {
            int R = Cs.ri;
            int C = Cs.ci;
            if (ISHorizentalWin(C))
            {
                MessageBox.Show("Player (" + Player + ")  Has Won Horizontaly");
                return true;
            }
            if (IsVerticalWin(R))
            {
                MessageBox.Show("Player (" + Player + ")  Has Won Vertically");
                return true;
            }
            if(IsDigonaWin(R,C))
            {
                MessageBox.Show("Player (" + Player + ")  Has Won Diognaly");
                return true;
            }
            return false;
        }
        private void Cells_Click(object sender,EventArgs e)
        {
            Cs = (Cells)sender;
            if(Cs.Value !=Turn.EMPTY)
            {
                MessageBox.Show("Select A Block");
                return;
            }
            ChangeColor();
            if( IsDraw())
            {
                MessageBox.Show(" The Game Is Drawed..!!!!");
                return;
            }
            if(ISWin())
            {
                return;
            }
            ChangeTurn();
        }
        private void Start_Clicked_Click(object sender, EventArgs e)
        {
            Initialize();
        }
    }
}
