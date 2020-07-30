using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class Operadores_Relacionais
    {
        public static void Executar()
        {
            Console.WriteLine("Digite a nota: ");
            double.TryParse(Console.ReadLine(), out double nota);
            Console.WriteLine("Nota invalida? {0}", nota >10.0);
        }
    }
}
