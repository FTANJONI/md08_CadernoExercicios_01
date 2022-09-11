using System;

namespace md08_CadernoExercicios_01
{
    /*1. Escreva um programa com uma função que solicita a digitação do salário
            atual de um funcionário e o índice de reajuste. Exiba o salário reajustado.
            Faça o retorno do resultado*/
    class Program
    {
        public static double CalcularReajuste(double Salario)
        {
            double novosal = Salario * 1.1;
            return novosal;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("\nInforme o Salário atual do funcionário:");
            double salario = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("O novo salário é R$ {0}", CalcularReajuste(salario).ToString("0.00"));
        }
    }
}
