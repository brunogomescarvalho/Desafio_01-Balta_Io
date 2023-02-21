
Console.Clear();
System.Console.WriteLine("Digite o número que gostaria de escrever por extenso");
var numeroParaConverter = Convert.ToInt64(Console.ReadLine());

var nrPorExtenso = NumerosPorExtenso.RecebeNumeroParaConverter(numeroParaConverter);
System.Console.WriteLine($"\n\n{nrPorExtenso}\n\n");
