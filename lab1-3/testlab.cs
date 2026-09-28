using System;
using System.Threading;

Console.WriteLine("Hello, Jerry");


// Задание 2

void PrintABC()
{
    Console.WriteLine("A");
    Console.WriteLine("B");
    Console.WriteLine("C");
}

PrintABC();
Thread.Sleep(500);

PrintABC();
Thread.Sleep(500);

PrintABC();


// Задание 3

void A()
{
    Console.WriteLine("A");

    B();
    C();
}

void B()
{
    Console.WriteLine("B");
}

void C()
{
    Console.WriteLine("C");
}

A();
A();
A();


// Задание 4

void Hello()
{
    Console.WriteLine("Hello");
}

// Если Hello() не написать,
// функция Hello не выполнится.


// Задание 5

void First()
{
    Console.WriteLine("First");
    Second();
}

void Second()
{
    Console.WriteLine("Second");
}

First();