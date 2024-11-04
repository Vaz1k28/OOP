using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;

public class a1
{
    public static void Main()
    {  //Завдання 1
        double a = Calculator(8, 9, "*");
        Console.WriteLine("Калькулятор: " + a);
        //Завдання 2
        bool isPrime = A2(17);
        Console.WriteLine("Is 51 prime? " + isPrime);
        //Завдання 3
        Console.WriteLine(A3(500, "EUR", "USD"));

        int[] myArray = { 3, 8, 2, 5, 1 };
        (int min, int max) result = MinMax(myArray);

        //Завдання 4
        Console.WriteLine($"Найменше число: {result.min}");
        Console.WriteLine($"Найбільше число: {result.max}");

        //Завдання 5
        string inputString = "Це приклад рядка для підрахунку літер.";
        (int vowels, int consonants) = A5(inputString);
        Console.WriteLine($"Голосних: {vowels}");
        Console.WriteLine($"Приголосних: {consonants}");
    }
    //Завдання 1:Калькулятор: Створіть функцію, яка приймає два операнди і операцію (додавання, віднімання, множення, ділення) в якості аргументів і повертає результат операції.
    public static double Calculator(double number1, double number2, string operation)
    {
        if (operation == "+") return number1 + number2;
        else if (operation == "-") return number1 - number2;
        else if (operation == "*") return number1 * number2;
        else if (operation == "/")
        {
            if (number2 == 0 || number1 == 0) return 0;
            else return number1 / number2;
        }
        else return 0;
    }
    //Завдання 2:Перевірка простого числа: Розробіть функцію, яка перевіряє, чи є задане число простим і повертає булеве значення.
    static bool A2(double number1)
    {
        if (number1 <= 1)
            return false;
        if (number1 <= 3)
            return true;
        for (int i = 2; i * i <= 5; i++)
        {
            if (number1 % i == 0)
                return false;
        }
        return true;
    }
    //Завдання 3:Конвертація валют: Створіть функцію, яка конвертує суму з однієї валюти до іншої, використовуючи поточний обмінний курс.
    public static double A3(double number1, string operation1, string operation2)
    {
        if (operation1 == "UAH")
        {
            if (operation2 == "UAH") return number1;
            else if (operation2 == "EUR") return number1 / 45.40;
            else if (operation2 == "USD") return number1 / 41.18;
            else return 0;
        }
        else if (operation1 == "USD")
        {
            if (operation2 == "USD") return number1;
            else if (operation2 == "EUR") return number1 * 0.91;
            else if (operation2 == "UAH") return number1 * 41.18;
            else return 0;
        }
        else if (operation1 == "EUR")
        {
            if (operation2 == "EUR") return number1;
            else if (operation2 == "USD") return number1 * 1.10;
            else if (operation2 == "UAH") return number1 * 45.40;
            else return 0;
        }
        else
        {
            return 0;
        }
    }
    //Завдання 4:Пошук найменшого і найбільшого елементів: Напишіть функцію, яка знаходить найменший і найбільший елементи в заданому масиві та повертає їх.
    public static (int min, int max) MinMax(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
        {
            return (0, 0);
        }

        int min = numbers[0];
        int max = numbers[0];

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] < min)
            {
                min = numbers[i];
            }
            else if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }

        return (min, max);

    }
    //Завдання 5:Робота з рядками: Створіть функцію, яка приймає рядок і підраховує кількість голосних та приголосних букв у ньому.
    static (int, int) A5(string text)
    {
        int vowels = 0, consonants = 0;
        var vowelsSet = new HashSet<char> { 'а', 'е', 'и', 'і', 'о', 'у', 'є', 'ю', 'я', 'ы' };

        foreach (char c in text.ToLower())
        {
            if (char.IsLetter(c))
            {
                if (vowelsSet.Contains(c))
                    vowels++;
                else
                    consonants++;
            }
        }

        return (vowels, consonants);
    }
    //Завдання 6:Геометричний калькулятор: Створіть програму, яка обчислює площу та об'єм геометричних фігур (наприклад, круга, прямокутника, куба) на основі введених параметрів.
    public static (double, double) A6(double a, double b, string operation)
    {
        double S;
        double P;

        if (operation == "cube")
        {
            S = 6 * a * a;
            P = a * a * a;
            return (S, P);
        }
        else if (operation == "cylinder")
        {
            S = 2 * Math.PI * a * b;
            P = Math.PI * a * a * b;
            return (S, P);
        }
        else if (operation == "ball")
        {
            S = 4 * Math.PI * a * a;
            P = 4 / 3 * Math.PI * a * a * a;
            return (S, P);
        }
        else return (0, 0);
    }
}