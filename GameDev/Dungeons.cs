using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDev
{
    class Dungeons
    {
        public static void DungeonsDoJogo(int opcaoDeEntrada)
        {
            if (opcaoDeEntrada == 1)
            {
                Console.WriteLine("Você entrou na dungeon");
            }
            else
            {
                Console.WriteLine("Você saiu do jogo");
            }
        }
    }
}
