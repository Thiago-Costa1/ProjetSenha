using System;

namespace projetoSenha
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o seu nome?"); 
            string resposta = Console.ReadLine(); 
            Console.WriteLine("Digite uma nova senha"); 
            string resposta1 = Console.ReadLine(); 

            while(resposta==resposta1){ 
                Console.WriteLine("Tente novamente! A senha não pode ser igual ao nome"); 
                Console.WriteLine("Digite uma nova senha"); 
                resposta = Console.ReadLine(); } 
                Console.WriteLine("Sua senha foi cadastrada corretamente! ");
        }
    }
}
