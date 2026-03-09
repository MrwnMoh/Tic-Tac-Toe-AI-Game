using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tic_Tac_Teo_Game.Properties;

namespace Tic_Tac_Teo_Game
{
    public partial class frmGame : Form
    {
        public frmGame(string Player1,string player2,bool IsVsPc,frmSplash frmSplash,string Level)
        {
            InitializeComponent();
            _player1 = Player1;
            _IsVsPc = IsVsPc;

            if(!_IsVsPc)
                _player2 = player2;
            else
                _player2 = "PC";

            _frmSplash = frmSplash;


            _pcLevel = (PcLevel)Enum.Parse(typeof(PcLevel),Level);

        }

        frmSplash _frmSplash;
        bool _IsVsPc;

        Random rnd = new Random();

        string _player1, _player2;

        string WinnerName;

        bool IsGameOver;

        enum PcLevel
        {
            Easy,Medium, Hard
        }

        PcLevel _pcLevel;

        byte ClickedCount;

        bool IsPlayer1Turn;

        int[,] GameArr;

        void ChangePicsOfWinIndexs(byte Index,bool IsRow)
        {
            Button Mybtn;
            string BtnName;

            for (byte i = 0; i < 3; i++)
            {
                if( IsRow )
                    BtnName = "Btn" + Index.ToString() + "I" + i.ToString();
                else
                    BtnName = "Btn" + i.ToString() + "I" + Index.ToString();
                
                    var ResBtn = this.Controls.Find(BtnName, true);

                    if (ResBtn.Length > 0)
                    {
                        Mybtn = (Button)ResBtn[0];
                        Mybtn.BackColor = Color.Green;
                }
            }

        }

        void ChangePicsOfDiagonalWinIndexs(bool IsMainDiagonal)
        {
            Button Mybtn;
            string BtnName;

            for (byte i = 0; i < 3; i++)
            {
                if (IsMainDiagonal)
                    BtnName = "Btn" + i.ToString() + "I" + i.ToString();
                else
                    BtnName = "Btn" + i.ToString() + "I" + (2-i).ToString();

                var ResBtn = this.Controls.Find(BtnName, true);

                if (ResBtn.Length > 0)
                {
                    Mybtn = (Button)ResBtn[0];
                    Mybtn.BackColor = Color.Green;
                }
            }

        }

        void ChangeWinnerName(string Name)
        {
            IsGameOver = true;
            WinnerName = Name;
            TpWinnerName.Text = WinnerName;
            TpPlayerName.Text = "Game Over";
            TpTurnMark.Text = "";
        }

        void CheckPlayerWinName(byte PlayerNum)
        {
            if (PlayerNum == 1)
                ChangeWinnerName(_player1);
            else if (PlayerNum == 2)
                ChangeWinnerName(_player2);
            else
                ChangeWinnerName("Pc");
        }
        
        bool CheakResults()
        {
            byte num = 2;
                if (_IsVsPc)
                    num = 3;

            for (byte PlayerNum = 1; PlayerNum <= num; PlayerNum++)
            {
                for (byte Index = 0; Index < 3; Index++)
                {
                    // نشوف العواميد و الصفوف
                    if (GameArr[Index, 0] == PlayerNum && GameArr[Index, 1] == PlayerNum && GameArr[Index, 2] == PlayerNum)
                    {

                        
                        CheckPlayerWinName(PlayerNum);
                        ChangePicsOfWinIndexs(Index, true);
                        DisableGame();
                        ShowWin();

                        return true;
                    }

                    if(GameArr[0, Index] == PlayerNum && GameArr[1, Index] == PlayerNum && GameArr[2, Index] == PlayerNum)
                    {
                      
                        CheckPlayerWinName(PlayerNum);
                        ChangePicsOfWinIndexs(Index, false);
                        DisableGame();
                        ShowWin();
                       
                        return true;
                    }

                }

                //نشوف الاقطار
                if (GameArr[0, 0] == PlayerNum && GameArr[1, 1] == PlayerNum && GameArr[2, 2] == PlayerNum)
                {
                    
                    CheckPlayerWinName(PlayerNum);
                    ChangePicsOfDiagonalWinIndexs(true);
                    DisableGame();
                    ShowWin();

                    return true;
                }

                if (GameArr[0, 2] == PlayerNum && GameArr[1, 1] == PlayerNum && GameArr[2, 0] == PlayerNum)
                {
                    CheckPlayerWinName(PlayerNum);
                    ChangePicsOfDiagonalWinIndexs(false);
                    DisableGame();
                    ShowWin();

                    return true;
                }

            }
            return false;   
        }
        
