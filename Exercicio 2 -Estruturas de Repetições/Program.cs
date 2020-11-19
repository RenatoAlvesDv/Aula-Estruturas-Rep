using System;

namespace Exercicio_2_dia_18
{
    class Program
    {
        static void Main(string[] args)
        {
            // Faça um programa que leia um nome de usuário e a sua senha e não aceite a senha igual ao nome do usuário, mostrando uma mensagem de erro e voltando a pedir as informações.
             Console.WriteLine("Cadastre-se");
             Console.WriteLine("");
            
            Console.WriteLine("Nome do usuário:");
                 string nome = Console.ReadLine();
         
            Console.WriteLine("Senha:");
                string Senha = Console.ReadLine();
               
            while(nome == Senha){   //Constato erro e volto a pedir a senha 
                Console.WriteLine ("A senha não pode ser igual o Nome de Usuário");
                Console.WriteLine ("Por favor digite novamente"); 

                Console.WriteLine("Senha:");
                Senha = Console.ReadLine();
            }

             Console.WriteLine("Cadastro finalizado");

            

        }
    }
}
