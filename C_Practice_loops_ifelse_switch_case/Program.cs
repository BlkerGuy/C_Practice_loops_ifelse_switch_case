using System;
using System.Globalization;
using System.Linq;
using System.Threading;

namespace C_Practice_loops_ifelse_switch_case
{
     class Program
    {
        static void Main(string[] args)
        {

            #region Task 1

            ///Verilmiş 3 ədədən ən böyüyünü tapan proqram:

            //Console.WriteLine("1-ci ededi daxil edin (muqayise ucun A):");
            //int a = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("2-ci ededi daxil edin (muqayise ucun B):");
            //int b = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("3-ci ededi daxil edin (muqayise ucun C):");
            //int c = Convert.ToInt32(Console.ReadLine());

            /////int a = 20;
            /////int b = 12;   // veya spesifik reqemlere gore:
            /////int c = 8;

            //if (a > b && a > c)
            //{
            //    Console.WriteLine("A boyukdur:" + a);
            //}
            //else if (b > a && b>c)
            //{
            //    Console.WriteLine("B boyukdur:" + b);
            //}
            //else if (c > a && c>b)
            //{
            //    Console.WriteLine("C boyukdur:" + c);
            //}

            #endregion

            #region Task 2

            ////  Verilmiş ədədlər siyahısındaki ən böyük ədədi tapan proqram/////////////

            //int[] nums = new int[] { 500,10,15};

            //int bigNum = nums[0];

            //for (int i = 1; i < nums.Length; i++)
            //{
            //    if (nums[i] > bigNum)
            //    {
            //        bigNum = nums[i];
            //    }
            //}
            //Console.WriteLine(bigNum);



            ///  2ci yol daxil edilen ededlere gore ədədlər siyahısındaki ən böyük ədədi tapan proqram

            //int[] nums = new int[] { };
            //Console.WriteLine("Zehmet olmasa ededlerin uzunluqunu daxil edin:");
            //int numsLength = Convert.ToInt32(Console.ReadLine());
            //int input = 0;

            //for (int i = 1; i <= numsLength; i++)
            //{
            //    Console.WriteLine($"Zehmet olmasa {i}ci ededi daxil edin");
            //    numbs = Convert.ToInt32(Console.ReadLine());
            //    nums = nums.Concat(new int[] { input }).ToArray();
            //}
            //int bignum = nums[0];

            //for (int i = 1; i < nums.Length; i++)
            //{
            //    if (nums[i] > bignum)
            //    {
            //        bignum = nums[i];
            //    }
            //}
            //Console.WriteLine("\nEn boyuk eded:"+bignum);



            #endregion

            #region Task 3 


            ////   Verilmiş ədələr siyahısında mənfi ədəd olub olmadığını tapan proqram


            //int[] nums = new int[] {20,30,40 };
            //bool numsArrMinus = false;

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (nums[i]>0)
            //    {
            //        numsArrMinus = false;
            //    }
            //    else
            //    {
            //        numsArrMinus = true;
            //        break;
            //    }
            //}

            //if (numsArrMinus==false)
            //{
            //    Console.WriteLine("\n\nEdedler siyahisinda menfi eded yoxdur.\n");
            //}
            //else
            //{
            //    Console.WriteLine("\n\nEdedler siyahisinda menfi eded var.\n");
            //}

            #endregion


            ///    Həftəsonu tapşırıqları:


            #region Task 1

            //   Verilmiş ədədin rəqəmləri cəmini tapan proqram:

            //int num = Convert.ToInt32(Console.ReadLine());
            //int singleDigit = 0;

            //while (num!=0)
            //{
            //    singleDigit += num % 10;
            //    num /= 10;
            //}
            //Console.WriteLine(singleDigit);

            #endregion


            #region Task 2

            /// - Verilmiş qiymət dəyəri 64-dən böyük olarasa console-da "məzun oldunuz", əks halda "məzun olmadınız" yazdırsan proqram.
            /// Qiymət dəyərini console-dan qəbul edin (Readline ilə).Qiymət dəyəri 0-100 aralığında olmalıdır,
            /// 0-dan kiçin və ya 100-dən böyük dəyər daxil edələrsə yenidən daxil edilməsi istənilsin proqram tərəfindən
            /// 

            //Console.WriteLine("Zehmet olmasa deyer girin:");
            //int num = Convert.ToInt32(Console.ReadLine());

            //while (num > 100)
            //{
            //    Console.Clear();
            //    Console.WriteLine("Zehmet olmasa duzgun deyer girin!!");
            //    num = Convert.ToInt32(Console.ReadLine());

            //};

            //while (num < 0)
            //{
            //    Console.Clear();
            //    Console.WriteLine("Zehmet olmasa duzgun deyer girin!!");
            //    num = Convert.ToInt32(Console.ReadLine());
            //}

            //if (num > 64)
            //{
            //    Console.WriteLine("Tebrikler mezun oldunuz!");
            //}
            //else
            //{
            //    Console.WriteLine("Teessuf edirik, mezun olmadiniz!");
            //}

            #endregion


            #region Task 3

            //    Verilmiş ədədlər siyahısındaki 21 - ə bölenən ədədlərin ədədi ortasını tapan proqram

            int[] nums = new int[] { 5,11,63,24,21,42 };
            byte count = 0;
            int sum = 0;

            for (int i = 0; i < nums.Length; i++)
            {

                if (nums[i] % 21 == 0)
                {
                    sum += nums[i];
                    count++;
                }
            }
            if (count>0)
            {
                Console.WriteLine(sum / count);
            }
            else
            {
                Console.WriteLine("Tapilmadi!");
            }













            #endregion

        }
    }
}
