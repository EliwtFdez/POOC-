// See https://aka.ms/new-console-template for more information
using ApplicationForConceptsPoo;

Console.WriteLine("Hello, Mr Eliwt!");
Console.WriteLine("======================");

try
{
    Console.WriteLine(new Date(2002,3,22));
    Console.WriteLine(new Date(2032,11,30));
    Console.WriteLine(new Date(2022, 5, 45));
}
catch (Exception ERROR)
{

    Console.WriteLine(ERROR.Message);
}