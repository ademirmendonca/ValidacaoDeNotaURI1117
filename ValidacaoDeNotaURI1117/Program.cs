using System;
using System.Globalization;

namespace ValidacaoDeNotaURI1117
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1 = 0, nota2 = 0, media = 0;

            nota1 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);            

            //Verifica se a primeira nota informada e valida.
            while (nota1 < 0 || nota1 > 10)
            {
                Console.WriteLine("nota invalida");
                nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            //Verifica se a segunda nota informada e valida.
            nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            while (nota2 < 0 || nota2 > 10)
            {
                Console.WriteLine("nota invalida");
                nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            //Calculo da media final e impressao da media com duas casas decimais.
            media = (nota1 + nota2) / 2;
            Console.WriteLine("media = " + media.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
