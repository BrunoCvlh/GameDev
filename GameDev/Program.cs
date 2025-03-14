using GameDev;

Console.WriteLine("Digite um nome para o seu personagem:");
string nameUser = (Console.ReadLine());
Console.WriteLine("\nEscolha uma classe para seu personagem pelo número:\n1.Guerreiro\n2.Mago");
int seresMisticos = int.Parse(Console.ReadLine());


//variáveis
string classeDoPersonagem = ClassesJogador.classeDoPersonagem(nameUser, seresMisticos);
int vidaDoPersonagem = ClassesJogador.vidaDoPersonagem(seresMisticos);
int ataqueDoPersonagem = ClassesJogador.ataqueDoPersonagem(seresMisticos);
int manaDoPersonagem = ClassesJogador.manaDoPersonagem(seresMisticos);

Console.WriteLine($"\n\n\nOlá Grande {classeDoPersonagem}\nSeus atributos atuais são:\nVida: {vidaDoPersonagem}\nAtaque: {ataqueDoPersonagem}\nInteligência: {manaDoPersonagem}");














//Console.WriteLine("\n.\n.\nDigite o número da opção desejada:\n1.Entrar na dungeon\n2.Sair do jogo\n");
//int opcaoDeEntrada = int.Parse(Console.ReadLine());
//Dungeons.DungeonsDoJogo(opcaoDeEntrada);