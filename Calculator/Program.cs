using System;

namespace Calculator {
    class Program {
        static void Main(string[] args) {
            Menu();

        }
        static void Menu() {
            Console.WriteLine("Oque deseja fazer ?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair");

            Console.WriteLine("-----------------");
            Console.Write("Selecione uma opção: ");
            short res = short.Parse(Console.ReadLine());

        }
        static void Soma() {

            Console.Write("Primerio valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.Write("Segundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            float resultado = v1 + v2;
            Console.Write($"O resultado da Soma é: {resultado}");

        }
        static void Subtracao() {
            Console.Write("Digite o primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            float resultado = v1 - v2;
            Console.WriteLine($"O resultado da subtração é: {resultado}");
        }
        static void Divisao() {
            Console.Write("Digite o primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            float resultado = v1 / v2;
            Console.WriteLine($"O resultado da divisão é: {resultado}");
        }
        public static void Mutiplicacao() {
            Console.Write("Digite o primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            float resultado = v1 * v2;
            Console.WriteLine($"O resultado da multiplicação é: {resultado}");
        }

    }
}