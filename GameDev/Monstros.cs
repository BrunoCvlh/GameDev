using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Channels;
using System.Threading.Tasks;
using GameDev;

namespace GameDev
{
    class Monstros
    {
        public class Monstro
        {
            public string nome;
            public int vida;
            public int ataque;
        }
        public static string nomeMonstros(int decisao)
        {
            Monstro monstro = new Monstro();
            switch (decisao)
            {
                case 1:
                    monstro.nome = "Goblin";
                    break;
                case 2:
                    monstro.nome = "Ogro";
                    break;
            }
            return monstro.nome;
        }
        public static int vidaMonstros(int decisao)
        {
            Monstro vidaMonstro = new Monstro();
            switch (decisao)
            {
                case 1:
                    vidaMonstro.vida = 30;
                    break;
                case 2:
                    vidaMonstro.vida = 50;
                    break;
            }
            return vidaMonstro.vida;
        }
        public static int ataqueMonstros(int decisao)
        {
            Monstro ataqueMonstro = new Monstro();
            switch (decisao)
            {
                case 1:
                    ataqueMonstro.ataque = 5;
                    break;
                case 2:
                    ataqueMonstro.ataque = 30;
                    break;
            }
            return ataqueMonstro.ataque;
        }
    }
}
