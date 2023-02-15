﻿﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//List
List<string> names = new List<string>();

names.Add("Mar'Kebta");
names.Add("Sierra");
names.Add("Adriana");

foreach (string name in names)
{
    Console.WriteLine($"The CSharp girls are " + name);
}
