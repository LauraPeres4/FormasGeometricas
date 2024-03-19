using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormasGeometricas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha alguma forma geométrica entre losango(1), quadrado(2), trapézio(3) e retangulo(4): ");
            int forma = int.Parse(Console.ReadLine());


            switch (forma)
            {
                case 1:
                    Console.WriteLine("Informe a diagonal maior do losango: ");
                    double D = double.Parse(Console.ReadLine());

                    Console.WriteLine("Agora informe a diagonal menor do losango: ");
                    double d = double.Parse(Console.ReadLine());

                    double arealosango = (D * d) / 2;
                    Console.WriteLine("A área do losango é de: " + arealosango);
                    break;

                case 2:
                    Console.WriteLine("Informe o valor da base do quadrado: ");
                    double h = double.Parse(Console.ReadLine());

                    double areaquadrado = h * h;
                    Console.WriteLine("A área do quadrado é de: " +  areaquadrado);
                    break;

                case 3:
                    Console.WriteLine("Informe o valor da base maior: ");
                    double B = double.Parse(Console.ReadLine());

                    Console.WriteLine("Informe o valor da base menor");
                    double b = double.Parse(Console.ReadLine());

                    Console.WriteLine("Agora informe o valor da altura: ");
                    double alt = double.Parse(Console.ReadLine());

                    double areatrapezio = (b + B) * alt / 2;
                    Console.WriteLine("A área do trapézio é de: " + areatrapezio);
                    break;

                case 4:
                    Console.WriteLine("Informe a base do retangulo: ");
                    double b2 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Agora informe a altura do retangulo: ");
                    double h2 = double.Parse(Console.ReadLine());

                    double arearetangulo = b2 * h2;
                    Console.WriteLine("A área do retangulo é: " + arearetangulo); 
                    break;

                default:
                    Console.WriteLine("Opção inválida: ");
                    break;
            }

            Console.ReadKey();



        }
    }
}
