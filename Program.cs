using System;
using System.Collections.Generic;

namespace puzzles
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomArray();
            CoinFlip();

            Console.WriteLine("Hello World!");
        }

        //Random Array
        public static void RandomArray()
        {
            Random randNum = new Random ();
            for (int val = 0; val < 10; val++)
            {
            Console.WriteLine(randNum.Next(5,25));
            }
        }
        public static void PrintMaxiumMinimum(int[] arr)
        {
            int min = arr[0];
            int max = arr[0];
            for(int i = 1; i< arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            {
            Console.WriteLine(min + max);
            }
        }
        public static void TotalSum(int[] arr)
        {
            int sum = 0;
            for(int i = 1; i< arr.Length; i++)
            {
                sum += arr[i];
            }
            {
            Console.WriteLine(sum);
            }
        }

        //Coin Flip
                public static string CoinFlip()
        {
                        List<int> randlist = new List<int>();

            Random rand = new Random();
            
            for(int x = 0; x < 100; x++){
                randlist.Add(rand.Next(5,1000));
            }
            int[] numArray = randlist.ToArray();
            int sum = numArray[0];
            
            for(int i = 0; i < numArray.Length; i++){
                sum += numArray[i];
            }

            int randcoin = sum*101;
            randcoin = randcoin/51;
            Console.WriteLine(randcoin);

            string coin;

            if(randcoin % 2 != 0){
                coin = "Heads";
            } else {
                coin = "Tails";
            }
            Console.WriteLine(coin);
            return coin;
        }
    }
    }
