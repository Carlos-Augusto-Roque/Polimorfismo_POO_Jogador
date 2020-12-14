using System;

namespace Polimorfismo_POO_Jogador.classes
{
   public class Jogador
    {
        public string nome;
        public string posicao;
        public string dataNascimento;
        public int anoNascimento;
        public int anoAtual;
        public string nacionalidade;
        public float altura;
        public float peso;

        public int IdadeJogador(int anoNascimento, int anoAtual){
            int idade = anoAtual - anoNascimento;
            
            return idade;
        }

        public int Aposentadoria(int idade, string posicao){
            int tempoAposentadoria;
            switch (posicao)
            {
                case "Defesa":
                tempoAposentadoria = 40 - IdadeJogador(anoNascimento, anoAtual);
                Console.WriteLine($"O jogador se poderá se aposentar daqui {tempoAposentadoria} anos !");              
                return tempoAposentadoria;
        
                case "Meio-Campo":
                tempoAposentadoria = 38 - IdadeJogador(anoNascimento, anoAtual);
                Console.WriteLine($"O jogador se poderá se aposentar daqui {tempoAposentadoria} anos !");
                return tempoAposentadoria;
        
                case "Atacante":
                tempoAposentadoria = 35 - IdadeJogador(anoNascimento, anoAtual);
                Console.WriteLine($"O jogador se poderá se aposentar daqui {tempoAposentadoria} anos !");
                return tempoAposentadoria;
        
                default:

                return 0;
            }
            
            
        }

        public void ImprimirDadosJogador(string nome, string posicao, string dataNascimento, int idade, string nacionalidade, float altura, float peso){
            idade = 2020 - anoNascimento; 
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Nascido em: {dataNascimento}");
            Console.WriteLine($"Idade: {idade} anos");
            Console.WriteLine($"Peso: {peso} kg");
            Console.WriteLine($"Altura: {altura} m");
            Console.WriteLine($"Nascionalidade: {nacionalidade}");
            Console.WriteLine($"Posição: {posicao}");

        }
        
    }
}