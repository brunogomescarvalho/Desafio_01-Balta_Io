bool continuar = true;
do
{
    Console.Clear();
    Console.WriteLine("Escolha sua opção:\n[1] Encriptografar\n[2] Voltar frase ao original");
    byte opcao = Convert.ToByte(Console.ReadLine());

    if (opcao != 1 && opcao != 2)
        return;
    bool encriptografar = opcao == 1;

    Console.Clear();
    Console.WriteLine(encriptografar ? "Digite sua frase\n" : "Digite ou cole sua frase criptografada\n");
    string frase = Console.ReadLine()!;

    string resultado = AlterarFrase(frase, encriptografar);

    Console.WriteLine(resultado);

    do
    {
        System.Console.WriteLine("\nDeseja continuar? [1]Sim [2]Não");
        opcao = Convert.ToByte(Console.ReadLine());
        Console.Clear();

    } while (opcao != 1 && opcao != 2);

    continuar = opcao == 1;

} while (continuar == true);


static string AlterarFrase(string frase, bool encriptografar)
{
    int[] charsEmInt = new int[frase.Length];

    for (int i = 0; i < frase.Length; i++)
    {
        charsEmInt[i] = frase[i];
    }

    for (int i = 0; i < charsEmInt.Length; i++)
    {
        if (encriptografar == true)
        {
            if (charsEmInt[i] != 32)
            {
                charsEmInt[i] += 1;
            }
        }
        else
        {
            if (charsEmInt[i] != 32)
            {
                charsEmInt[i] -= 1;
            }
        }
    }

    char[] intEmChar = new char[charsEmInt.Length];

    for (int i = 0; i < intEmChar.Length; i++)
    {
        intEmChar[i] = ((char)charsEmInt[i]);
    }

    string resultado = new String(intEmChar);

    return resultado;

};

