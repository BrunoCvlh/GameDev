using GameDev;

Console.WriteLine("Digite um nome para o seu personagem:");
string nameUser = (Console.ReadLine());
Console.WriteLine("Escolha o número da classe de seu personagem:\n1.Guerreiro\n2.Mago");
int seresMisticos = int.Parse(Console.ReadLine());

ClassesJogador.classesDePersonagem(nameUser, seresMisticos);

Console.WriteLine("\n.\n.\nDigite o número da opção desejada:\n1.Entrar na dungeon\n2.Sair do jogo\n");
int opcaoDeEntrada = int.Parse(Console.ReadLine());

Dungeons.DungeonsDoJogo(opcaoDeEntrada);