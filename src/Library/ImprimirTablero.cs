using System;
using System.Threading;

namespace PII_Game_Of_Life
{
    public class ImprimirTablero
    {
        bool[,] b //variable que representa el tablero
        int width = 4;//variabe que representa el ancho del tablero
        int height = 4;  //variabe que representa altura del tablero
        While (true)
        {
            Console.Clear();
            StringBuilder s = new StringBuilder();
            for (int y = 0; y<height;y++)
            {
                for (int x = 0; x<width; x++)
                {
                    if(b[x,y])
                    {
                        s.Append("|X|");
                    }
                    else
                    {
                        s.Append("___");
                    }
                }
                s.Append("\n");
            }
            Console.WriteLine(s.ToString());
            //=================================================
            //Invocar método para calcular siguiente generación
            //=================================================
            Thread.Sleep(300);
        }
    }
}