        bool CheckWinnerSimulation(byte start)
        {
            for (byte PlayerNum = start; PlayerNum <= 3; PlayerNum++)
            {
                for (byte Index = 0; Index < 3; Index++)
                {
                    // نشوف العواميد و الصفوف
                    if (GameArr[Index, 0] == PlayerNum && GameArr[Index, 1] == PlayerNum && GameArr[Index, 2] == PlayerNum ||
                        GameArr[0, Index] == PlayerNum && GameArr[1, Index] == PlayerNum && GameArr[2, Index] == PlayerNum)
                    {
                        return true;
                    }
                }
                //نشوف الاقطار
                if (GameArr[0, 0] == PlayerNum && GameArr[1, 1] == PlayerNum && GameArr[2, 2] == PlayerNum ||
                    GameArr[0, 2] == PlayerNum && GameArr[1, 1] == PlayerNum && GameArr[2, 0] == PlayerNum)
                {
                    return true;
                }
            }
            return false;
        }

        void ShowWin()
        {
            MessageBox.Show($"Congratulations {WinnerName}, You Win!", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DisableGame();
        }
       
        void ChangeCurrentPlayerName(string name)
        {
            if(!IsGameOver)
            TpPlayerName.Text = name;
        }

        void UpdateBoard(object sender,byte PlayerNum)
        {
            Button Btn = (Button)sender;

            byte Row = Convert.ToByte(Btn.Tag.ToString()[0].ToString());
            byte Col = Convert.ToByte(Btn.Tag.ToString()[2].ToString());
            // In Tag Is 0|1 or 0|2 or 3|0

            GameArr[Row, Col] = PlayerNum;
            CheakResults();
        }
        
        void RestartArr()
        {
            GameArr = new int[,]
                                                    {
                            {0,0,0},
                            {0,0,0},
                            {0,0,0}
                                                    };

            Button Mybtn;
            string BtnName;

            for (int i = 0; i < 3; i++)
            {

                for(int j = 0; j < 3; j++)
                {
                    BtnName = "Btn" + i + "I" + j;

                    var ResBtn = this.Controls.Find(BtnName, true);

                    if (ResBtn.Length > 0)
                    {
                        Mybtn = (Button)ResBtn[0];
                        Mybtn.BackColor = Color.FloralWhite;
                        Mybtn.Text = "?";
                        ;
                    }
                }


            }

        }

        void DisableGame()
        {
            Button Mybtn;
            string BtnName;

            for (int i = 0; i < 3; i++)
            {

                for (int j = 0; j < 3; j++)
                {
                    BtnName = "Btn" + i + "I" + j;

                    var ResBtn = this.Controls.Find(BtnName, true);

                    if (ResBtn.Length > 0)
                    {
                        Mybtn = (Button)ResBtn[0];
                        Mybtn.Enabled = false;
                    }
                }


            }




        }

        void EnableGame()
        {
            Button Mybtn;
            string BtnName;

            for (int i = 0; i < 3; i++)
            {

                for (int j = 0; j < 3; j++)
                {
                    BtnName = "Btn" + i + "I" + j;

                    var ResBtn = this.Controls.Find(BtnName, true);

                    if (ResBtn.Length > 0)
                    {
                        Mybtn = (Button)ResBtn[0];
                        Mybtn.Enabled = true;
                    }
                }


            }
        }
        
        bool IsCellPlayed(object sender)
        {
            Button Btn = (Button)sender;

            byte Row = Convert.ToByte(Btn.Tag.ToString()[0].ToString());
            byte Col = Convert.ToByte(Btn.Tag.ToString()[2].ToString());

            return GameArr[Row, Col] != 0;
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

            //تجهيز الاراي
            GameArr = new int[,]
                                        {
                            {0,0,0},
                            {0,0,0},
                            {0,0,0}
                                        };


            IsPlayer1Turn = true;
            ClickedCount = 0;


            TpPlayerName.Text = _player1;
            if(_IsVsPc)
            {
                TpInfo.Visible = true;
                TpInfo.Text = "Vs Pc ( " + _pcLevel.ToString() + " )";
            
            
            }
        }
        
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen MyPen = new Pen(Color.Black, 5);

            MyPen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            MyPen.EndCap = System.Drawing.Drawing2D.LineCap.Round;


            e.Graphics.DrawLine(MyPen, 1000, 150, 1000, 650);
            e.Graphics.DrawLine(MyPen, 750, 150, 750, 650);

            e.Graphics.DrawLine(MyPen, 550, 300, 1200, 300);
            e.Graphics.DrawLine(MyPen, 550, 500, 1200, 500);




        }
       
