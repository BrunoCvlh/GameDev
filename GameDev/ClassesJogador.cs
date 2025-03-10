using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDev
{
    class ClassesJogador
    {
        public static void classesDePersonagem(string nameUser, int seresMisticos) 
        {
            switch (seresMisticos)
            {
                case 1:
                    Console.WriteLine("Você escolheu a classe Guerreiro");
                    int vida1 = 100;
                    int ataque1 = 10;
                    int mana1 = 20;
                    Console.WriteLine($"Seus atributos iniciais são:\nVida: {vida1}\nAtaque: {ataque1}\nMana: {mana1}");
                    break;
                case 2:
                    Console.WriteLine("Você escolheu a classe Mago");
                    int vida2 = 70;
                    int ataque2 = 12;
                    int mana2 = 50;
                    Console.WriteLine($"Seus atributos iniciais são:\nVida: {vida2}\nAtaque: {ataque2}\nMana: {mana2}");
                    break;
            }
            }
    }
}
