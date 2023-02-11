Random rnd = new Random();

int myRandomNum;

int randomSum = 0;

for(int i = 0; i < 3; i++)
{
    myRandomNum = rnd.Next(0, 11); // generee3rib numberid vahemikus 0-10 viimast antud juhu8l 11 ei genereerita mitte kunagi
    randomSum = randomSum + myRandomNum;
    Console.WriteLine($"Minu random number on: {myRandomNum}");
}

Console.WriteLine($"Minu random numberite summa on: {randomSum}");