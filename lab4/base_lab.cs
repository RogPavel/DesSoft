using System;

class Base
{
    static void Main()
    {
        // ЗАДАНИЕ 1
        // Присваивание одной переменной к другой

        Console.WriteLine("ЗАДАНИЕ 1");

        int a1 = 5;
        int b1 = 6;

        a1 = b1;
        b1 = 7;

        Console.WriteLine("a = " + a1);
        Console.WriteLine("b = " + b1);

        Console.WriteLine();

      
        // ЗАДАНИЕ 2
        // Присваивание выражения с переменной
       

        Console.WriteLine("ЗАДАНИЕ 2");

        int a2 = 5;
        int b2 = a2 + 6;

        a2 = 7;

        Console.WriteLine("a = " + a2);
        Console.WriteLine("b = " + b2);

        Console.WriteLine();
        
     
        // ЗАДАНИЕ 3
        // Присваивание ссылочной переменной
        

        Console.WriteLine("ЗАДАНИЕ 3");

        string a3 = "1";
        string b3 = a3;

        a3 = "2";

        Console.WriteLine("a = " + a3);
        Console.WriteLine("b = " + b3);

        Console.WriteLine();
        
        
        // ЗАДАНИЕ 4
        // Присваивание int к string
     

        Console.WriteLine("ЗАДАНИЕ 4");

        // Так писать нельзя:
        // string a4 = 5;

        // Правильный вариант:
        int number = 5;
        string a4 = number.ToString();

        Console.WriteLine("a = " + a4);

        Console.WriteLine();
        
        
        // ЗАДАНИЕ 5
        // Создание переменной с тем же именем
        

        Console.WriteLine("ЗАДАНИЕ 5");

        int a5 = 5;

        // Так писать нельзя:
        // int a5 = 6;

        // Чтобы изменить значение существующей переменной:
        a5 = 6;

        Console.WriteLine("a = " + a5);
    }
}