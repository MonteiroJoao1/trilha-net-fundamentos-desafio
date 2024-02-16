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

        public void AdicionarVeiculo(string placa)
        {
            veiculos.Add(placa.ToUpper);
            Console.WriteLine("Veículo adicionado com sucesso!");
        }

        public void RemoverVeiculo(string placa, string hora)
        {
            int indice = veiculos.IndexOf(placa);
            if (indice != -1)
            {
                int horas           = 0;
                decimal valorTotal  = 0;
                int horas           = int.TryParse(hora, out 0);
                valorTotal          = precoInicial + (horas * precoPorHora);

                veiculos.Remove(placa);
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                foreach(string iten in veiculos)
                {
                    Console.WriteLine(iten);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
