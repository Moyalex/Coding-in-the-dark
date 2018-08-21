using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegodelaVida
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] tabla = new int[,]
        {
        { 1, 0, 1, 0, 0, 0, 0, 0, 1, 1,},
        { 0, 0, 1, 0, 0, 1, 0, 0, 0, 0,},
        { 0, 1, 1, 0, 1, 1, 1, 0, 0, 0,},
        { 0, 1, 0, 0, 1, 1, 0, 0, 0, 1,},
        { 0, 1, 0, 0, 0, 0, 0, 1, 0, 1,},
        { 0, 0, 0, 1, 1, 0, 1, 0, 1, 1,},
        { 0, 1, 0, 0, 1, 0, 0, 1, 0, 0,},
        { 1, 1, 0, 0, 0, 0, 1, 0, 0, 0,},
        { 1, 1, 0, 0, 1, 0, 0, 1, 0, 0,},
        { 0, 0, 0, 0, 0, 0, 0, 0, 0, 1,}
        };


            settabla gameoflife = new settabla();
            while (true)
            {
                gameoflife.imprimir(tabla);
                Console.ReadKey();
                Console.Clear();
                gameoflife.comenzar(tabla);
            }
        }
    }
}
