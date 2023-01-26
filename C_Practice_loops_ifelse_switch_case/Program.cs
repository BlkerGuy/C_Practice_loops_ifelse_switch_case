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



        }
    }
}
