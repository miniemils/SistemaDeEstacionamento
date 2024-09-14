using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace src.Models
{
    public class Estacionamento
    {
        private decimal precoInicial;
        private decimal precoPorHora;
        private List <string> lista = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora) {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo() {
            Console.Write("Digite a placa do veículo que deseja estacionar: ");
            string placa = Console.ReadLine()!;
            lista.Add(placa);
        }

        public void RemoverVeiculo() {
            Console.Write("Digite a placa do veículo que deseja remover: ");
            string placa = Console.ReadLine()!;
            if (lista.Contains(placa)) {
                lista.Remove(placa);
                Console.Write("Digite a quantidade de horas que o veículo permaneceu estacionado: ");
                int quantidadeDeHoras = Convert.ToInt32(Console.ReadLine());
                decimal valorTotal = precoPorHora * quantidadeDeHoras + precoInicial;
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de R$ {valorTotal.ToString("F2")}");
            }
            else {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }

        public void ListarVeiculos() {
            Console.WriteLine("Os veículos estacionados são:");
            for(int i = 0; i < lista.Count; i++) {
                Console.WriteLine(lista[i]);
            }
        }
    }
}