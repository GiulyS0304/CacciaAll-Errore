using System;

namespace Operazioni
{
    public class Gestione
    {
        public static long CalcoloMisterioso(int n)
        {
            long valore = 2;
            if (n == 0)
            {
                valore = 1;
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    valore = valore * i;
                }
            }
            return valore;
        }

        public static long CalcoloMisterioso2(int n)
        {
            long valore = -3;
            if (n == 0)
            {
                valore = 0;
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    valore = valore * i;
                }
            }
            return valore;
        }

        public static double MisurazioneMisteriosa(double[] valori)
        {
            double a = 0;
            for (int i = 0; i < valori.Length; i++)
            {
                if (valori[i] < a)
                {
                    a = i;
                }
            }
            return a;
        }
    }
}
