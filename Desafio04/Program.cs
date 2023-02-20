/*Escreva um programa que informa o troco a ser recebido pelo cliente, por exemplo:

- Valor final da compra: R$ 328,00
- Pagamento: R$ 400,00
- Troco:
    - 1 nota de 2 reais
    - 2 notas de 10 reais
    - 2 notas de 50 reais*/


Console.Clear();
Console.WriteLine("Digite o valor da compra");
double valorCompra = Double.Parse(Console.ReadLine()!);

Console.WriteLine("Digite o valor Pago");
double valorPago = Double.Parse(Console.ReadLine()!);

double troco = Math.Round(valorPago - valorCompra, 2);

int notaDeCem = 0;
int notaDeCinquenta = 0;
int notaDeVinte = 0;
int notaDeDez = 0;
int notaDeCinco = 0;
int notaDeDois = 0;

Console.Clear();
System.Console.WriteLine($"Troco Total: R$ {troco}\n");

do
{
    if (troco >= 100)
    {
        notaDeCem++;
        troco -= 100;
    }
    if (troco >= 50)
    {
        notaDeCinquenta++;
        troco -= 50;
    }
    if (troco >= 20)
    {
        notaDeVinte++;
        troco -= 20;
    }
    if (troco >= 10)
    {
        notaDeDez++;
        troco -= 10;
    }
    if (troco >= 5)
    {
        notaDeCinco++;
        troco -= 5;
    }
    if (troco >= 2)
    {
        notaDeDois++;
        troco -= 2;
    }

} while (troco > 2);

Console.WriteLine("Cédulas\n");
Console.WriteLine("R$100 - R$50 ----- R$20 ---- R$10 ----- R$5 ----- R$2");

Console.Write(notaDeCem);
Console.CursorLeft = 10;

System.Console.Write(notaDeCinquenta);
Console.CursorLeft = 20;

System.Console.Write(notaDeVinte);
Console.CursorLeft = 30;

System.Console.Write(notaDeDez);
Console.CursorLeft = 40;

System.Console.Write(notaDeCinco);
Console.CursorLeft = 50;

System.Console.Write(notaDeDois);

Console.WriteLine("\n\nMoedas\n");
Console.WriteLine("R$1 - R$0,50 ----- R$0,25 ---- R$0,10 ----- R$0,5");

int moedaDeUmReal = 0;
int moedaDe50 = 0;
int moedaDe25 = 0;
int moedaDe10 = 0;
int moedaDe5 = 0;

do
{
    if (troco >= 1)
    {
        moedaDeUmReal++;
        troco -= 1;
    }
    if (troco >= .50)
    {
        moedaDe50++;
        troco -= .50;
    }
    if (troco >= .25)
    {
        moedaDe25++;
        troco -= .25;
    }
    if (troco >= .10)
    {
        moedaDe10++;
        troco -= .10;
    }
    if (troco >= .5)
    {
        moedaDe5++;
        troco -= .5;
    }

} while (troco > .5);


Console.Write(moedaDeUmReal);
Console.CursorLeft = 10;

System.Console.Write(moedaDe50);
Console.CursorLeft = 23;

System.Console.Write(moedaDe25);
Console.CursorLeft = 33;

System.Console.Write(moedaDe10);
Console.CursorLeft = 45;

System.Console.Write($"{moedaDe5}\n\n");




