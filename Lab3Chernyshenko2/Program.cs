int m; 
Console.Write("Введите число m: ");
m = int.Parse(Console.ReadLine());
int number = 5;
int result = 0;
do
{
    int square = number * number;
    if (number % 100 == 0)
    {
        int divisionResult = square / m;
        Console.WriteLine($"({number}^2) / {m} = {divisionResult}");
    }

    number += 5;
} 
while (number <= 1000);