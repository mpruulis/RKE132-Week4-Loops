Random rnd = new Random();
int pcRandom;

bool loopactive = true; //bool + true/false

while (loopactive)
{
    pcRandom = rnd.Next(1,5);
    Console.WriteLine($"Arva number. Sisesta number vahmikus 1-4");

    int userNumber = Int32.Parse(Console.ReadLine() );

    if (userNumber == pcRandom)
    {
        Console.WriteLine("Õnnitlen sa võitsid!");
        //loopActive = false;
        break;                          // "break" teeb sama mis antud juhul "loopActive = false"
    }
    else
    {
        Console.WriteLine("Vale! Proovi uuesti");
    }
}

Console.WriteLine("Mäng läbi, mine koju!");