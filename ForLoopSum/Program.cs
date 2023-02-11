for(int i = 0; i < 10; i++)
{
    Console.WriteLine($"i={i + 1}"); // muudab i väärtust ainult kuvamisel
}

Console.WriteLine("Teine for Loop");

for (int i = 10; i > 0; i--)
{
    Console.WriteLine($"i={i}");
}

int sum = 0;
for (int i = 1; i < 11; i++)
{
    Console.WriteLine($"i = {i}");
    Console.WriteLine($"Current total: {sum}");
    sum = sum + i;  // sum += i;
}

Console.WriteLine($"Final total: {sum}");