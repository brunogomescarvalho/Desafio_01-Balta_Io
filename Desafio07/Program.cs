var inicio = 0;
var proximo = 1;
int sequencia = 0;
string piramide = "0 ";


for (int i = 0; i < 20; i++)
{
    System.Console.WriteLine(piramide);

    if (inicio + sequencia == 1)
    {
        piramide += proximo.ToString() + " ";
        System.Console.WriteLine(piramide);
    }

    sequencia = inicio;
    inicio = proximo;
    proximo = inicio + sequencia;
    piramide += proximo.ToString() + " ";

}







