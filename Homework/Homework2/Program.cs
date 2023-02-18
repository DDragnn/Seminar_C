//                     Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
//                                 и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1






// int DeleteSotAndEd (int num)
// {
//     int sot = num / 100;
//     int ed = num % 10;
//     return (num-(sot * 100 + ed)) / 10;
// }



// Console.WriteLine("Input number");

// int number = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(DeleteSotAndEd(number));






                    // Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
                    //             или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6




// void ThirdNumber(int num)
// {
//     if(num < 100)
//     {
//         Console.WriteLine("третьей цифры нет");
//     }

//     else

//     {
//     while(num  > 999)
//         {
//             num /= 10;
//         }
//         Console.WriteLine(num % 10);
//     }
// }
// Console.WriteLine("Imput number");
// int number = Convert.ToInt32(Console.ReadLine());
// ThirdNumber (number);








// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет


// void MaxDecimal (int num)
// {
//     if (num > 0 && num <= 7)
//     {

//     if(num > 5)
//     {
//         Console.WriteLine("да");
//     }
//     else
//     {
//         Console.WriteLine("нет");
//    }
//     }
//     else
//     {
//          Console.WriteLine("нет такого дня недели");
//     }
// }
// Console.WriteLine("Введите день недели");
// int num = Convert.ToInt32(Console.ReadLine());
// MaxDecimal(num);
