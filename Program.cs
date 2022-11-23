internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        
        
        Console.Write("Введите первое число ");
        string firstValue = Console.ReadLine();
        int first = Convert.ToInt32(firstValue);

        Console.Write("Введите второе число ");
        string secondValue = Console.ReadLine();
        int second = Convert.ToInt32(secondValue);


        if (first>second)
        {
            Console.WriteLine ("Наибольшее число " + firstValue);
        } else
        {
            Console.WriteLine("Наибольшее число "+secondValue);
        }
       
       
    }
}