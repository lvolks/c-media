# csharp media

using System;

namespace projeto
{
    class Program
    {   
            static double CalculoMedia(double[] numeros)
        {
            double soma = 0;
            double resultado;

            for(int i=0; i< numeros.Length; i++){
                soma = numeros[i] + soma;
            }
            resultado = soma/numeros.Length;

            return resultado;
        }
     

        static void Main(string[] args)
        {
            Console.WriteLine("Quantos números serão informados?");
            int length = int.Parse(Console.ReadLine());
            double[] numeros = new double[length];

                for(int i=0; i<length; i++){
                Console.WriteLine("Informe o " + (i+1) + "o número: ");
                numeros[i] = double.Parse(Console.ReadLine()); 
                }

            Console.WriteLine("A média desses números é: " + CalculoMedia(numeros));

        
        }
    }
}

