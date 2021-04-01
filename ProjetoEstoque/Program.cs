using System;
using System.Globalization;

namespace ProjetoEstoque
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Entre os Dados do Produto");
            Console.WriteLine("Nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Quantidade: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto p = new Produto(nome, preco, quantidade);

            Console.WriteLine();
            Console.WriteLine("Dados do Produto: " + p);

            Console.WriteLine();
            Console.WriteLine("digite o numero de produtos a ser adicionado ao Estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);
            Console.WriteLine("Dados Atualizados: " + p);

            Console.WriteLine("digite o numero de produtos a ser removidos do Estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);


        }
    }
}
