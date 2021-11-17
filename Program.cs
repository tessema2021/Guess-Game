using System;




Console.WriteLine("guess the secret number");
//string guessNumber = Console.ReadLine();
//Console.WriteLine(guessNumber);
Random r = new Random();
int secretNumber = r.Next(1, 100);
int AllowChance = 4;
int numberOfChances = 0;
while (true)
{
    numberOfChances++;
    string guessNumber = Console.ReadLine();
    if (secretNumber == Int32.Parse(guessNumber))
    {
        Console.WriteLine("success ");
        break;
    }
    if (secretNumber < Int32.Parse(guessNumber))
    {
        Console.WriteLine($"Too high,try again,your guess {guessNumber} and you have {AllowChance - numberOfChances} tries left");
    }
    if (secretNumber > Int32.Parse(guessNumber))
    {
        Console.WriteLine($"Too low,try again,your guess {guessNumber} and you have {AllowChance - numberOfChances} tries left");
    }
    if (AllowChance == numberOfChances)
    {
        Console.WriteLine($"out of chance {secretNumber}");
        break;
    }
}