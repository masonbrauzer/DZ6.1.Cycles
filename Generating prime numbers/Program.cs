Console.Write("Input the number up to which you want to generate prime numbers: ");

int num = int.Parse(Console.ReadLine());

for (int i = 2; i <= num; i++)
{
    bool isPrime = true;

    for (int j = 2; j < i; j++)
    {
        if (i % j == 0)
        {
            isPrime = false;
            break;
        }
    }

    if (isPrime)
    {
        Console.Write(i + " ");
    }
}

Console.WriteLine($"Prime numbers from 1 to {num}:");
