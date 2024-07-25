using System;

namespace Calculator {
    class Program {
        static void Main(string[] args) {
            Console.Clear();
            Menu();
        }
        static void Menu() {
            Console.WriteLine("Oque deseja fazer ?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("0 - Sair");

            Console.WriteLine("-----------------");
            Console.Write("Selecione uma opção: ");
            short res = short.Parse(Console.ReadLine());

            switch (res) {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 0: System.Environment.Exit(0); break;
                default: Menu(); break;
            }

        }
        static void Soma() {

            Console.Write("Primerio valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.Write("Segundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            float resultado = v1 + v2;
            Console.WriteLine($"O resultado da Soma é: {resultado}");

            Menu();

        }
        static void Subtracao() {
            Console.Write("Digite o primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            float resultado = v1 - v2;
            Console.WriteLine($"O resultado da subtração é: {resultado}");

            Menu();
        }
        static void Divisao() {
            Console.Write("Digite o primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            float resultado = v1 / v2;
            Console.WriteLine($"O resultado da divisão é: {resultado}");

            Menu();
        }
        static void Multiplicacao() {
            Console.Write("Digite o primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            float resultado = v1 * v2;
            Console.WriteLine($"O resultado da multiplicação é: {resultado}");

            Menu();
        }

    }
}