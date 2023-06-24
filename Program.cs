//حل شده توسط استاد

using System;

namespace Project
{
    class test1
    {
        private int num;
        public int Num
        {
            get { return num; }
            set
            {
                if (value > 0)
                {
                    num = value;
                }
            }
        }

        public test1() { }
        public test1(int input)
        {
            Num = input;
        }
        public string Check_Perfect_Number()
        {
            int i, count = 0;
            string result = null;
            for (i = 1; i <= num - 1; i++)
            {
                if (num % i == 0)
                { count += i; }
            }
            if (count == num)
            {
                result = num + " is perfect";
            }
            else
            {
                result = num + " is not perfect";
            }
            return result;
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            int input = Convert.ToInt32(Console.ReadLine());
            test1 perfect = new test1(input);
            string result = perfect.Check_Perfect_Number();
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}