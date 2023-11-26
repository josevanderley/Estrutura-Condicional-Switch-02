using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESTRUTURA_CONDICIONAL___SWITCH__01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor total da compra: ");
            decimal valorTotal = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite o código do cliente (1 para comum, 2 para funcionário, 3 para VIP): ");
            int codigoCliente = Convert.ToInt32(Console.ReadLine());
            
            decimal desconto = 0;

            switch (codigoCliente)
            {
                case 1:
                    // Cliente comum, sem desconto adicional
                    break;
                case 2:
                    // Funcionário, 10% de desconto
                    desconto = 0.1m;
                    break;
                case 3:
                    // Cliente VIP, 5% de desconto
                    desconto = 0.05m;
                    break;
                default:
                    Console.WriteLine("Código de cliente inválido.");
                    return;
            }


            // Calcula o valor total a ser pago
            decimal valorFinal = valorTotal - (valorTotal * desconto);

            Console.WriteLine($"Valor total a ser pago: {valorFinal:C}");

            Console.ReadKey();
        }
    }
}
    

