using System;
using static System.Console;
Clear();
WriteLine($"Введите что угодно:");
string[] input = ReadLine().Split();
string[] output = new string[input.Length];
int j = 0;
for (int i = 0; i < input.Length; i++){
    if(input[i].Length <= 3){
        output[j] = input[i];
        j++;
    }
}
WriteLine($"Результат:");
for (int k = 0; k < j; k++){
    Write($"{output[k]} ");
    }