//                Задача 2:  Напишите программу, которая на вход принимает два числа и выдаёт, 
//                           какое число большее, а какое меньшее.


// Console.WriteLine("Input numbers");
// int num = Convert.ToInt32(Console.ReadLine());
// int num2 = Convert.ToInt32(Console.ReadLine());
// if(num == num2)
// {
//     Console.WriteLine($"{num} is Max and Min");
// }
// else
// {
//     if(num >= num2)
//     {
//         Console.WriteLine($"{num} is Max");
//         Console.WriteLine($"{num2} is Min");
//     }
//     else
//     {
//         Console.WriteLine($"{num2} is Max");
//         Console.WriteLine($"{num} is Min");    
//     }
// }





//                  Задача 4: Напишите программу, которая принимает на вход три числа
//                             и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


// Console.WriteLine("Imput 3 numbers");
// int num1 = Convert.ToInt32(Console.ReadLine());
// int num2 = Convert.ToInt32(Console.ReadLine());
// int num3 = Convert.ToInt32(Console.ReadLine());

// if (num1 > num2)
// {
//     if (num1 > num3)
//     {
//         Console.WriteLine("Максимальное число: " + num1);
//     }
//     else
//     {
//         Console.WriteLine("Максимальное число: " + num3);
//     }
// }

// else if (num2 > num3)
// {
//     Console.WriteLine("Максимальное число: " + num2);
// }
// else
// {
//     Console.WriteLine("Максимальное число: " + num3);
// }






// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет



// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num % 2 == 0)
// {
//     Console.WriteLine("четное");
// }
// else
// {
//     Console.WriteLine("нечетное");
// }






// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

// Console.WriteLine("Input number");
// int num = Convert.ToInt32(Console.ReadLine());

// int current = 2;

// while(current <= num)
// {
//     Console.Write(current + " ");
//     current = current + 2;
// }