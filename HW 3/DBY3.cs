using System;
using System.IO;
using System.Text;                                                                              //Encoding을 위해 필요함.

namespace DBY3
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader gate = new StreamReader(@"C:\Users\Samsung\Desktop\NumberFile.csv");
            string data = gate.ReadToEnd();
            string[] arr1 = data.Split('\n');
            int[] Num = new int[200];
            bool End = false;
            int y;
            Random rand = new Random();
            Console.Write("광선을 (0,100)에서 쏴서 도착할 x값을 정하세요.");
            int inputx = int.Parse(Console.ReadLine());
            Console.Write("(y값은 50을 초과하지 않게 정해주세요.)\n광선을 (0,100)에서 쏴서 도착할 y값을 정하세요.");
            int inputy = int.Parse(Console.ReadLine()); ;
            float m = (inputy - 100) / inputx;
            for (int i = 0; i < arr1.Length; i++)
            {
                float x = i + 1;
                y = int.Parse(arr1[i]);
                {
                    if (y <= ((m * x) + 100))
                    {
                        Console.WriteLine("x: " + x + ", y : " + y);
                        if (inputx <= x)
                        {
                            End = true;
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("x: " + x + ", y : " + y);
                        if (inputx <= x)
                        {
                            Console.WriteLine("광선이 " + x + "번째에서 부딪혔습니다.");
                            break;
                        }
                    }
                }
            }
            if (End == true)
            {
                Console.WriteLine("광선이 어느 구간에도 닿지 않았습니다.");
            }
        }
    }
}
