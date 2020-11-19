using System;

namespace Excercicio18
{
    class Program
    {
        static void Main(string[] args)
        {

            //Faça um programa que peça uma nota, entre zero e dez. Mostre uma mensagem caso o valor seja inválido e continue pedindo até que o usuário informe um valor válido.
            
            Console.WriteLine("Informe uma nota entre 0 e 10:");
        
            int nota = int.Parse(Console.ReadLine());
            while( nota >10 ){                                   //> Maior
                Console.WriteLine("Valor inválido!");
                Console.WriteLine("Por favor, digite uma nota valida: ");
                nota= int.Parse(Console.ReadLine());
            }
    
        }
    }
}
