/*Escreva um programa que calcula o IMC (Índice de massa corporal de uma pessoa) e exibe o resultado.*/

string classificacao = string.Empty;
double imc;
string risco = string.Empty;

Console.Clear();
Console.WriteLine("Informe o peso:");
double peso = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Informe a altura:");
double altura = Convert.ToDouble(Console.ReadLine());

imc = CalcularIMC(peso, altura);
classificacao = ObterClassificacao(imc);
risco = ObterRisco(classificacao);

Console.Clear();
Console.WriteLine($"Seu IMC é: {imc}\nClassificação: {classificacao}\nRisco: {risco}\n");


double CalcularIMC(double peso, double altura)
{
    return Math.Round(peso / (altura * altura), 2);
}

string ObterClassificacao(double imc)
{
    if (imc < 16)
        classificacao = "Magreza Grau III";
    if (imc >= 16 && imc <= 16.9)
        classificacao = "Magreza Grau II";
    if (imc >= 17 && imc <= 18.4)
        classificacao = "Magreza Grau I";
    if (imc >= 18.5 && imc <= 24.9)
        classificacao = "Eutrofia";
    if (imc >= 25 && imc <= 29.9)
        classificacao = "Sobrepeso";
    if (imc >= 30 && imc <= 34.9)
        classificacao = "Obesidade Grau I";
    if (imc >= 35 && imc <= 34.9)
        classificacao = "Obesidade Grau II";
    if (imc > 40)
        classificacao = "Obesidade Grau III";

    return classificacao;

}

string ObterRisco(string classificacao)
{
    if (classificacao == "Sobrepeso")
        risco = "Aumentado";

    if (classificacao == "Obesidade Grau I")
        risco = "Moderado";

    if (classificacao == "Obesidade Grau II")
        risco = "Grave";

    if (classificacao == "Obesidade Grau III")
        risco = "Muito Grave";
    else
        risco = "--";

    return risco;

}

