using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class VariaveisEConstantes
    {
        public static void Executar()
        {
            // area da circunferencia
            double radius = 4.5;
            const double PI = 3.14;
            radius = 5.5;

            double area = PI * radius * radius;
            Console.WriteLine(area);
            Console.WriteLine("Area eh " + area);

            // tipos internos

            bool itsRaining = true;
            Console.WriteLine("Esta chovendo " + itsRaining);
            byte age = 45;
            Console.WriteLine("idade " + age);

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine(saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine(salario);

            int menorValorInt = int.MinValue;
            Console.WriteLine(menorValorInt);

            uint populacaoBrasileira = 207_600_000;
            Console.WriteLine(populacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine(menorValorLong);

            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine(populacaoMundial);

            float precoComputador = 1299.99f;
            Console.WriteLine(precoComputador);

            double valorDeMercadoDaApple = 1_000_000_000_000.00;
            Console.WriteLine(valorDeMercadoDaApple);

            decimal distanciaEntreEstrelas = decimal.MaxValue;
            Console.WriteLine(distanciaEntreEstrelas);

            char letra = 'b';
            Console.WriteLine(letra);

            string texto = "Seja Bem vindo a xxx";
            Console.WriteLine(texto);

        }
    }
}
