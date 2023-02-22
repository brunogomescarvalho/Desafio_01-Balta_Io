bool continuar = true;


while (continuar)
{
    Console.Clear();
    System.Console.WriteLine("Digite o número que gostaria de escrever por extenso.");
    var numeroParaConverter = (Console.ReadLine()!);
    Console.WriteLine(NumerosPorExtenso.RecebeNumeroERetornaString(numeroParaConverter));

    System.Console.WriteLine("Deseja continuar? [s/n] ");
    var resposta = Console.ReadLine()!;
    if (resposta.ToLower() == "n")
    {
        continuar = false;
    }
}