using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDev
{
    class Batalha
    {
        public static void BatalhaFunction(string nomeDoMonstro, int vidaDoPersonagem, int ataqueDoPersonagem, int manaDoPersonagem, int vidaDoMonstro, int ataqueDoMonstro)
        {
            while(vidaDoPersonagem <= 0 || vidaDoMonstro <= 0)
            {
                vidaDoPersonagem -= ataqueDoMonstro;
                vidaDoMonstro -= ataqueDoPersonagem;
                if (vidaDoPersonagem <= 0) Console.WriteLine("Você morreu!");
                else if (vidaDoMonstro <= 0) Console.WriteLine($"Você venceu o {nomeDoMonstro}!");
            }
            return;
        }
    }
}
