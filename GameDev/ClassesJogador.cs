using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDev
{
    class ClassesJogador
    {
        public class Personagem
        {
            public string nome;
            public string classe;
            public int vida;
            public int ataque;
            public int mana;
        }
        public static string classeDoPersonagem(string nameUser, int seresMisticos)
        {
            Personagem classePersonagem = new Personagem();
            switch (seresMisticos)
            {
                case 1:
                    classePersonagem.classe = "Guerreiro";
                    break;
                case 2:
                    classePersonagem.classe = "Mago";
                    break;
            }
            return classePersonagem.classe;
        }
        public static int vidaDoPersonagem(int seresMisticos)
        {
            Personagem vidaDoPersonagem = new Personagem();
            switch (seresMisticos)
            {
                case 1:
                    vidaDoPersonagem.vida = 100;
                    break;
                case 2:
                    vidaDoPersonagem.vida = 70;
                    break;
            }
            return vidaDoPersonagem.vida;
        }
        public static int ataqueDoPersonagem(int seresMisticos)
        {
            Personagem ataqueDoPersonagem = new Personagem();
            switch (seresMisticos)
            {
                case 1:
                    ataqueDoPersonagem.ataque = 30;
                    break;
                case 2:
                    ataqueDoPersonagem.ataque = 20;
                    break;
            }
            return ataqueDoPersonagem.ataque;
        }
        public static int manaDoPersonagem(int seresMisticos)
        {
            Personagem manaDoPersonagem = new Personagem();
            switch (seresMisticos)
            {
                case 1:
                    manaDoPersonagem.mana = 20;
                    break;
                case 2:
                    manaDoPersonagem.mana = 50;
                    break;
            }
            return manaDoPersonagem.mana;
        }
    }
}