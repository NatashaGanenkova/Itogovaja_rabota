﻿using System;
using System.Collections;
using static System.Console;

Clear();
Write("Введите значения через пробел: ");
string[] array = ReadLine().Split(" ");
int count = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        count++;
    }
}
ReadLine();



