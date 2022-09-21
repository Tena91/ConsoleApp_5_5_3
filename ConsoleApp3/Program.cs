using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Напишите что-то");

        var str = Console.ReadLine();

        Console.WriteLine("Укажите глубину эха");

        var deep = int.Parse(Console.ReadLine());
        Echo(str, deep);
        Console.ReadKey();
    }

    static void Echo(string saidword, int deep)
    {
        Console.WriteLine(saidword);
        if (deep > 1)
            Echo(saidword[2..], deep - 1);
    }
}