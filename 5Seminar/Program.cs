
// ________________________________Домашнее задание______________________________________________
// _____________________________________Задание 1___________________________________________________________

//  Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int [] array = new int [4];
//  int result = 0;
// for(int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(100, 1000);
//     Console.Write(array[i] + " ");
    
    
//         if (0 == array[i] % 2)
//         {
//             result = result + 1;
//         }
     
   

// }
// Console.WriteLine(result);


// ________________________________________Задание 2___________________________________________________________________
//  Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// void fillArray(int[] collection)
// {
//     int length = collection.Length;
//     int index = 0;
//     while (index < length)
//     {
//         collection[index] = new Random().Next(1, 100);
//         index++;
//     }
// }
// void printArray(int[] col)
// {
//     int count = col.Length;
//     int position = 0;
//     while (position < count)
//     {
//         Console.WriteLine(col[position]);
//         position++;
//     }
// }

// void suM(int[]collection)
// {
//      int index = 0;
//      int result = 0;
//      while (index < collection.Length)
//      {
//         result = collection[index] + result;
//         index = index + 2;
//      }
// Console.WriteLine(result);
// }
// int[] array = new int[8];
// fillArray(array);

// printArray(array);
// Console.WriteLine();

// suM(array);


// Задайте массив вещественных(натуральных) чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


// void fillArray(int[] collection)
// {
//     int length = collection.Length;
//     int index = 0;
//     while (index < length)
//     {
//         collection[index] = new Random().Next(1, 100);
//         index++;
//     }
// }
// void printArray(int[] col)
// {
//     int count = col.Length;
//     int position = 0;
//     while (position < count)
//     {
//         Console.WriteLine(col[position]);
//         position++;
//     }
// }
// void Res(int[]collection)
// {
//     int index = 0;
//     int max = collection[index];
//     int min  = collection[index];
//     int result = 0;
//     while (index < collection.Length)
//     {
//         if (collection[index] > max)
//         {
//             max = collection[index];
//         }
//         else if (collection[index] < min)
//         {
//             min = collection[index];
//         }
//     index++;
//     result = max - min;

//     }

// Console.WriteLine(result);
// }
// int [] array = new int [5];
// fillArray(array);

// printArray(array);
// Console.WriteLine();

// Res(array);
