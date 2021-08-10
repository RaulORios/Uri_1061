﻿using System;

namespace Uri_1061
{
    class Program
    {
        static void Main(string[] args)
        {
            int w1, x1, y1, z1, w2, x2, y2, z2, w, x, y, z, inicio, fim, duracao, resto;

            string[] valores = Console.ReadLine().Split(' ');
            w1 = int.Parse(valores[1]);

            valores = Console.ReadLine().Split(' ');
            x1 = int.Parse(valores[0]);
            y1 = int.Parse(valores[2]);
            z1 = int.Parse(valores[4]);

            valores = Console.ReadLine().Split(' ');
            w2 = int.Parse(valores[1]);

            valores = Console.ReadLine().Split(' ');
            x2 = int.Parse(valores[0]);
            y2 = int.Parse(valores[2]);
            z2 = int.Parse(valores[4]);

            inicio = (w1 - 1) * 24 * 60 * 60 + x1 * 60 * 60 + y1 * 60 + z1;
            fim = (w2 - 1) * 24 * 60 * 60 + x2 * 60 * 60 + y2 * 60 + z2;

            duracao = fim - inicio;

            w = duracao / (24 * 60 * 60);
            resto = duracao % (24 * 60 * 60);            
            x = resto / (60 * 60);
            resto = resto % (60 * 60);
            y = resto / 60;
            z = resto % 60;

            Console.WriteLine($"{w} dia(s)");
            Console.WriteLine($"{x} hora(s)");
            Console.WriteLine($"{y} minuto(s)");
            Console.WriteLine($"{z} segundo(s)");
            
        }
    }
}
