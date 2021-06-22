using System;

namespace proyecto3
{
    class Program
    {


        public static int Potencia(int a, int p)
        {
            int i = 0;
            int n = 1;

            for (i = 1; i <= p; i++)
            {
                n *= a;
            }

            return n;
        }
        public static int permutacionSinRepeticion(int n)
        {
            int i, a;
            a = 1;
            for (i = 1; i <= n; i++)
            {
                a *= i;
            }
            return a;
        }

        public static float permutacionConRepeticion(int n, int a, int b, int c)
        {
            float p;
            p = 0.0f;
            p = permutacionSinRepeticion(n) / (permutacionSinRepeticion(a) * permutacionSinRepeticion(b) * permutacionSinRepeticion(c));
            return p;
        }

        public static float Emparejamiento(int m, int n)
        {
            float e;
            int a, b, c;
            a = 1;
            b = 1;
            c = 1;
            e = 0.0f;

            a = permutacionSinRepeticion(m * n);
            b = Potencia(permutacionSinRepeticion(m), n);
            c = permutacionSinRepeticion(n);

            e = a / (b * c);
           
            return e;
        }

        public static float variacionSinRepeticion(int n, int r)
        {
            float v;
            v = 0.0f;
            v = permutacionSinRepeticion(n) / permutacionSinRepeticion(n - r);
            return v;
        }

        public static int variacionConRepeticion(int n, int r)
        {
            int v = 0;
            v = Potencia(n, r);
            return v;
        }

        public static float combinacionSinRepeticion(int n, int r)
        {
            float c = 0.0f;
            c = permutacionSinRepeticion(n) / (permutacionSinRepeticion(r) * (permutacionSinRepeticion(n - r)));
            return c;
        }

        public static float combinacionesConRepeticion(int n, int r)
        {
            float c = 0.0f;
            c = permutacionSinRepeticion(n + r - 1) / permutacionSinRepeticion(r) * permutacionSinRepeticion(n - 1);
            return c;
        }

        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Ingrese un número: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine(permutacionSinRepeticion(n).ToString());

        }
    }
}
