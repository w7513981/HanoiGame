using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerofHanoiGame
{
    public class HanoiGame
    {
        int Disk, from, to, Aux, Dest, Src;
        public void Setup()
        {
            Console.WriteLine("請輸入河內塔的高度：");
            string input = Console.ReadLine();
            Disk = int.Parse(input);

            Console.WriteLine("起始地的柱子:(1,2,3)");
            input = Console.ReadLine();
            from = int.Parse(input);

            Console.WriteLine("目的地的柱子：(1,2,3)");
            input = Console.ReadLine();
            to = int.Parse(input);
        }
        public void Play()
        {
            #region // 取得 第三柱子
            /* 例如 輸入 1 3  得到  2
             *      輸入 1 2  得到  3
             *      輸入 2 3  得到  1
             */
            int[] temp = { 1, 2, 3 };
            foreach (int item in temp)
            {
                if (item != from && item != to)
                {
                    Aux = item;
                    break;
                }
            }
            #endregion

            Hanoi(Disk, from, to, Aux);
            Console.WriteLine(" ");
            Console.WriteLine("都移完了!");
            Console.WriteLine("按任意鍵離開");
        }

        public void Hanoi(int Disk, int Src, int Dest, int Aux)
            {
                if (Disk == 1)
                {
                    Console.WriteLine($"將第{Disk}個圓盤由{Src}移到{Dest} ");
                }
                else
                {
                    Hanoi(Disk - 1, Src, Aux, Dest);
                    Console.WriteLine($"將第{Disk}個圓盤由{Src}移到{Dest} ");
                    Hanoi(Disk - 1, Aux, Dest, Src);
                }
            }
        }
}
