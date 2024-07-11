using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpiralAlgoth
{
    public class Matrix
    {
        private int[,] dizi;
        private int satir;
        private int sutun;
        private bool[,] visited;
        private int elemanSay;
        private int count;

        public Matrix(int[,] dizi)
        {
            this.dizi = dizi;
            satir = dizi.GetLength(0);
            sutun = dizi.GetLength(1);
            visited = new bool[satir, sutun];
            elemanSay = satir * sutun;
            count = 0;
        }
        public void SpiralPrint()
        {
            int sat_sayisi = 0, sut_sayisi = 0;

            while (count < elemanSay)
            {
                while (sut_sayisi < sutun && !visited[sat_sayisi, sut_sayisi])
                {
                    Console.Write(dizi[sat_sayisi, sut_sayisi] + " ");
                    visited[sat_sayisi, sut_sayisi] = true;
                    count++;
                    sut_sayisi++;
                }
                sut_sayisi--; sat_sayisi++;

                while (sat_sayisi < satir && !visited[sat_sayisi, sut_sayisi])
                {
                    Console.Write(dizi[sat_sayisi, sut_sayisi] + " ");
                    visited[sat_sayisi, sut_sayisi] = true;
                    count++;
                    sat_sayisi++;
                }
                sat_sayisi--; sut_sayisi--;

                while (sut_sayisi >= 0 && !visited[sat_sayisi, sut_sayisi])
                {
                    Console.Write(dizi[sat_sayisi, sut_sayisi] + " ");
                    visited[sat_sayisi, sut_sayisi] = true;
                    count++;
                    sut_sayisi--;
                }
                sut_sayisi++; sat_sayisi--;

                while (sat_sayisi >= 0 && !visited[sat_sayisi, sut_sayisi])
                {
                    Console.Write(dizi[sat_sayisi, sut_sayisi] + " ");
                    visited[sat_sayisi, sut_sayisi] = true;
                    count++;
                    sat_sayisi--;
                }
                sat_sayisi++; sut_sayisi++;
            }
        }



    }

}