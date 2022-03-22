
using ConceptsPOO;

Console.WriteLine("Conceptos POO");
Console.WriteLine("=============");

try
{
    Console.WriteLine(new Date(2022, 2, 28));
    Console.WriteLine(new Date(2021, 8, 6));
    Console.WriteLine(new Date(2020, 2, 29));
}
catch (Exception error)
{
    Console.WriteLine(error.Message);
}