using System;

namespace compileresult
{
     class Program
     {
          public void cargarValores()
          {
               string mensaje;
               Console.Write("Ingrese primer valor:");
               mensaje = Console.ReadLine();
               int valor1 = int.Parse(mensaje);
               Console.Write("Ingrese segundo valor:");
               mensaje = Console.ReadLine();
               int valor2 = int.Parse(mensaje);
               Console.Write("Ingrese tercer valor:");
               mensaje = Console.ReadLine();
               int valor3 = int.Parse(mensaje);
               int mayor, menor;
               mayor = CalcularMayor(valor1, valor2, valor3);
               menor = CalcularMenor(valor1, valor2, valor3);
               Console.WriteLine("El valor mayor de los tres es:" + mayor);
               Console.WriteLine("El valor menor de los tres es:" + menor);
          }

          public int CalcularMayor(int v1, int v2, int v3)
          {
               int m;
               if (v1 > v2 && v1 > v3)
               {
                    m = v1;
               }
               else
               {
                    if (v2 > v3)
                    {
                         m = v2;
                    }
                    else
                    {
                         m = v3;
                    }
               }
               return m;
          }

          public int CalcularMenor(int v1, int v2, int v3)
          {
               int m;
               if (v1 < v2 && v1 < v3)
               {
                    m = v1;
               }
               else
               {
                    if (v2 < v3)
                    {
                         m = v2;
                    }
                    else
                    {
                         m = v3;
                    }
               }
               return m;
          }
          static void Main(string[] args)
          {
               Program mm = new Program();
               mm.cargarValores();
               Console.Write("Ciclo While que imprime los primeros 10 números de la serie : 11, 22, etc\n");
               int x, termino;
               x = 1;
               termino = 11;
               while (x <= 10)
               {
                    Console.Write(termino);
                    Console.Write(" - ");
                    x = x + 1;
                    termino = termino + 11;
               }

               Console.Write("Ciclo for que imprime los numeros del 1 al 100\n");
               int f;
               for (f = 1; f <= 100; f++)
               {
                    Console.Write(f);
                    Console.Write("-");
               }

               Console.ReadKey();



          }
     }
}
