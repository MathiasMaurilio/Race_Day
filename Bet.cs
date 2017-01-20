using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceDay
{
    class Bet
    {
        public int Amount; //Quantidade de dinheiro que foi apostada
        public int Dog; //Numero do Cachorro
        public Guy Bettor; //Quem Apostou

        public string GetDescription()
        {
            string aposta;

            if (Amount > 0)
                aposta = Bettor.Name + " apostou " + Amount + " no Cão " + Dog;
            else
                aposta = Bettor.Name + " Não Apostou";

            return aposta;
        }

        public int PayOut(int Winner)
        {
            if (Winner == Dog)
            {
                return Amount;
            }
            else
            {
                return -Amount;
            }
        }
    }
}
