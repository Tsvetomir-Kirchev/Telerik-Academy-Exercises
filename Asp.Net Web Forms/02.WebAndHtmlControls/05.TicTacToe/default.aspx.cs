using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _05.TicTacToe
{
    public partial class _default : System.Web.UI.Page
    {
        private static char[,] game;
        private const char playerCharacter = 'X';
        private const char computerCharacter = 'O';
        private static List<Position> freePositions;
        private static int playerScores;
        private static int computerScores;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                playerScores = 0;
                computerScores = 0;
                InitGame();
                Page page = this.Page;
                UpdateScores(page);
            }
        }

        private static void InitGame()
        {
            game = new char[3, 3];
            for (int i = 0; i < game.GetLength(0); i++)
            {
                for (int j = 0; j < game.GetLength(1); j++)
                {
                    game[i, j] = '*';
                }
            }
            freePositions = new List<Position>()
                {
                    new Position { X = 0, Y = 0},
                    new Position { X = 0, Y = 1},
                    new Position { X = 0, Y = 2},
                    new Position { X = 1, Y = 0},
                    new Position { X = 1, Y = 1},
                    new Position { X = 1, Y = 2},
                    new Position { X = 2, Y = 0},
                    new Position { X = 2, Y = 1},
                    new Position { X = 2, Y = 2}
                };
            Button btn = new Button();
            Page page = new Page();
            if (HttpContext.Current != null)
            {
                page = (Page)HttpContext.Current.Handler;
                for (int i = 0; i < game.GetLength(0); i++)
                {
                    for (int j = 0; j < game.GetLength(1); j++)
                    {
                        btn = (Button)page.FindControl("Btn" + i + j);
                        btn.Text = "";
                        btn.CssClass = "defaultBtnStyle";
                    }
                }
            }
        }

        private static void UpdateScores(Page page)
        {
            Label lbPlayerScores = (Label)page.FindControl("LbPlayerScores");
            lbPlayerScores.Text = "You: " + playerScores;
            Label lbComputerScores = (Label)page.FindControl("LbComputerScores");
            lbComputerScores.Text = "Computer: " + computerScores;
            Label lbWinner = (Label)page.FindControl("Winner");
            lbWinner.Text = "";
            lbWinner.Visible = true;
        }

        private static void GetInput(string btnId)
        {
            switch (btnId)
            {
                case "Btn00":
                    PlayerMove(0, 0, btnId);
                    break;
                case "Btn01":
                    PlayerMove(0, 1, btnId);
                    break;
                case "Btn02":
                    PlayerMove(0, 2, btnId);
                    break;
                case "Btn10":
                    PlayerMove(1, 0, btnId);
                    break;
                case "Btn11":
                    PlayerMove(1, 1, btnId);
                    break;
                case "Btn12":
                    PlayerMove(1, 2, btnId);
                    break;
                case "Btn20":
                    PlayerMove(2, 0, btnId);
                    break;
                case "Btn21":
                    PlayerMove(2, 1, btnId);
                    break;
                case "Btn22":
                    PlayerMove(2, 2, btnId);
                    break;
            }
        }

        private static void PlayerMove(int p1, int p2, string btnId)
        {
            Button btn = new Button();
            Page page = new Page();
            if (HttpContext.Current != null)
            {
                page = (Page)HttpContext.Current.Handler;
                btn = (Button)page.FindControl(btnId);
            }
            if (game[p1, p2] == '*')
            {
                game[p1, p2] = playerCharacter;
                freePositions.Remove(new Position { X = p1, Y = p2 });
                btn.Text = playerCharacter.ToString();
                if (Win(playerCharacter))
                {
                    Label lbWinner = (Label)page.FindControl("Winner");
                    lbWinner.Text = "You win!";
                    lbWinner.Visible = true;
                    playerScores++;
                    UpdateScores(page);
                    return;
                }
                ComputerMove();
            }
        }

        private static void ComputerMove()
        {
            Random rand = new Random();
            int positionIndex = rand.Next(0, freePositions.Count);
            Position position = freePositions[positionIndex];
            int row = position.X;
            int col = position.Y;

            if (game[row, col] == '*')
            {
                game[row, col] = computerCharacter;
                freePositions.Remove(position);
                Button btn = new Button();
                Page page = new Page();
                if (HttpContext.Current != null)
                {
                    page = (Page)HttpContext.Current.Handler;
                    btn = (Button)page.FindControl("Btn" + row + col);
                    btn.Text = computerCharacter.ToString();
                }
                if (Win(computerCharacter))
                {
                    Label lbWinner = (Label)page.FindControl("Winner");
                    lbWinner.Text = "You win!";
                    lbWinner.Visible = true;
                    computerScores++;
                    UpdateScores(page);
                    return;
                }
            }
            else
            {
                ComputerMove();
            }
        }

        private static bool Win(char ch)
        {
            bool win = false;
            if (game[0, 0] == ch && game[0, 1] == ch && game[0, 2] == ch)
            {
                HighlightWinBoxes(new Position(0, 0), new Position(0, 1), new Position(0, 2));
                win = true;
            }
            if (game[1, 0] == ch && game[1, 1] == ch && game[1, 2] == ch)
            {
                HighlightWinBoxes(new Position(1, 0), new Position(1, 1), new Position(1, 2));
                win = true;
            }
            if (game[2, 0] == ch && game[2, 1] == ch && game[2, 2] == ch)
            {
                HighlightWinBoxes(new Position(2, 0), new Position(2, 1), new Position(2, 2));
                win = true;
            }
            if (game[0, 0] == ch && game[1, 0] == ch && game[2, 0] == ch)
            {
                HighlightWinBoxes(new Position(0, 0), new Position(1, 0), new Position(2, 0));
                win = true;
            }
            if (game[0, 1] == ch && game[1, 1] == ch && game[2, 1] == ch)
            {
                HighlightWinBoxes(new Position(0, 1), new Position(1, 1), new Position(2, 1));
                win = true;
            }
            if (game[0, 2] == ch && game[1, 2] == ch && game[2, 2] == ch)
            {
                HighlightWinBoxes(new Position(0, 2), new Position(1, 2), new Position(2, 2));
                win = true;
            }
            if (game[0, 0] == ch && game[1, 1] == ch && game[2, 2] == ch)
            {
                HighlightWinBoxes(new Position(0, 0), new Position(1, 1), new Position(2, 2));
                win = true;
            }
            if (game[0, 2] == ch && game[1, 1] == ch && game[2, 0] == ch)
            {
                HighlightWinBoxes(new Position(0, 2), new Position(1, 1), new Position(2, 0));
                win = true;
            }
            if (win)
            {
                Button btn = new Button();
                Page page = new Page();
                if (HttpContext.Current != null)
                {
                    page = (Page)HttpContext.Current.Handler;
                    btn = (Button)page.FindControl("BtnStartNewGame");
                    btn.Visible = true;
                }
            }
            return win;
        }

        private static void HighlightWinBoxes(Position p1, Position p2, Position p3)
        {
            Button btn = new Button();
            Page page = new Page();
            if (HttpContext.Current != null)
            {
                page = (Page)HttpContext.Current.Handler;
            }
            btn = (Button)page.FindControl("Btn" + p1.X + p1.Y);
            btn.CssClass = "higlightWinBoxes";
            btn = (Button)page.FindControl("Btn" + p2.X + p2.Y);
            btn.CssClass = "higlightWinBoxes";
            btn = (Button)page.FindControl("Btn" + p3.X + p3.Y);
            btn.CssClass = "higlightWinBoxes";
        }

        protected void Btn_Click(object sender, EventArgs e)
        {
            string btnId = ((Button)sender).ID;
            GetInput(btnId);
        }

        protected void BtnStartNewGame_Click(object sender, EventArgs e)
        {
            InitGame();
            this.BtnStartNewGame.Visible = false;
        }
    }
}