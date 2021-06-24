using System;

namespace proyecto3
{
    class Program
    {
        public static long Potencia(long a, long p)
        {
            int i = 1;
            long n = 1;

            for (i = 1; i <= p; i++)
            {
                n *= a;
            }

            return n;
        }
        public static long permutacionSinRepeticion(long n)
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

        public static double Emparejamiento(long m, long n)
        {
            double e;
            
            e = permutacionSinRepeticion(m * n) / (Potencia(permutacionSinRepeticion(m), n) * permutacionSinRepeticion(n));
           
            return e;
        }

        public static float variacionSinRepeticion(int n, int r)
        {
            float v;
            v = 0.0f;
            v = permutacionSinRepeticion(n) / permutacionSinRepeticion(n - r);
            return v;
        }

        public static long variacionConRepeticion(int n, int r)
        {
            long v = 0;
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
            c = permutacionSinRepeticion((n + r) - 1) / (permutacionSinRepeticion(r) * permutacionSinRepeticion(n - 1));
            return c;
        }

        static void Main(string[] args)
        {
            int n, a, b, c, d, p, r, aux, aux2, s;
            long m, k;

            String resp;
            n = 0;
            a = 0;
            b = 0;
            c = 0;
            d = 0;
            p = 0;
            r = 0;
            k = 0;

            aux = 0;
            aux2 = 0;
            s = 0;
            resp = "";
            do
            {
                Console.Clear();
                aux2 = 0;
                Console.WriteLine("OPERACIONES DE COMBINATORIA\n\n");
                Console.WriteLine("Seleccione una opción: \n");
                Console.WriteLine("1. Permutación sin repetición\n2. Permutación con repetición\n3. Emparejamientos\n4. Variación sin repetición\n5. Varación con reperición\n6. Combinación sin repetición\n7. Combinación con repetición\n8. Salir");
                s = int.Parse(Console.ReadLine());
                switch (s)
                {
                    case 1:
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("PERMUTACIÓN SIN REPETICIÓN\n\n");
                            Console.WriteLine("Ingrese el valor de n: ");
                            n = int.Parse(Console.ReadLine());
                            Console.WriteLine("La respuesta es: " + permutacionSinRepeticion(n) + "\n");
                            Console.Write("¿Desea continuar con PERMUTACIÓN SIN REPETICIÓN? (s/n): ");
                            resp = Console.ReadLine();
                            if (resp == "n" || resp == "N")
                            {
                                aux = 0;
                                aux2 = 1;
                            }
                            else if (resp == "S" || resp == "s")
                            {
                                aux2 = 0;
                            }
                        } while (aux2 != 1);
                        break;

                    case 2:
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("PERMUTACIÓN CON REPETICIÓN\n\n");
                            Console.Write("Ingrese el valor de n: ");
                            n = int.Parse(Console.ReadLine());
                            Console.Write("Ingrese el valor de a: ");
                            a = int.Parse(Console.ReadLine());
                            Console.Write("Ingrese el valor de b: ");
                            b = int.Parse(Console.ReadLine());
                            Console.Write("Ingrese el valor de c: ");
                            c = int.Parse(Console.ReadLine());
                            Console.WriteLine("La respuesta es: " + permutacionConRepeticion(n, a, b, c));
                            Console.Write("¿Desea continuar con PERMUTACIÓN CON REPETICIÓN? (s/n): ");
                            resp = Console.ReadLine();
                            if (resp == "n" || resp == "N")
                            {
                                aux = 0;
                                aux2 = 1;
                            }
                            else if (resp == "S" || resp == "s")
                            {
                                aux2 = 0;
                            }
                        } while (aux2 != 1);
                        break;
                    case 3:
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("EMPAREJAMIENTOS\n\n");
                            Console.Write("Ingrese el valor de m: ");
                            m = long.Parse(Console.ReadLine());
                            Console.Write("Ingrese el valor de n: ");
                            k = long.Parse(Console.ReadLine());
                            Console.WriteLine("La respuesta es: " + Emparejamiento(m, k));
                            Console.Write("¿Desea continuar con el EMPAREJAMIENTO? (s/n): ");
                            resp = Console.ReadLine();
                            if (resp == "n" || resp == "N")
                            {
                                aux = 0;
                                aux2 = 1;
                            }
                            else if (resp == "S" || resp == "s")
                            {
                                aux2 = 0;
                            }
                        } while (aux2 != 1);

                        break;
                    case 4:
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("VARIACIONES SIN REPETICIÓN\n\n");
                            Console.Write("Ingrese el valor de n: ");
                            n = int.Parse(Console.ReadLine());
                            Console.Write("Ingrese el valor de r: ");
                            r = int.Parse(Console.ReadLine());
                            Console.WriteLine("La respuesta es: " + variacionSinRepeticion(n, r));
                            Console.Write("¿Desea continuar con VARIACION SIN REPETICION? (s/n): ");
                            resp = Console.ReadLine();
                            if (resp == "n" || resp == "N")
                            {
                                aux = 0;
                                aux2 = 1;
                            }
                            else if (resp == "S" || resp == "s")
                            {
                                aux2 = 0;
                            }
                        } while (aux2 != 1);
                        break;
                    case 5:
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("VARIACIONES CON REPETICIÓN\n\n");
                            Console.Write("Ingrese el valor de n: ");
                            n = int.Parse(Console.ReadLine());
                            Console.Write("Ingrese el valor de r: ");
                            r = int.Parse(Console.ReadLine());
                            Console.WriteLine("La respuesta es: " + variacionConRepeticion(n, r));
                            Console.Write("¿Desea continuar con VARIACION CON REPETICION? (s/n): ");
                            resp = Console.ReadLine();
                            if (resp == "n" || resp == "N")
                            {
                                aux = 0;
                                aux2 = 1;
                            }
                            else if (resp == "S" || resp == "s")
                            {
                                aux2 = 0;
                            }
                        } while (aux2 != 1);
                        break;
                    case 6:
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("COMBINACIONES SIN REPETICIÓN\n\n");
                            Console.Write("Ingrese el valor de n: ");
                            n = int.Parse(Console.ReadLine());
                            Console.Write("Ingrese el valor de r: ");
                            r = int.Parse(Console.ReadLine());
                            Console.WriteLine("La respuesta es: " + combinacionSinRepeticion(n, r));
                            Console.Write("¿Desea continuar con COMBINACIÓN SIN REPETICION? (s/n): ");
                            resp = Console.ReadLine();
                            if (resp == "n" || resp == "N")
                            {
                                aux = 0;
                                aux2 = 1;
                            }
                            else if (resp == "S" || resp == "s")
                            {
                                aux2 = 0;
                            }
                        } while (aux2 != 1);
                        break;
                    case 7:
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("COMBINACIONES CON REPETICIÓN\n\n");
                            Console.Write("Ingrese el valor de n: ");
                            n = int.Parse(Console.ReadLine());
                            Console.Write("Ingrese el valor de r: ");
                            r = int.Parse(Console.ReadLine());
                            Console.WriteLine("La respuesta es: " + combinacionesConRepeticion(n, r));
                            Console.Write("¿Desea continuar con VARIACION CON REPETICION? (s/n): ");
                            resp = Console.ReadLine();
                            if (resp == "n" || resp == "N")
                            {
                                aux = 0;
                                aux2 = 1;
                            }
                            else if (resp == "S" || resp == "s")
                            {
                                aux2 = 0;
                            }
                        } while (aux2 != 1);
                        break;
                    case 8:
                        aux = 1;
                        break;
                }
            } while (aux != 1);

        }
    }
}
