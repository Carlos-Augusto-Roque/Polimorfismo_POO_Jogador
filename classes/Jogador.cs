using System;

namespace Polimorfismo_POO_Jogador.classes
{
   public class Jogador
    {
        //atributos da classe
        public string nome;
        public string posicao;
        public string dataNascimento;
        public int anoNascimento;
        public int anoAtual;
        public string nacionalidade;
        public float altura;
        public float peso;

        //metodo IdadeJogador
        public int IdadeJogador(int anoNascimento, int anoAtual){ //método para calcular a idade do jogador 
            int idade = anoAtual - anoNascimento;//processamento dos dados para calcular a idade
            
            return idade;//retornar o resultado da idade
        }

        //metodo Aposentadoria
        public int Aposentadoria(int idade, string posicao){//metodo para analisar e exibir o tempo que falta para aposentadoria do jogador

            int tempoAposentadoria; //variável para receber o tempo para aposentadoria

            //estrutura de condicional
            switch (posicao) 
            {//avalie a condição da variável posicao

                case "Defesa": //caso a posicao do jogador seja defesa,
                tempoAposentadoria = 40 - IdadeJogador(anoNascimento, anoAtual); //o tempo  de aposentadoria é 40 - idade do jogador
                Console.WriteLine($"O jogador se poderá se aposentar daqui {tempoAposentadoria} anos !");//exibição da mensagem              
                return tempoAposentadoria;//retorno do tempo que falta para se aposentar
        
                case "Meio": 
                tempoAposentadoria = 38 - IdadeJogador(anoNascimento, anoAtual);
                Console.WriteLine($"O jogador se poderá se aposentar daqui {tempoAposentadoria} anos !");
                return tempoAposentadoria;
        
                case "Ataque":
                tempoAposentadoria = 35 - IdadeJogador(anoNascimento, anoAtual);
                Console.WriteLine($"O jogador se poderá se aposentar daqui {tempoAposentadoria} anos !");
                return tempoAposentadoria;
        
                default:

                return 0;
            }
            
            
        }

        //metodo ImprimirDadosJogador
        public void ImprimirDadosJogador(string nome, string posicao, string dataNascimento, int idade, string nacionalidade, float altura, float peso){
        //método para imprimir os dados do jogador
        
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