﻿// Задача 19. Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да






// Вариант 2



// void Polindrom (int Num)
// {
//     int a = Num / 10000;
//     int b = Num % 10;
//     int c = Num / 1000 % 10;
//     int d = (Num % 100) - (Num % 100-(Num % 100 / 10));

//     if(a == b && c == d)
//     {
//         Console.WriteLine("Полиндром");
//     }
//     else
//     {
//        Console.WriteLine("Неполиндром");
//     }
// }
// Console.WriteLine("input number");
// int number = Convert.ToInt32(Console.ReadLine());
// Polindrom (number);



//              Задача 21 Напишите программу, которая принимает на вход координаты двух точек 
//                          и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


// double FindDistance(double xa, double ya, double ca, double xb, double yb, double cb)
// {
//     return Math.Round(Math.Sqrt(Math.Pow(xb-xa, 2) + Math.Pow(yb-ya, 2) + Math.Pow(cb-ca, 2) ), 2);
// }

// Console.WriteLine("Input cordinate X for first point: ");
// double xb = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input cordinate Y for first point: ");
// double yb = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input cordinate X for first point: ");
// double cb = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input cordinate Y for first point: ");
// double xa = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input cordinate X for first point: ");
// double ya = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input cordinate Y for first point: ");
// double ca = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine($"Distance between our point --> {FindDistance(xa, ya, ca, xb, yb, cb)}");






// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// void Quard (int N)
// {
//     int y = 1;
//     while (y <= N)
//         {
//             Console.WriteLine(Math.Pow(y, 3));
//             y++;
//         }
// }

// Console.WriteLine("Число");
// int N = Convert.ToInt32(Console.ReadLine());
// Quard(N);