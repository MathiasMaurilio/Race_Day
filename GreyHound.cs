using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaceDay
{
    class GreyHound
    {
        public int startingPosition; //Onde a PictureBox Inicia
        public int raceTrackLenght; //Comprimento da Pista de corrida
        public PictureBox MyPictureBox = null; //Objeto PictureBox
        public int Location = 0; //Posição na Pista
        public Random myRandom = new Random(); //Instancia Random

        public bool Run()
        {
            Location = +myRandom.Next(0, 4);
            Point p = MyPictureBox.Location;
            p.X += Location;
            MyPictureBox.Location = p;
            if (MyPictureBox.Location.X >= raceTrackLenght)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void TakeStatingPosition()
        {
            Point p = MyPictureBox.Location;
            p.X = startingPosition;
            MyPictureBox.Location = p;
        }
    }
}
