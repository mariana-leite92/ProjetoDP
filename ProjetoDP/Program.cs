using ProjetoDP.Model;
using System;
using System.Collections.Generic;

namespace ProjetoDP.Linq.Extension
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Cachorro> cachorros = new List<Cachorro>()
            {
                new Cachorro() { Raca = "Maltês", Cor = "Branca", Porte = "Pequeno" },
                new Cachorro() { Raca = "Lhasa-Apso", Cor = "Mesclado bege e branco", Porte = "Pequeno" },
                new Cachorro() { Raca = "Lhasa-Apso", Cor = "Preto", Porte = "Pequeno" },
            };

            IEnumerable<Cachorro> cachorrosRacasDiferentes = cachorros.Distinct(c => c.Raca);

            Console.WriteLine("Lista de cachorros de raças distintas");      
            
            foreach (Cachorro cachorro in cachorrosRacasDiferentes)
            {
                Console.WriteLine($"Raça: {cachorro.Raca}, Cor: {cachorro.Cor}, Porte {cachorro.Porte}");
            }

            Console.ReadLine();
        }
    }
}
