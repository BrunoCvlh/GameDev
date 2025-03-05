Console.WriteLine("Digite um nome para o seu personagem:");
string nameUser = (Console.ReadLine());
Console.WriteLine("Escolha o número da classe de seu personagem:\n1.Guerreiro\n2.Mago");
int seresMisticos = int.Parse(Console.ReadLine());

switch (seresMisticos)
{
    case 1:
        string nameOfClass = "Guerreiro";
        int life = 100;
        int mana = 40;
        int ataqueNormal = 10;
        int ataqueEspecial = 30;
        Console.WriteLine($"Olá {nameUser}, você escolheu a classe {nameOfClass}.\nSeus atributos são:\nVida: {life}\nMana: {mana}\nPoder: {ataqueEspecial + ataqueNormal}");
        break;
    case 2:
        string nameOfClass2 = "Mago";
        int life2 = 60;
        int mana2 = 100;
        int ataqueNormal2 = 15;
        int ataqueEspecial2 = 40;
        Console.WriteLine($"Olá {nameUser}, você escolheu a classe {nameOfClass2}.\nSeus atributos são:\nVida: {life2}\nMana: {mana2}\nPoder: {ataqueEspecial2 + ataqueNormal2}");
        break;
    default:
        Console.WriteLine("Opção inválida");
        break;
}
