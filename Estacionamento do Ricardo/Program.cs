namespace Estacionamento_do_Ricardo
{
    class Program
    {
        static void Main(string[] args)
        {
            //faz uma lista de strings, chamada veiculos, onde serão armazenadas na memoria as placas
            List<string> veiculos = new List<string>();

            //declara e inicializa variaveis
            double precoInicial = 0;
            double precoPorHora = 0;

            //menu de opções
            Console.WriteLine("Seja bem vindo ao Estacionamento do Ricardo\n");
            Console.WriteLine("********************************************************\n");
            Console.WriteLine("\nLembre de Utilizar a Opção 4 ao iniciar o Programa");
            Console.WriteLine("Para definir corretamente os valores cobrados.\n\n");
            Console.WriteLine("********************************************************\n");
            Console.WriteLine("Digite uma opção do Menu:\n\n");
            Console.WriteLine("1 - Cadastrar veículo\n");
            Console.WriteLine("2 - Remover veículo e Calcular valor a pagar\n");
            Console.WriteLine("3 - Listar Veículos Estacionados\n");
            Console.WriteLine("4 - Configurar Valores\n");
            Console.WriteLine("5 - Encerrar Programa\n");

            //while loop para ficar repetindo o submenu de opçoes ate ser escolhida a opção 5 (saida)
            while (true)
            {
                Console.WriteLine("Escolha uma opção (1-5):");
                //int parse da variavel menu, pois readline le string
                int menu = int.Parse(Console.ReadLine());

                //switch case com as opções
                switch (menu)
                {
                    // ingressa veiculo
                    case 1:
                        {
                            Console.WriteLine("Digite a placa do veículo que está entrando:");
                            string placa = Console.ReadLine();
                            veiculos.Add(placa);
                            Console.WriteLine("Veículo inserido com sucesso");
                            break;
                        }

                    //remove o veiculo e calcula o preço a pagar
                    case 2:
                        {
                            //deve ser digitada literalmente da forma que foi inserida
                            Console.WriteLine("Digite a placa do veículo que está saindo:");
                            string removerPlaca = Console.ReadLine();
                            veiculos.Remove(removerPlaca);

                            Console.WriteLine("Removendo veículo e calculando valor a pagar: ");

                            Console.WriteLine("Qual o tempo estacionado? Digite o valor em Horas (horas fracionadas use o formato \"0,00\"): ");
                            double tempoEstacionado = double.Parse(Console.ReadLine());

                            //formula baseada naquilo que foi inserido em Configurações (4)
                            double precoTotal = precoInicial + (tempoEstacionado * precoPorHora);
                            Console.WriteLine($"O valor a pagar é: {precoTotal} Reais.");
                            break;
                        }

                    case 3:
                        {
                            //usa foreach loop para listar veiculos
                            Console.WriteLine("Lista de veículos estacionados no momento:");
                            foreach (string veiculo in veiculos)
                            {
                                Console.WriteLine(veiculo);
                            }
                            break;
                        }

                    case 4:
                        {
                            //aqui configura os valores cobrados antes do inicio do resto
                            //se digitar valores como 0.5 ou 0,5 da erro, a consertar
                            Console.WriteLine("Página de Configuração\n\n");
                            Console.WriteLine("Qual o preço fixo de cada vaga? Digite valores inteiros em Reais: ");
                            precoInicial = double.Parse(Console.ReadLine());
                            Console.WriteLine("Qual o preço por hora de cada vaga? Digite valores inteiros em Reais: ");
                            precoPorHora = double.Parse(Console.ReadLine());
                            Console.WriteLine("Registrando valores...");
                            break;
                        }

                    case 5:
                        {
                            //retorna e sai do while loop
                            Console.WriteLine("Saindo da Aplicação");
                            return;
                        }

                    default:
                        {
                            //default case, caso escolha algo invalido
                            Console.WriteLine("Escolha inválida, tente novamente.");
                            break;
                        }
                }
            }
        }
    }
}

