using System;
using System.Globalization;

namespace AluguelDeQuartos {
    class Program {
        static void Main(string[] args) {
            Console.Write("How many rooms will be rented: ");
            int numeroDeQuartos = int.Parse(Console.ReadLine());

            Quarto[] quartos = new Quarto[10];

            for (int i = 1; i <= numeroDeQuartos; i++) {
                Console.WriteLine();
                Console.WriteLine($"Rent #{i}: ");

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                Console.Write("Numero do quarto: ");
                int quarto = int.Parse(Console.ReadLine());

                quartos[quarto] = new Quarto(name, email);
            }

            Console.WriteLine("-----------------------------");
            Console.WriteLine("Relatório dos Quartos alugados:");
            for (int i = 0; i < 10; i++) {
                if (quartos[i] != null) {
                    Console.WriteLine(i +": "+ quartos[i]);
                }                
            }
        }
    }
}
