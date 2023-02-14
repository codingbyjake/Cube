namespace Cube
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num = 1;
            double cube = 0;
            while(num <= 25)
            {
                if (num % 2 != 0)
                {
                    cube = Math.Pow(num, 3);
                    //cube = num*num*num;
                    Console.WriteLine($"The number {num} cubed is {cube}");
                }
                num++;
            }
        }
    }
}