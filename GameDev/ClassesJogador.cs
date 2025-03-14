using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDev
{
    class ClassesJogador
    {
        public static string classeDoPersonagem(string nameUser, int seresMisticos)
        {
            string classeEscolhida = string.Empty;
            switch (seresMisticos)
            {
                case 1:
                    classeEscolhida = "Guerreiro";
                    break;
                case 2:
                    classeEscolhida = "Mago";
                    break;
            }
            return classeEscolhida;
        }
        public static int vidaDoPersonagem(int seresMisticos)
        {
            int vida = 0;
            switch (seresMisticos)
            {
                case 1:
                    vida = 100;
                    break;
                case 2:
                    vida = 70;
                    break;
            }
            return vida;
        }
        public static int ataqueDoPersonagem(int seresMisticos)
        {
            int ataque = 0;

            switch (seresMisticos)
            {
                case 1:
                    ataque = 30;
                    break;
                case 2:
                    ataque = 20;
                    break;
            }
            return ataque;
        }
        public static int manaDoPersonagem(int seresMisticos)
        {
            int mana = 0;

            switch (seresMisticos)
            {
                case 1:
                    mana = 20;
                    break;
                case 2:
                    mana = 50;
                    break;
            }
            return mana;
        }
    }
}