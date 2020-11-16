using System;
using EX2.Entities;

namespace EX2
{
    class Program
    {
        static void Main(string[] args)
        {
            int estado = 0;
            do {
                Console.WriteLine(" ====== BEM VINDO ====== ");
                Console.Write("O Que Você Deseja Cadastrar ? ");
                Console.Write("Cliente // Produto ");
                string resposta = Console.ReadLine();
                if(resposta == "Cliente"){
                    Console.WriteLine("====== Cadastro Do Clinte ======"); 
                    Console.Write("Nome: ");
                    string name = Console.ReadLine();
                    Console.Write("Email: ");
                    string email = Console.ReadLine();
                    Console.Write("Data De Nascimento: ");
                    DateTime data = DateTime.Parse(Console.ReadLine());
                    Client client = new Client(name, email, data);
                    estado = 1;      
                } else if (resposta == "Produto"){
                    Console.WriteLine("====== Cadastro Do Produto ======");
                    Console.Write("Nome: ");
                    string nameProd = Console.ReadLine();
                    Console.Write("Preço: ");
                    double precoProd = double.Parse(Console.ReadLine());
                    Product product = new Product(nameProd, precoProd);
                    estado = 1;
                }else {
                    Console.Write("Escolha Inválida Tente Novamente. ");
                    Console.WriteLine();
                }
            }while(estado == 0); 
        }            
    }
}
