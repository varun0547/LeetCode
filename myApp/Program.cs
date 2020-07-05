using System;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] inputArray={2,11,3,15,6,7};
            int target=17;

            TwoSum obj=new TwoSum();

            int[] result=obj.twoSum(inputArray,target);
        }

        
    }

}
