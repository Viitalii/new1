﻿int Number1 = new Random().Next(1, 11); // 1 2 3 4 5 ... 11
Console.WriteLine(Number1);
int Number2 = new Random().Next(1, 11);
Console.WriteLine(Number2);
int Number3 = new Random().Next(1, 11);
Console.WriteLine(Number3);
int max = Number1;
if (Number1 > max) max = Number1;
if (Number2 > max) max = Number2;
if (Number3 > max) max = Number3;
Console.WriteLine("max number is -{0}", max);