using System;
using System.Collections.Generic;
namespace b13
{
    public class Program
    {
        public static void SayHello()
        {
            Console.WriteLine("Hello how are you doing today?");
        }
        public static void basic1()
        {
            for (int i=1; i<=255; i++)
            {
                System.Console.WriteLine(i);
            }
        }
        public static void basic2()
        {
            for (int i=1; i<=255; i+=2)
            {
                System.Console.WriteLine(i);
            }
        }
        public static void basic3()
        {
            int sum = 0;
            for (int i=1; i<=255; i++)
            {
                sum+=i;
                System.Console.WriteLine("num: {0} - sum: {1}", i, sum);
            }
        }
        public static void basic4(int[] arr)
        {
            for (int i=0; i<arr.Length; i++)
            {
                System.Console.WriteLine(arr[i]);
            }
        }
        public static void basic5(int[] arr)
        {
            int max = arr[0];
            for (int i=1; i<arr.Length; i++)
            {
                if(arr[i]>max)
                {
                    max = arr[i];
                }
            }
            System.Console.WriteLine(max);
        }
        public static void basic6(double[] arr)
        {
            double avg = 0;
            for (int i=0; i<arr.Length; i++)
            {
                avg +=arr[i];
            }
            avg /= arr.Length;
            System.Console.WriteLine(avg);
        }
        public static void basic7()
        {
            List<int> toarr = new List<int>();
            for (int i=1; i<=255; i+=2)
            {
                toarr.Add(i);
            }   
            int[] y = toarr.ToArray();
            System.Console.WriteLine(y);
        }
        public static void basic8(double[] arr, int y)
        {
            int count = 0;
            for (int i=0; i<arr.Length; i++)
            {
                if(arr[i]>y)
                {
                    count++;
                }
            }
            System.Console.WriteLine(count);
        }
        public static void basic9(double[] arr)
        {
            for (int i=0; i<arr.Length; i++)
            {
                arr[i]*=arr[i];
            }
            for (int i=0; i<arr.Length; i++)
            {
                System.Console.WriteLine(arr[i]);
            }
        }
        public static void basic10(double[] arr)
        {
            for (int i=0; i<arr.Length; i++)
            {
                if (arr[i]<0)
                {
                    arr[i] = 0;
                }
            }
            for (int i=0; i<arr.Length; i++)
            {
                System.Console.WriteLine(arr[i]);
            }
        }
        public static void basic11(double[] arr)
        {
            double max = arr[0];
            double min = arr[0];
            double avg = arr[0];
            for (int i=1; i<arr.Length; i++)
            {
                avg += arr[i];
                if(arr[i]>max)
                {
                    max = arr[i];
                }
                else if(arr[i]<min)
                {
                    min = arr[i];
                }
            }
            System.Console.WriteLine("min: "+min);
            System.Console.WriteLine("max: "+max);
            avg/= arr.Length;
            System.Console.WriteLine("avg: "+avg);
        }
        public static void basic12(double[] arr)
        {
            for (int i=0; i<arr.Length-1; i++)          
            {
                arr[i] = arr[i+1];
            }
            arr[arr.Length-1] = 0;
            for (int i=0; i<arr.Length; i++)
            {
                System.Console.WriteLine(arr[i]);
            }
        }
        public static void basic13(object[] arr)
        {
            for (int i=0; i<arr.Length; i++)
            {
                int check = (int)arr[i];
                if (check<0)
                {
                    arr[i] = "dojo";
                }
            }
            for (int i=0; i<arr.Length; i++)
            {
                System.Console.WriteLine(arr[i]);
            }
        }
        static void Main(string[] args)
        {
            SayHello();
            basic1();  
            basic2();  
            basic3();  
            int[] arr1 = {1,3,5,7,9,13};
            basic4(arr1);
            int[] arr2 = {1,-3,5,-7,9,-13};
            basic5(arr2);
            double[] arr3 = {1,-3,5,-7,9,-13};
            basic6(arr3);
            basic7();
            basic8(arr3, 0);
            double[] arr4 = {1,5,10,-2};
            basic9(arr4);
            basic10(arr3);
            basic11(arr3);
            basic12(arr4);
            object[] arr5 = {1,-3,5,-7,9,-13};
            basic13(arr5);
        }
    }
}