        void GameEnd()
        {
            MessageBox.Show("It's a Draw!", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DisableGame();
        }

        bool TryWin(ref byte Row, ref byte Col)
        {
            for(byte r = 0; r <3; r++)
            {
                for(byte c = 0; c < 3; c++)
                {
                    if(GameArr[r, c] == 0)
                    {
                        GameArr[r, c] = 3;
                        if (CheckWinnerSimulation(3)) // رقم ال بي سي هو 3
                        {
                            GameArr[r, c] = 0;
                            Row = r;
                            Col = c;
                            return true;
                        }
                            GameArr[r, c] = 0;

                    }
                }
            }
            return false;
        }

        bool TryDefance(ref byte Row, ref byte Col)
        {
            for (byte r = 0; r < 3; r++)
            {
                for (byte c = 0; c < 3; c++)
                {
                    if (GameArr[r, c] == 0)
                    {
                            GameArr[r, c] = 1;
                            if (CheckWinnerSimulation(1)) //رقم اللاعب هو1
                            {
                                GameArr[r, c] = 0;
                                Row = r;
                                Col = c;
                                return true;
                            }
                            GameArr[r, c] = 0;

                        }
                    }
                }
            
            return false;
        }
        
        void PlayLevel(ref byte Row, ref byte Col)
        {
            switch (_pcLevel)
            {
                case PcLevel.Easy:
                      RandomPlay(ref Row, ref Col);
                    break;

                case PcLevel.Medium:
                    if (ClickedCount >= 3)
                    {
                      if (!TryDefance(ref Row, ref Col))
                          RandomPlay(ref Row, ref Col);
                    }
                    else
                        RandomPlay(ref Row, ref Col);
                    break;

                case PcLevel.Hard:
                    if (ClickedCount >= 3)
                    {
                        if (!TryWin(ref Row, ref Col))
                        {
                            if (!TryDefance(ref Row, ref Col))
                                RandomPlay(ref Row, ref Col);
                        }
                    }
                    else
                    {
                        RandomPlay(ref Row, ref Col);

                    }
                    break;
            }
        }

        void RandomPlay(ref byte Row, ref byte Col)
        {
            while (true)
            {
                Row = Convert.ToByte(rnd.Next(3));
                Col = Convert.ToByte(rnd.Next(3));
                if (GameArr[Row, Col] == 0)
                    break;
            }
        }

        void PcPlay()
        {
            byte Row = 0 ;
            byte Col = 0 ;

            PlayLevel(ref Row, ref Col);//العب حسب المستوي اللي عندك

            Button Mybtn;
            string BtnName;

            BtnName = "Btn" + Row.ToString() + "I" + Col.ToString();
            var ResBtn = this.Controls.Find(BtnName, true);

            if (ResBtn.Length > 0)
            {
                Mybtn = (Button)ResBtn[0];

                Mybtn.Text = "O";
                

                UpdateBoard(Mybtn, 3);

            }

        }

        private void On_Player_Clieck(object sender, EventArgs e)
        {
            Button Btn = (Button)sender;

            if(ClickedCount != 9)
            {
                if (!IsCellPlayed(Btn))
                {
                    ClickedCount++;

                    if (IsPlayer1Turn || _IsVsPc)
                    {

                        Btn.Text = "X";
                        TpTurnMark.Text = "O";
                        UpdateBoard(sender, 1);
                        ChangeCurrentPlayerName(_player2);

                        IsPlayer1Turn = false;
                    }
                    else
                    {

                        Btn.Text = "O";
                        TpTurnMark.Text = "X";

                        UpdateBoard(sender, 2);
                        ChangeCurrentPlayerName(_player1);

                        IsPlayer1Turn = true;


                    }

                    if(ClickedCount == 9 && !IsGameOver)
                    {
                        GameEnd();
                    }

                }
                else
                {
                    MessageBox.Show("Invalid Choice!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
               
            } 
            else
             {
                GameEnd();
            }

            if (_IsVsPc && ClickedCount != 9 && !IsGameOver)
            {
                PcPlay();
                ClickedCount++;
                TpTurnMark.Text = "X";
                IsPlayer1Turn = true ;
                ChangeCurrentPlayerName(_player1);

            }

        }

        private void Play_Game(object sender, EventArgs e)
        {
            IsGameOver = false;
            IsPlayer1Turn = true;
            ClickedCount = 0;

            WinnerName = "In Progress";
            TpWinnerName.Text = WinnerName;
            TpPlayerName.Text = _player1;
            if(!IsGameOver)
            TpTurnMark.Text = "X";

            RestartArr();
            EnableGame();
        }
        
        private void Restart_Game(object sender, EventArgs e)
        {
            this.Close();
            _frmSplash.Show();
        }
    }
}
