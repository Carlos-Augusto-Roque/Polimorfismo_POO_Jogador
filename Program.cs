using System;
using Polimorfismo_POO_Jogador.classes;

namespace Polimorfismo_POO_Jogador
{
    class Program
    {
        static void Main(string[] args)
        {
           Jogador jogador = new Jogador();//instanciamento do objeto

            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.Write("Nome do Jogador: ");//exibição da mensagem
            jogador.nome = Console.ReadLine();//entrada e armazenamento do nome no atributo nome da classe jogador
            
            Console.Write("(Dia / Mês) de Nascimento: ");
            jogador.dataNascimento = Console.ReadLine();

            Console.Write("Ano do Nascimento : ");
            jogador.anoNascimento = int.Parse(Console.ReadLine());

            Console.WriteLine("Posição do jogador : \nDefesa, Meio ou Ataque");
            jogador.posicao = Console.ReadLine();
            
            Console.Write("Peso: ");
            jogador.peso = float.Parse(Console.ReadLine());
                        
            Console.Write("Altura: ");
            jogador.altura = float.Parse(Console.ReadLine());

            Console.Write("Nacionalidade: ");
            jogador.nacionalidade = Console.ReadLine();

            Console.Write("Ano corrente: ");
            jogador.anoAtual = int.Parse(Console.ReadLine());
            
            jogador.IdadeJogador(jogador.anoNascimento, jogador.anoAtual);//exibir resultado do método IdadeJogador 
            
            Console.ResetColor();

            Console.Clear();

            Console.WriteLine("-------Dados do Jogador--------");

            Console.ForegroundColor = ConsoleColor.Blue;

            //exibição do resultado do método ImprimirDadosJogador
            jogador.ImprimirDadosJogador(jogador.nome,jogador.posicao, jogador.dataNascimento, jogador.IdadeJogador(jogador.anoNascimento,jogador.anoAtual), jogador.nacionalidade, jogador.altura, jogador.peso);
            
            //exibição do resultado do método Aposentadoria
            jogador.Aposentadoria(jogador.IdadeJogador(jogador.anoNascimento, jogador.anoAtual), jogador.posicao);

            Console.ResetColor();
        }
    }
}
