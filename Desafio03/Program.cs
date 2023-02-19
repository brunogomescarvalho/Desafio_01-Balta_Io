using static System.Console;

/* Escreva um programa que, dado o valor da gasolina e do álcool, diz qual dos dois compensa mais ser utilizado. */

Clear();
WriteLine("Digite o preço do Etanol:");
double etanol = double.Parse(ReadLine()!);
WriteLine("Digite o preço da Gasolina");
double gasolina = double.Parse(ReadLine()!);

double calculoRelacao = calcularRelacaoDePreco(gasolina, etanol);
bool vantagemGasolina = calculoRelacao >= 70;

WriteLine($"\nVantagem abastecer com {(vantagemGasolina ? "Gasolina" : "Etanol")}\nRelação {calculoRelacao} %\n");

double calcularRelacaoDePreco(double gasolina, double etanol)
{
    return Math.Round(etanol / gasolina * 100);
}

