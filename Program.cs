namespace CoreFunda
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a, b;

            string inputA = string.Empty;
            string inputB = string.Empty;

            Console.WriteLine("Please enter a value for A");
            inputA = Console.ReadLine();

            Console.WriteLine("Please enter a value for B");
            inputB = Console.ReadLine();

            a = int.Parse(inputA);
            b= int.Parse(inputB);
            

            int ans = a+ b;
            Console.WriteLine("Answer = " + ans);
            Console.ReadLine();
        }
    }
}
