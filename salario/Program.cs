/* o aumento,desconte 8% de impostos. Imprima o salário inicial, o salário
com o aumento e o salário final. 
*/




using System;

namespace salario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("informe seu salario: ");
            double salario_inicial = Convert.ToDouble(Console.ReadLine());
            double salario_aumentado = salario_inicial + (salario_inicial * 0.15);
            double salario_descontado = salario_aumentado - (salario_aumentado * 0.08);
            Console.WriteLine($"salario incial:R${salario_inicial}");
            Console.WriteLine($"salario com aumento:R${salario_aumentado}");
            Console.WriteLine($"salario descontado:R${salario_descontado}");
        }
    }
}
