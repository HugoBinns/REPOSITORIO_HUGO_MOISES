using System;

namespace ConsoleApp1
{
    class Program
    {
        protected static int origRow;
        protected static int origCol;
        protected static void WriteAt(string s, int x, int y)
        {
            try
            {
                Console.SetCursorPosition(origCol + x, origRow + y);
                Console.Write(s);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.Clear();
                Console.WriteLine(e.Message);
            }
        }
        static void Main(string[] args)
        {

            int posA, posB, posAux1, posAux2, posAux3, posAux4, j, k;
            bool a, b, c, d;
            posA = 0;
            posB = 0;
            posAux1 = 0;
            posAux2 = 0;
            posAux3 = 0;

            j = 0;
            k = 0;

            a = true;
            b = true;
            c = true;
            d = true;
           
            Console.WriteLine("OPERACIONES LÓGICAS BÁSICAS POR MOISÉS Y HUGO\n\n");
            Console.WriteLine("Presione una tecla...");
            Console.ReadLine();
            Console.WriteLine("Operación 1: (a ^ b) v ~b");
            Console.ReadLine();
            Console.WriteLine("Presione una tecla...");

            
            //Estos son los encabezados
            WriteAt("a", 4, 9);
            WriteAt("b", 10, 9);
            WriteAt("(a ^ b)", 16, 9);
            WriteAt("~b", 29, 9);
            WriteAt("(a ^ b) v ~b", 36, 9);

            posA = 9;
            posB = 9;
            posAux1 = 9;
            posAux2 = 9;
            posAux3 = 9;

            for (j = 0; j <= 1; j++)
            {
                if (j == 0)
                    a = false;
                else
                    a = true;

                for (k = 0; k <= 1; k++)
                {
                    if (k == 0)
                        b = false;
                    else
                        b = true;
                    //Esto es a
                    WriteAt(j.ToString(), 4, posA+=1);

                    //Esto es b
                    WriteAt(k.ToString(), 10, posB+=1);

                    //Esto es (a ^ b)
                    if (a && b)
                        WriteAt("1", 19, posAux1 += 1);
                    else
                        WriteAt("0", 19, posAux1 += 1);

                    //Esto es ~b
                    if (b)
                        WriteAt("0", 30, posAux2 += 1);
                    else
                        WriteAt("1", 30, posAux2 += 1);

                   if(a || b)
                        WriteAt("1", 42, posAux3 += 1);
                    else
                        WriteAt("0", 42, posAux3 += 1);


                    Console.ReadLine();
                }
            }

            WriteAt("Presione una tecla... ", 0, 15);
            Console.ReadLine();

            WriteAt("Operación 2: (a -> b) ^ ~(a v b)", 0, 17);
            Console.ReadLine();


            WriteAt("a", 4, 19);
            WriteAt("b", 10, 19);
            WriteAt("(a -> b)", 16, 19);
            WriteAt("(a v b)", 29, 19);
            WriteAt("~(a v b)", 40, 19);
            WriteAt("(a -> b) ^ ~(a v b)", 53, 19);


            Console.ReadLine();

            
            posA = 19;
            posB = 19;
            posAux1 = 19;
            posAux2 = 19;
            posAux3 = 19;
            posAux4 = 19;
            for (j = 0; j <= 1; j++)
            {
                if (j == 0)
                    a = false;
                else
                    a = true;

                for (k = 0; k <= 1; k++)
                {
                    if (k == 0)
                        b = false;
                    else
                        b = true;
                    //Esto es a
                    WriteAt(j.ToString(), 4, posA += 1);

                    //Esto es b
                    WriteAt(k.ToString(), 10, posB += 1);

                    //Esto es (a -> b)
                    if (a == b)
                    {
                        WriteAt("1", 19, posAux1 += 1);
                        c = true;
                    }
                    else
                    {
                        WriteAt("0", 19, posAux1 += 1);
                        c = false;
                    }
                    
                    //Esto es (a v b)
                    if (a || b)
                        WriteAt("1", 32, posAux2 += 1);
                    else
                        WriteAt("0", 32, posAux2 += 1);

                    //Esto es ~(a v b)
                    if (a || b)
                    {
                        WriteAt("0", 44, posAux3 += 1);
                        d = false;
                    }
                    else
                    {
                        WriteAt("1", 44, posAux3 += 1);
                        d = true;
                    }

                    //Esto es (a -> b) ^ ~(a v b)

                    if (c && d)
                        WriteAt("1", 64, posAux4 += 1);
                    else
                        WriteAt("0", 64, posAux4 += 1);



                    Console.ReadLine();
                }
            }
            


        }
    }
}
