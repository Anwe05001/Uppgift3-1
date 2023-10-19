using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hur gammal är du?");
        string ålder = Console.ReadLine();
        int age = int.Parse(ålder);
        

        if (age > 19)
        {
            Console.WriteLine("Du är tyvärr för gammal");
        }

        if (age < 16)
        {
            Console.WriteLine("Du är tyvärr för ung");
        }

        else if (age !< 16 && age !> 19)
        {
            Console.WriteLine("Du får delta");
        } 

        Console.ReadKey();
    }
}