/*ESCREVA UM PROGRAMA QUE CONTE A QUANTIDADE DE PALAVRAS 
E CARAVTERES DE UM DETERMINADO TEXTO, ESCRITO NO CONSOLE*/

string frase;
do
{
    Console.Clear();
    Console.WriteLine("Digite sua frase:   ('Digite sair para encerrar.')\n");
    frase = Console.ReadLine()!;
  
    if (frase == "sair") return;

    string[] palavras = frase.Split(' ');
    frase.Replace(" ", "");

    Console.WriteLine($"{palavras.Length} Palvaras.\n{frase.Length} Caracteres.");
    Console.WriteLine("\nTecle para continuar");
    Console.ReadKey();

} while (frase != "sair");















