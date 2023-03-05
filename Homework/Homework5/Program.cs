// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for(int i = 0;i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1); 
//     }
//     return array;
// }

// void ShowArray (int[] array)
// {
//     for(int i = 0;i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }
// void Chetnue (int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i]  % 2 == 0)
//         {
//             count++;
//         }
//     }
//     Console.WriteLine($"из {array.Length} чисел, {count} четных");
// }
// Console.WriteLine("Input array size");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of array element");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value of array element");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[] numbers = CreateRandomArray(size, minValue, maxValue);
// ShowArray(numbers);
// Chetnue(numbers);







                        // Задача 36: Задайте одномерный массив, заполненный случайными числами. 
                                        // Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for(int i = 0;i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1); 
//     }
//     return array;
// }

// void ShowArray (int[] array)
// {
//     for(int i = 0;i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// // // вариант 1

// // void Nums (int[] array)
// // {
// //     int count = 0;
// //     for (int i = 0; i < array.Length; i++)
// //     {
// //         if (i % 2 != 0)
// //         {
// //             count += array[i];
// //         }
// //     }
// //     Console.WriteLine($"Сумма элементов нечетных позиций = {count}");
// // }



// // // вариант 2


// void Nums (int[] array)
// {
//     int count = 0;
//     for (int i = 1; i < array.Length; i=i+2)
//     {       
//         count += array[i];
//     }
//     Console.WriteLine($"Сумма элементов нечетных позиций = {count}");
// }

// Console.WriteLine("Input array size");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of array element");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value of array element");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[] nums = CreateRandomArray(size, minValue, maxValue);
// ShowArray(nums);
// Nums(nums);

                        // Задача 38: Задайте массив вещественных чисел. 
                                    // Найдите разницу между максимальным и минимальным элементов массива.



// [3 7 22 2 78] -> 76 



// double[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     double[] array = new double[size];
//     for(int i = 0;i < size; i++)
//     {
//         array[i] = Convert.ToDouble (new Random().Next(minValue, maxValue + 1)) / 10; 
//     }
//     return array;
// }

// void ShowArray (double[] array)
// {
//     for(int i = 0;i < array.Length; i++)
//     {
//         Console.Write(array[i] + ";  ");
//     }
//     Console.WriteLine();
// }
// void Chetnue(double[] array)
// {
//     double min = Double.MaxValue;
//     double max = Double.MinValue;

//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > max)
//         {
//             max = array[i];
//         }
//         if (array[i] < min)
//         {
//             min = array[i];
//         }
//     }

//     Console.WriteLine($"{max} - {min} = {max - min, 2}");
// }
// Console.WriteLine("Input array size");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of array element");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value of array element");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// double[] numbers = CreateRandomArray(size, minValue, maxValue);
// ShowArray(numbers);
// Chetnue(numbers);





