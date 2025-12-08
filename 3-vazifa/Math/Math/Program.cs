using System;

Console.WriteLine("Uchburchak yuzini va perimetrini hisoblash dasturi");

Console.Write("a tomonini kiriting: ");
double a = Convert.ToDouble(Console.ReadLine());

Console.Write("b tomonini kiriting: ");
double b = Convert.ToDouble(Console.ReadLine());

Console.Write("c tomonini kiriting: ");
double c = Convert.ToDouble(Console.ReadLine());

double perimetr = a + b + c;
Console.WriteLine($"Perimetr = {a} + {b} + {c} = {perimetr}");

double s = perimetr / 2;
double yuz = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
Console.WriteLine($"Yuz = √({s} * ({s}-{a}) * ({s}-{b}) * ({s}-{c})) = {yuz}");