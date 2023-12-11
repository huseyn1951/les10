using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
           /* int[] arr1 = { 1, 2, 3, 4, 5 };
            WorkWithArr(arr1);
            int[] arr2 = { 6, 7, 8, 9, 10 };
            WorkWithArr(arr2);*/
            #endregion
            #region
           /* int[] arr3 = { 11, 15, 14, 19, 20 };
            int cutEdedlerCemi = SumOfEven(arr3);
            Console.WriteLine($"cut ededlerin cemi: {cutEdedlerCemi}");*/
            #endregion
            #region
            /*int[] arr4 = { 3, 5, 10, 15, 2 };
            int ortaArifmetik = HesablaOrtaArifmetik(arr4);
            Console.WriteLine(ortaArifmetik);*/
            #endregion
            #region
           /* int[] arr5 = { 11, 15, 14, 19, 20 };
            int[] arr6 = { 3, 5, 10, 15, 2 };

            MaxValueHesabla(arr5, arr6);*/
            #endregion
            #region
            /*CutReqemKvadratHesabla(1, 10);*/
            #endregion
            #region
           /* QuizAppB("azerbaycanin paytaxti haradir?", "a)Shusha", "b)Baki", "c)Mingecevir" );
            QuizAppA("Azerbaycanin prezidenti kimdir?","a)ILHAM ELIYEV","b)ferhad","c)tural");
            QuizAppC("GOAT kimdir?","a)messi","b)ronaldo","c)QURBAN QURBANOV");*/
            #endregion



        }
        public static void WorkWithArr(int[] numbers)
        {
            foreach (var number in numbers)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine(number * 3);
                }
            }
        }
        public static int SumOfEven(int[] numbers)
        {
            int sum = 0;

            foreach (var number in numbers)
            {
                if (number % 2 == 0)
                {
                    sum += number;

                }

            }
            return sum;

        }


        public static int HesablaOrtaArifmetik(int[] numbers)
        {
            int sum = 0;

            foreach (var number in numbers)
            {
                sum += number;

            }
            Console.WriteLine((sum) / (numbers.Length));

            return 0;
        }


        public static int MaxValueHesabla(int[] numbers1, int[] numbers2)
        {
            int max1 = 0;
            int max2 = 0;



            foreach (var number1 in numbers1)
            {
                if (number1 > max1)
                {
                    max1 = number1;
                }
            }


            foreach (var number2 in numbers2)
            {
                if (number2 > max2)
                {
                    max2 = number2;
                }
            }
            int sum = max1 + max2;

            Console.WriteLine($"en boyuk ededlerin cemi:  {sum}");



            return 0;

        }

        public static void CutReqemKvadratHesabla(int num1, int num2)
        {
            int sum = 0;

            for (int i = num1; i < num2; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i * i;
                }
            }
            Console.WriteLine($"kvadratlarin cemi:  {sum}");

        }
        public static void QuizAppA(string sual, string cavabA, string cavabB, string cavabC)
        {
            Console.WriteLine(sual);
            Console.WriteLine(cavabA);
            Console.WriteLine(cavabB);
            Console.WriteLine(cavabC);
            cavabA = "a";
            cavabB = "b";
            cavabC = "c";

            string correctAnswer = cavabA;



            string userAnswer = Console.ReadLine();

            if (userAnswer == correctAnswer)
            {
                Console.WriteLine("duzdu!!!!");
            }

            else
            {
                Console.WriteLine("sehvdir");
            }


        }







        public static void QuizAppB(string sual,string cavabA,string cavabB,string cavabC)
        {
            Console.WriteLine(sual);
            Console.WriteLine(cavabA);
            Console.WriteLine(cavabB);
            Console.WriteLine(cavabC);
            cavabA = "a";
            cavabB = "b";
            cavabC = "c";
            
            string correctAnswer = cavabB;
            
            

            string userAnswer = Console.ReadLine();

            if (userAnswer==correctAnswer)
            {
                Console.WriteLine("duzdu!!!!");
            }

            else
            {
                Console.WriteLine("sehvdir");
            }


        }

        public static void QuizAppC(string sual, string cavabA, string cavabB, string cavabC)
        {
            Console.WriteLine(sual);
            Console.WriteLine(cavabA);
            Console.WriteLine(cavabB);
            Console.WriteLine(cavabC);
            cavabA = "a";
            cavabB = "b";
            cavabC = "c";

            string correctAnswer = cavabC;



            string userAnswer = Console.ReadLine();

            if (userAnswer == correctAnswer)
            {
                Console.WriteLine("duzdu!!!!");
            }

            else
            {
                Console.WriteLine("sehvdir");
            }


        }







    }
}
