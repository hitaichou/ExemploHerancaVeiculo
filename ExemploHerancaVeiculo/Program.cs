using System;
using ExemploHerancaVeiculo.Entities;
using System.Collections.Generic;
using System.Globalization;
using ExemploHerancaVeiculo.Entities.Exceptions;

namespace ExemploHerancaVeiculo
{
    class Program
    {
        static void Main(string[] args)
        {
            double _vlTotalPreco = 0;
            double _vlTotalImposto = 0;

            try
            {
                Console.Write("Entre com o número de veículos: ");
                int n = int.Parse(Console.ReadLine());

                List<Veiculo> list = new List<Veiculo>();

                for (int i = 1; i <= n; i++ )
                {
                    Console.Write("Entre com o tipo entre Carro, Moto ou Caminhão (car/mot/cam): ");
                    string tipo = Console.ReadLine();
                    Console.Write("Entre com o modelo do veículo: ");
                    string modelo = Console.ReadLine();
                    Console.Write("Entre com a cor do veículo: ");
                    string cor = Console.ReadLine();
                    Console.Write("Entre com o fabricante: ");
                    string fabricante = Console.ReadLine();
                    Console.Write("Entre com o ano: ");
                    int ano = int.Parse(Console.ReadLine());
                    Console.Write("Entre com o preço: ");
                    double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("O veículo é importado? ");
                    char importado = char.Parse(Console.ReadLine().ToUpper());


                    if(tipo != "car"  && tipo != "mot" && tipo != "cam")
                    {
                        throw new DomainException("Não existe este tipo de veículo.");
                    }
                    else
                    {
                        if (tipo == "car")
                        {
                            list.Add(new Carro(modelo, cor, fabricante, ano, importado, preco));
                        }
                        else if (tipo == "mot")
                        {
                            list.Add(new Moto(modelo, cor, fabricante, ano, importado, preco));
                        }
                        else 
                        {
                            list.Add(new Caminhao(modelo, cor, fabricante, ano, importado, preco));
                        }
                    }
                   
                }
                Console.WriteLine();
                Console.WriteLine("---------------------------------------");

                foreach(Veiculo veiculo in list)
                {
                    _vlTotalPreco += veiculo.CalculaPreco();
                    _vlTotalImposto += veiculo.CalculaImposto();
                    Console.WriteLine("------------------------");
                    Console.WriteLine("Modelo: " + veiculo.Modelo + " \n"
                                    + "Cor: " + veiculo.Cor + " \n"
                                    + "Fabricante: " + veiculo.Fabricante + " \n"
                                    + "Ano: " + veiculo.Ano + " \n"
                                    + "Importado: " + veiculo.Importado + " \n"
                                    + "Imposto: " + veiculo.CalculaImposto().ToString("F2",CultureInfo.InvariantCulture) + " \n"
                                    + "Preco: " + veiculo.CalculaPreco().ToString("F2", CultureInfo.InvariantCulture));
                    
                }
                Console.WriteLine("------------------------");                
                Console.WriteLine("VALORES TOTAIS");
                Console.WriteLine("------------------------");
                Console.WriteLine("Valor total dos impostos: " + _vlTotalImposto.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Preço total dos veículos: " + _vlTotalPreco.ToString("F2", CultureInfo.InvariantCulture));
                

            }
            catch(FormatException e)
            {
                Console.WriteLine("Erro no formato de lançamento." + e.Message);
            }

            catch(Exception e)
            {
                Console.WriteLine("Erro de lançamento." + e.Message);
            }
            
        }
    }
}


/*
 
     public string Cor { get; set; }
        public string Fabricante { get; set; }
        public int Ano { get; set; }
        public double Preco { get; set; }
        public char Importado { get; set; }
        public string Nome { get; set; }
     
     */
