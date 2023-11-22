// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


var sum = (int a = 5, int b = 3) => a + b;

var result = sum(1, 2);

var resultForDefaultValues = sum();

