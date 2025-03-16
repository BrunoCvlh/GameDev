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
Console.Clear();

Console.WriteLine($"Olá Grande {classeDoPersonagem}\nSeus atributos atuais são:\nVida: {vidaDoPersonagem}\nAtaque: {ataqueDoPersonagem}\nInteligência: {manaDoPersonagem}\n\nAperte um botão para continuar");
Console.ReadLine();
Console.Clear();

Console.WriteLine($"Em qual dungeon começaremos nossa aventura?\n1. Caverna Menor\n2. Caverna Maior");
int decisao = int.Parse(Console.ReadLine());
Console.Clear();

string nomeDoMonstro = Monstros.nomeMonstros(decisao);
int vidaDoMonstro = Monstros.vidaMonstros(decisao);
int ataqueDoMonstro = Monstros.ataqueMonstros(decisao);

Console.WriteLine($"Você entrou na dungeon... Ops! Que barulho é esse? Isso é um {nomeDoMonstro}?");
Console.ReadLine();
Console.WriteLine($"Você encontrou um {nomeDoMonstro}\nDeseja atacá-lo ou correr?\n1. Atacar\n2. Correr");
int segundaDecisao = int.Parse(Console.ReadLine());

//função de batalha aqui







//Console.WriteLine("\n.\n.\nDigite o número da opção desejada:\n1.Entrar na dungeon\n2.Sair do jogo\n");
//int opcaoDeEntrada = int.Parse(Console.ReadLine());
//Dungeons.DungeonsDoJogo(opcaoDeEntrada);