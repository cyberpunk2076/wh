using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*整数数据类型：
 * 1.sbyte：-128·127之间的整数
 * 2.byte：0·255之间的整数
 * 3.short：-32768·32767之间的整数
 * 4.ushort：0·65535之间的整数
 * 5.int：-2 147 483 648·2 147 483 647之间的整数
 * 6.uint：0·4 294 967 295之间的整数
 * 7.long：-9 223 372 036 854 775 808 ·9 223 372 036 854 775 8087之间的整数
 * 8.ulong：0·18 446 744 073 709 551 615之间的整数
 * 浮点型数据类型
 * 1.float
 * 2.double
 * 3.decimal
 * 简单类型
 * char：一个Unicode字符，存储0·65 535之间的整数
 * bool：布尔值：true后false
 * string：字符串
            */
namespace ConsoleApp1
{
    class Program
    {
        
        static void Main(string[] args)
        {

            int a = 3; int c = 5;
            int b = a-- * c;
            int d = a * c;
            // Console.WriteLine(d);
            // Console.WriteLine(a);
            // Console.WriteLine(b);
            // var    中文 = 123;
            //Console.WriteLine("请输入一个值:");


            int[] arr = new int[]{6,4,7,1,5,9,23,44};
            int n = arr.Length;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + ",");
            }
           Console.WriteLine(Environment.NewLine);
            bool swapped;
            for (int i = 0; i< n-1; i++){
                 
                for(int j = 0; j < n -1- i; j++)
                {
                    if(arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                     
                    }
                    
                }
               

            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(+arr[i] + ",");
            }
            Console.ReadKey();



            /* String str =  Console.ReadLine();//获取用户输入的代码
            if (str.Equals(a))
            {
                Console.WriteLine("大于3");
                Console.ReadLine();
            }
            else {
                Console.Write("小于3");
                Console.ReadKey();
            }*/
        }

    }
        class Rpg
    {
        #region
        #endregion
    }
}
