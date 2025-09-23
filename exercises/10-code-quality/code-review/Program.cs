using System;
using System.Collections.Generic;
using System.IO;

namespace CodeReview
{
    class Program
    {
        static List<double> nums = new List<double>();
        static string fn = "";
        static int cnt = 0;
        static double s = 0;
        static double mx = 0;
        static double mn = 999999;

        static void Main(string[] args)
        {
            M1();
            M2();
            M3();
        }

        static void M1()
        {
            Console.Write("Enter filename: ");
            fn=Console.ReadLine();
            if(fn.Length<3||fn.Length>50){
                Console.WriteLine("Invalid filename");
                return;
            }
            Console.WriteLine("Enter numbers (-1 to stop):");
            while(true){
                double x=double.Parse(Console.ReadLine());
                if(x==-1)break;
                nums.Add(x);
            }
        }

        static void M2()
        {
            cnt=nums.Count;
            if(cnt>0){
                for(int i=0;i<cnt;i++){
                    s+=nums[i];
                    if(nums[i]>mx)mx=nums[i];
                    if(nums[i]<mn)mn=nums[i];
                }
                nums.Sort();
                Console.WriteLine("Count: "+cnt);
                Console.WriteLine("Sum: "+s);
                Console.WriteLine("Average: "+(s/cnt));
                Console.WriteLine("Min: "+mn);
                Console.WriteLine("Max: "+mx);
                Console.Write("Sorted: ");
                for(int i=0;i<cnt;i++){
                    Console.Write(nums[i]);
                    if(i<cnt-1)Console.Write(", ");
                }
                Console.WriteLine();
            }
        }

        static void M3()
        {
            StreamWriter w = new StreamWriter(fn);
            w.WriteLine("Statistics Report");
            w.WriteLine("Count: "+cnt);
            w.WriteLine("Sum: "+s);
            if(cnt>0)w.WriteLine("Average: "+(s/cnt));
            w.WriteLine("Min: "+mn);
            w.WriteLine("Max: "+mx);
            w.Write("Numbers: ");
            for(int i=0;i<cnt;i++){
                w.Write(nums[i]);
                if(i<cnt-1)w.Write(", ");
            }
            w.Close();
            Console.WriteLine("Results saved to "+fn);
        }
    }
}