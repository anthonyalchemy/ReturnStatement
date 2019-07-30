using System;

namespace ReturnStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            //int cubedNumber = cube(5); this is another way of returning from the one below
            //Console.WriteLine(cubedNumber);


            Console.WriteLine(cube(5));


            Console.ReadLine();
        }


        static int cube(int num)//num will be number user passes in 
        {
            int result = num * num * num;
            return result;//returns result to caller

        }
    }
}
