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

double trocoCalculado = Math.Round(valorPago - valorCompra, 2);

System.Console.WriteLine($"Troco: {trocoCalculado}");

double[] valores = { 100, 50, 20, 10, 5, 2, 1, .50, .25, .10, .05, .01 };

List<Troco> valoresNoTroco = new List<Troco>();

foreach (var item in valores)
{
    Troco trocoAPagar = new Troco(0, 0);

    while (trocoCalculado >= item)
    {
        bool novaCedula = valoresNoTroco.Find(i => i.cedula == item) == null;
        if (trocoCalculado >= item)
        {

            if (novaCedula)
            {
                trocoAPagar.quantidade++;
                trocoAPagar.cedula = item;

                valoresNoTroco.Add(trocoAPagar);
                trocoCalculado -= item;
            }
            else
            {
                foreach (var i in valoresNoTroco)
                {
                    if (i.cedula == item)
                    {
                        i.quantidade++;
                        trocoCalculado -= item;

                    }
                }
            }
        }
    }
}

foreach (var item in valoresNoTroco)
{
    System.Console.WriteLine($"{item}");
}
return;

public class Troco
{
    public int quantidade;
    public double cedula;

    public Troco(int qtd, int cedula)
    {
        this.cedula = cedula;
        this.quantidade = qtd;
    }

    public override string ToString()
    {
        return $" {quantidade} {(cedula > 1 ? "Cédula(s)" : "Moeda(s)")} de R$ {cedula}";
    }
}