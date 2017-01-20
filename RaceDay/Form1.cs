using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaceDay
{
    public partial class Form1 : Form
    {
        GreyHound[] Dogs = new GreyHound[4];
        Guy[] Guy = new Guy[3];
        Bet[] bets = new Bet[3];

        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < 3; i++)
                bets[i] = new Bet();

            Guy[0] = new Guy() { Name = "João", Cash = 50, MyBet = bets[0], MyLabel = lblJoao, myRadioButton = rbtnJoao };
            Guy[1] = new Guy() { Name = "Beto", Cash = 75, MyBet = bets[1], MyLabel = lblBeto, myRadioButton = rbtnBeto };
            Guy[2] = new Guy() { Name = "Alfredo", Cash = 45, MyBet = bets[2], MyLabel = lblAlfredo, myRadioButton = rbtnAlfredo };

            for (int i = 0; i < 3; i++)
            {
                Guy[i].Clearbet();

            }
            lblApostaMinima.Text = "Aposta Minima: 5 Reais";

            Dogs[0] = new GreyHound() { MyPictureBox = Dog1, startingPosition = Dog1.Location.X, raceTrackLenght = SpeedWay.Size.Width - 122 };
            Dogs[1] = new GreyHound() { MyPictureBox = Dog2, startingPosition = Dog2.Location.X, raceTrackLenght = SpeedWay.Size.Width - 122 };
            Dogs[2] = new GreyHound() { MyPictureBox = Dog3, startingPosition = Dog3.Location.X, raceTrackLenght = SpeedWay.Size.Width - 122 };
            Dogs[3] = new GreyHound() { MyPictureBox = Dog4, startingPosition = Dog4.Location.X, raceTrackLenght = SpeedWay.Size.Width - 122 };
        }

        private void RbtnJoao_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnJoao.Checked == true)
            {
                lblApostador.Text = Guy[0].Name;
            }
        }

        private void BtnAposta_Click(object sender, EventArgs e)
        {
            int amount, numberdog;
            amount = Convert.ToInt32(nudAmount.Value.ToString());
            numberdog = Convert.ToInt32(nudDog.Value.ToString());

            if (rbtnJoao.Checked == true)
                Guy[0].PlaceBet(amount, numberdog);
            else if (rbtnBeto.Checked == true)
                Guy[1].PlaceBet(amount, numberdog);
            else if (rbtnAlfredo.Checked == true)
                Guy[2].PlaceBet(amount, numberdog);
        }

        private void RbtnBeto_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnBeto.Checked == true)
            {
                lblApostador.Text = Guy[1].Name;
            }
        }

        private void RbtnAlfredo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnAlfredo.Checked == true)
            {
                lblApostador.Text = Guy[2].Name;
            }
        }

        private void BtnCorram_Click(object sender, EventArgs e)
        {
            int ganhador;
            int cachorro = 0;
            Random rd = new Random();

            btnAposta.Enabled = false;
            btnCorram.Enabled = false;

            while (true)
            {
                cachorro = rd.Next(4);
                System.Threading.Thread.Sleep(5);
                if (Dogs[cachorro].Run())
                {
                    ganhador = cachorro + 1;
                    break;
                }
            }
            MessageBox.Show("Temos Um Vencedor: Cão Numero " + ganhador + "!");

            for (int i = 0; i < 4; i++)
                Dogs[i].TakeStatingPosition();
            for (int i = 0; i < 3; i++)
                Guy[i].Collect(ganhador);

            btnAposta.Enabled = true;
            btnCorram.Enabled = true;
        }
    }

}
