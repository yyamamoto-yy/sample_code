using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int i = 0;
            for (; i < 5; i++)
            {
                Console.WriteLine(i);
                if(i == 3)
                {
                    break;
                }
            }
                       

            //C#ではbreakは必須
            string val = "A";
            switch (val)
            {
                case "A":
                    Console.WriteLine("switchA");
                    break;
                case "B":
                    Console.WriteLine("switchB");
                    break;
                default:
                    Console.WriteLine("switchDef");
                    break;
            }

            int[] numbers = new int[3] { 4, 5, 6 };
            //配列に要素を追加
            Array.Resize(ref numbers, numbers.Length + 1);
            numbers[numbers.Length - 1] = 7;

            for (int j = 0; j < numbers.Length; j++)
            {
                Console.WriteLine("{0}番目の要素の値は{1}です。", j + 1, numbers[j]);
            }

            //リスト
            List<string> list = new List<string>();
            list.Add("Anvil");
            list.Add("Yama");
            foreach (string str in list)
            {
                Console.WriteLine(str);
            }

            //２次元配列
            int[,] numberTable = new int[2, 3] {
                { 4, 5, 6 },
                { 7, 8, 9 },
            };

            for (int k = 0; k < numberTable.GetLength(0); k++)
            {
                for (int l = 0; l < numberTable.GetLength(1); l++)
                {
                    Console.WriteLine("[{0}, {1}]番目の要素の値は{2}です。", k + 1, l + 1, numberTable[k, l]);
                }
            }

            
        }
    }
}
