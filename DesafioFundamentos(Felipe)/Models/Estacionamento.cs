namespace DesafioFundamentosFelipe.Models
{

    //Criando classe estacionamento 
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        // Medoto Contrutor para iniciar os atributos da classe
        public Estacionamento(decimal precoInicial, decimal precoPorHora)
            {
                this.precoInicial = precoInicial;
                this.precoPorHora = precoPorHora;
            }

            
            // Desenvolvendo as funcionalidades do sistema

            public void AdicionarVeiculo()
            {
                Console.WriteLine("Digite  a Placa do veiculo : ");
                veiculos.Add(Console.ReadLine() ?? "");
            }

            public void RemoverVeiculo()

            {
                if(veiculos.Any())
                    {
                        int contador = 1;
                        Console.WriteLine("Os veiculos estacionados são : ");
                        foreach (string car in veiculos)
                        {
                            
                            Console.WriteLine(contador + "--"+ car.ToUpper());
                            contador ++ ;
                        }
                    }
                   
                Console.WriteLine("Digite a placa do veículo para remover : ");
                string placa = Console.ReadLine()?? "";

                // Verifica se existe o veiculo digitado pelo usuario no estacionamento
                if(veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
                {  
                    
                    
                    Console.WriteLine("Digite  a quantidade de Horas que o veículo permaneceu estacionado");
                    int hora = Convert.ToInt32(Console.ReadLine() ?? "");
                    decimal valorTotal = precoInicial + precoPorHora * hora;
                    Console.WriteLine("Removendo a Placa do sistema...");
                    veiculos.Remove(placa);
                    Console.WriteLine($"O Veículo de placa ({placa}) foi removido e o preço total foi de : R$ {valorTotal}");
                }
                else
                {
                    Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
                }

            }

            public void ListarVeiculos ()
            {
                if(veiculos.Any())
                {
                    int contador = 1;
                    Console.WriteLine("Os veiculos estacionados são : ");
                    foreach (string car in veiculos)
                    {
                        
                        Console.WriteLine(contador + "--"+ car.ToUpper());
                        contador ++ ;
                    }
                }
                else
                {
                    Console.WriteLine("Não há Veículos estacionados.");    
                
                    
                }

            }
    }
}