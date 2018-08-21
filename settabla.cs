using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegodelaVida
{
    class settabla
    {
        int[,] nuevo;
        int[,] viejo;

        public void comenzar(int[,] tabla)
        {
            
            nuevo = (int[,])tabla.Clone();

            
            int col = nuevo.GetLength(0);
            int row = nuevo.GetLength(1);

            
            for (int i = 0; i < col; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    
                    int cuenta = verificador(i, j);

                    // if vive
                    if (nuevo[i, j] == 1)
                    {
                        if (cuenta <= 1)
                        {
                            nuevo[i, j] = 0;
                        }
                        else if (cuenta == 2 || cuenta == 3)
                        {
                            nuevo[i, j] = 1;
                        }
                        else
                        {
                            nuevo[i, j] = 0;
                        }
                    }
                    // if muerte
                    else
                    {
                        if (cuenta == 3)
                        {
                            nuevo[i, j] = 1;
                        }
                        else
                        {
                            nuevo[i, j] = 0;
                        }
                    }
                }
            }
            
            viejo = (int[,])nuevo.Clone();
            imprimir(nuevo);
            Console.ReadKey();
            Console.Clear();
            comenzar(viejo);
        }


        public void imprimir(int[,] nuevo)
        {
            int col = nuevo.GetLength(0);
            int row = nuevo.GetLength(1);

            for (int i = 0; i < col; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    Console.Write("{0,2}", nuevo[i, j]);
                }
                Console.WriteLine();
            }
        }

        public int verificador(int x, int y)
        {            
            int vivo = 0;

            // checka +1 y +1
            if (x < 9 && y < 9)
            {
                if (nuevo[x + 1, y + 1] == 1)
                {
                    vivo++;
                }
            }
            // checka +1 y -1
            if (x < 9 && y > 0)
            {
                if (nuevo[x + 1, y - 1] == 1)
                {
                    vivo++;
                }
            }
            // checka +1 y 0
            if (x < 9)
            {
                if (nuevo[x + 1, y] == 1)
                {
                    vivo++;
                }
            }
            // checka 0 y +1
            if (y < 9)
            {
                if (nuevo[x, y + 1] == 1)
                {
                    vivo++;
                }

            }
            // checka 0 y -1
            if (y > 0)
            {
                if (nuevo[x, y - 1] == 1)
                {
                    vivo++;
                }
            }
            // checka -1 y -1
            if (x > 0 && y > 0)
            {
                if (nuevo[x - 1, y - 1] == 1)
                {
                    vivo++;
                }
            }
            // checka -1 y 0
            if (x > 0)
            {
                if (nuevo[x - 1, y] == 1)
                {
                    vivo++;
                }
            }
            // checka -1 y 1
            if (x > 0 && y < 9)
            {
                if (nuevo[x - 1, y + 1] == 1)
                {
                    vivo++;
                }
            }            
            return vivo;
        }
    }
}
