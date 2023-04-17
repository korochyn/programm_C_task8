// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.Write("Ведите число: ");
int number_1 = int.Parse(Console.ReadLine()!);
int number_2 = number_1;
//Определение длины числа
int lenght = 0;
while (number_2 > 0) {number_2=number_2/10; lenght++;}
Console.WriteLine("Длина числа = " + lenght);
//Разборка числа по цифрам в массив
number_2 = number_1;
int[] nums1 = new int[lenght];
int del = 10;
int count = 0;
while (count < lenght)
     {
    nums1[count] = number_2 % del;
    // Console.Write(nums1[count]+" ");
    number_2 = number_2 /10;
    count++; 
    }
// Сборка "обратного" числа из цифр в массиве
del=1;
while (count > 0)
    { 
    number_2 = number_2 + nums1[count-1] * del;
    
    count = count - 1;
    del=del*10;

    }
    Console.WriteLine("Исходное число имеет вид    " + number_1);
    Console.WriteLine("Развернутое число имеет вид " + number_2);
    if (number_1 == number_2) {Console.WriteLine("ДА, введенное число является палиндромом");}
    else {Console.WriteLine("НЕТ, введенное число не является палиндромом");}
