// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//Console.WriteLine("stay hungey for ur study");
using ConsoleApp1;

Console.WriteLine("Hello Calculator");
Console.WriteLine("please enter first number");
int n1=int.Parse(Console.ReadLine());
Console.WriteLine("please enter seconde number");
int n2=int .Parse(Console.ReadLine());  
Calculator c1=new Calculator();
c1.Add(n1, n2);

Console.ReadLine();