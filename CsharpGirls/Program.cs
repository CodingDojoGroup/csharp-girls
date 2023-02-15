﻿﻿﻿// See https://aka.ms/new-console-template for more information
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
string[] names1 = {"Sierra", "Adriana", "Mar'Kebta"};

for(int i = 0; i < names1.Length; i++){
    Console.WriteLine(names1[i]);
}
