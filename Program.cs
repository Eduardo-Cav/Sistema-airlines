using System;

namespace Passagens
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarações de variaveis
            bool senhaValida;
            int escolha;
            int contador = 0;
            string resposta;
            //Dados da passagem
            string[] nomes = new string [5];
            string[] origem = new string [5];
            string[] destino = new string [5];
            string[] data = new string [5];

            Console.Clear();
            Console.WriteLine("------------------------------");
            Console.WriteLine("-----Sistema de Passagens-----");
            Console.WriteLine("------------------------------");

            //login
            do
            {
            Console.WriteLine("Digite a senha para entrar no sistema");
            string senha = Console.ReadLine();
            senhaValida = Efetuarlogin(senha);    
            } while (!senhaValida);

            //Menu
            do
            {
                Console.WriteLine("Menu princiapal");
                Console.WriteLine("Selecione uma opção abaixo");
                Console.WriteLine("[1] - Cadastrar Passagens");
                Console.WriteLine("[2] - Listar Passagens");
                Console.WriteLine("[0] - Sair");
                escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                    //cadastrar passagens
                    Console.WriteLine("Cadastrar passagem");
                    do
                    {
                        if(contador < 5){

                        Console.WriteLine($"Digite o nome do {contador+1}° Passageiro: ");
                        nomes[contador] = Console.ReadLine();
                        Console.WriteLine("Digite o destino da viagem: ");
                        destino[contador] = Console.ReadLine();
                        Console.WriteLine("Digite a origem: ");
                        origem[contador] = Console.ReadLine();
                        Console.WriteLine("Digite a data: ");
                        data[contador] = Console.ReadLine();                                                                                              
                        contador++;
                        }else{
                            Console.WriteLine("Núemro de passageiros excedido");
                            break;
                        }
                        Console.WriteLine("Você gostaria de cadastrar um novo passageiro? S/N");
                        resposta = Console.ReadLine();

                    } while (resposta.ToUpper() == "S");
                    Console.Clear();
                    break;
                    
                    case 2:
                    //listar passagens
                    Console.WriteLine("Listar Passagem");
                    for (var i = 0; i < contador; i++)
                    {
                        Console.WriteLine($"Passageiro {nomes[i]}, Destino: {destino [i]}, Data do voo: {data[i]}. ");
                    }
                    break;
                    
                    case 0: 
                    //sair
                    Console.WriteLine("Obrigado por viajar na AirDextron");
                    break;
                    
                    default:
                    Console.WriteLine("Opção inválida");
                    break;
                }
                
                
            } while (escolha != 0);


            //funções
            bool Efetuarlogin(string senha){
                if(senha == "123456"){
                    Console.WriteLine("Login concluído");
                    return true;
                }else{
                    Console.WriteLine("Senha incorreta! Tente novamente.");
                    return false;
                }
            }
            
        }
    }
}
