using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaceDay
{
    class Guy
    {
        public string Name; //Nome da Pessoa
        public Bet MyBet; //Instancia de Bet() que mantem as apostas
        public int Cash; //Quanto dinheiro resta
        public RadioButton myRadioButton; // Meu Botão de radio
        public Label MyLabel; //Rotulo

        public void UptadeLabels()
        {
            MyLabel.Text = MyBet.GetDescription();
            myRadioButton.Text = Name + " Tem " + Cash + " Reais";
        }
        public void Clearbet()
        {
            MyBet.Bettor = this;
            MyBet.Amount = 0;
            UptadeLabels();
        }
        public bool PlaceBet(int Amount, int Dog)
        {
            if (Amount <= Cash)
            {
                MyBet.Amount = Amount;
                MyBet.Dog = Dog;
                MyBet.Bettor = this;

                UptadeLabels();
                return true;
            }
            else
            {
                Clearbet();
                return false;
            }
        }

        public void Collect(int Winner)
        {
            Cash += MyBet.PayOut(Winner);
            UptadeLabels();
        }
    }
}
