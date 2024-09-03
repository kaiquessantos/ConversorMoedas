using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorMoedas
{
    internal class Program
    {


        enum Opcao
        {
            Sair, Euro, Dolar, Libra
        }


        static void Main(string[] args)
        {
            
            bool close = false;
            while (!close)
            {
                Console.WriteLine("Bem-vindo ao CHANGE, seu conversor de moedas!");
                Console.WriteLine("Digite:\n0-Sair\n1-Euro\n2-Dolar\n3-Libra");
                int escolha = int.Parse(Console.ReadLine());
                Opcao change = (Opcao)escolha;

                switch (change)
                {
                    case Opcao.Sair:
                        close = true;
                        break;

                    case Opcao.Euro:
                        Console.WriteLine("Digite aqui o valor a ser convertido: ");
                        float euroConv = float.Parse(Console.ReadLine());
                        Console.WriteLine($"O valor em euros na sua conta será:{euro(euroConv)}!");
                        Console.WriteLine("Para voltar ao menu tecle ENTER.");
                        Console.ReadLine();
                        break;

                    case Opcao.Dolar:
                        Console.WriteLine("Digite aqui o valor a ser convertido: ");
                        float dolarConv = float.Parse(Console.ReadLine());
                        Console.WriteLine($"O valor em dolares na sua conta será:{dolar(dolarConv)}!");
                        Console.WriteLine("Para voltar ao menu tecle ENTER.");
                        Console.ReadLine();
                        break;

                    case Opcao.Libra:
                        Console.WriteLine("Digite aqui o valor a ser convertido: ");
                        float libraConv = float.Parse(Console.ReadLine());
                        Console.WriteLine($"O valor em libras na sua conta será:{libra(libraConv)}!");
                        Console.WriteLine("Para voltar ao menu tecle ENTER.");
                        Console.ReadLine();
                        break;
                }

                Console.Clear();
            }



        }

        static float euro(float valor)
        {
            float conveuro = 6.2f;
            return valor / conveuro;
        }

        static float dolar(float valor)
        {
            float convdolar = 5.7f;
            return valor / convdolar;
        }

        static float libra(float valor)
        {
            float convlibra = 7.3f;
            return valor / convlibra;
        }
    }
}
