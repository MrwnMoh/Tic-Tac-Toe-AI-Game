using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Teo_Game
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        bool IsVsPc;

        string selectedLevel;

        private void frmSplash_Load(object sender, EventArgs e)
        {
            TpTb1Lenght.Text =  TbPlayer1.Text.Length.ToString();
            TpTb2Lenght.Text =  TbPlayer2.Text.Length.ToString();
            IsVsPc = false;
            selectedLevel = btnSelectLevel.Text;

        }

        private void TbPlayer1_TextChanged(object sender, EventArgs e)
        {
            TpTb1Lenght.Text = TbPlayer1.Text.Length.ToString();

        }

        bool CheckIsNameIsSame()
        {
            if(TbPlayer1.Text == TbPlayer2.Text)
            {
                return true;
            }
            return false;
        }

        private void TbPlayer2_TextChanged(object sender, EventArgs e)
        {
            TpTb2Lenght.Text = TbPlayer2.Text.Length.ToString();

        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            //frm.FormClosed += (s, args) => Application.Exit();}

            if (IsVsPc)
            {
                TbPlayer2.Text = "Pc";
            }
            if (!CheckIsNameIsSame())
            { 
                
                frmGame frm = new frmGame(TbPlayer1.Text, TbPlayer2.Text, IsVsPc, this,selectedLevel);
                frm.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Warning: The two names are too similar! Please choose different names.", "Name Conflict", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
        private void btnPc_Click(object sender, EventArgs e)
        {
            if(!IsVsPc)
            {
                TbPlayer2.Visible = false;
                TpPlayer2LenghtOf.Visible = false;
                TpTb2Lenght.Visible = false;
                TpPlayer2Name.Visible = false;

                IsVsPc = true;
            }
            else
            {
                TbPlayer2.Visible = true ;
                TpPlayer2LenghtOf.Visible = true;
                TpTb2Lenght.Visible = true;
                TpPlayer2Name.Visible = true;

                IsVsPc = false;
            }

            if(btnPc.BackColor != Color.Gray)
            {
                btnPc.BackColor = Color.Gray;
                btnPc.ForeColor = Color.White;
            }
            else
            {
                btnPc.BackColor = Color.FloralWhite;
                btnPc.ForeColor = Color.Black;

            }


            TpSelectLevel.Visible = !TpSelectLevel.Visible;
            btnSelectLevel.Visible = !btnSelectLevel.Visible;
        }

        private void btnSelectLevel_SelectedItemChanged(object sender, EventArgs e)
        {
            selectedLevel = btnSelectLevel.Text;
        }
    }
}
