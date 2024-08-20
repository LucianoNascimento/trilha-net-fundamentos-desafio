namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"      
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine(); //armazena a placa
            veiculos.Add(placa.ToUpper()); //aciona a placa em maiusculo
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            // Pedir para o usuário digitar a placa e armazenar na variável placa
            string placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                int horas = int.Parse(Console.ReadLine()); //convertendo para inteiro a digitada e armazenando o valor digitado
                decimal valorTotal = precoInicial + precoPorHora * horas; //calculo do valor total

                // TODO: Remover a placa digitada da lista de veículos
                veiculos.Remove(placa);
                Console.WriteLine($"Valor inicial da hora R$ {precoInicial}, O valor da hora adicional R$ {precoPorHora}.\nO veículo de placa {placa.ToUpper()} deixou o estacionamento.O preço total a pagar é de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                
                foreach (string listaVeiculos  in veiculos)
                {
                    Console.WriteLine(listaVeiculos);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
