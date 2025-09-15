using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace psc_lista_02_2025.Models
{
    public class Lista
    {
        /// <summary>
        /// Faça um Programa que peça um número e então mostre a mensagem: O número informado foi [número]. 
        /// </summary>
        public void Exercicio1()
        {
            try
            {
                Console.Write("Digite um número: ");
                int numero = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Você digitou: {numero}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Formato de número inválido.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Número muito grande ou muito pequeno.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro: {ex.Message}");
            }
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
        /// <summary>
        /// Faça um Programa que peça dois números e imprima a soma, a  subtração e a multiplicação do primeiro pelo segundo. 
        /// </summary>
        public void Exercicio2()
        {
            try
            {
                Console.Write("Digite o primeiro número: ");
                int numero1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Digite o segundo número: ");
                int numero2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Soma: {numero1 + numero2}");
                Console.WriteLine($"Subtração: {numero1 - numero2}");
                Console.WriteLine($"Multiplicação: {numero1 * numero2}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Formato de número inválido.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Número muito grande ou muito pequeno.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro: {ex.Message}");
            }
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
        /// <summary>
        /// Faça um Programa que peça as 4 notas bimestrais e mostre a média. 
        /// </summary>
        public void Exercicio3()
        {
            try
            {
                Console.Write("Digite a primeira nota: ");
                double nota1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite a segunda nota: ");
                double nota2 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite a terceira nota: ");
                double nota3 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite a quarta nota: ");
                double nota4 = Convert.ToDouble(Console.ReadLine());

                double media = (nota1 + nota2 + nota3 + nota4) / 4;
                Console.WriteLine($"A média das notas é: {media}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Formato de número inválido.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Número muito grande ou muito pequeno.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro: {ex.Message}");
            }
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
        /// <summary>
        /// Faça um programa que peça o preço do litro da gasolina e solicite  quantos litros foi vendido a determinado cliente. 
        /// O programa deve informar quanto o cliente deverá pagar pela gasolina  comprada.
        /// </summary>
        public void Exercicio4()
        {
            try
            {
                Console.Write("Digite o preço do litro da gasolina: ");
                double precoPorLitro = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite a quantidade de litros vendidos: ");
                double litrosVendidos = Convert.ToDouble(Console.ReadLine());

                double totalAPagar = precoPorLitro * litrosVendidos;
                Console.WriteLine($"O total a pagar pela gasolina é: {totalAPagar}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Formato de número inválido.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Número muito grande ou muito pequeno.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro: {ex.Message}");
            }
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
        /// <summary>
        /// Faça um programa que peça o valor de uma viagem “eurotrip” que será  realizada por um grupo de amigos. Os brasileiros sairão com destino a  três locais: 1º Alemanha, 2º Portugal e 3º Itália. 
        /// O programa deve solicitar o preço atual de cada viagem, a quantidade  de pessoas que irão nessa viagem.
        /// Após isso, imprimir o valor total da viagem somando a quantidade total de pessoas que visitarão todos os  03 destinos. 
        /// </summary>
        public void Exercicio5()
        {
            try
            {
                Console.WriteLine("Digite o preço atual da viagem à Alemanha: ");
                double alemanha = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite o preço atual da viagem a Portugal: ");
                double portugal = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite o preço atual da viagem à Itália: ");
                double italia = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite o número de pessoas: ");
                int pessoas = Convert.ToInt32(Console.ReadLine());

                double valorTotal = (alemanha + portugal + italia) * pessoas;

                Console.WriteLine($"O gasto total será de R${valorTotal:F2}!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Formato de número inválido.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Número muito grande ou muito pequeno.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro: {ex.Message}");
            }
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }   

}