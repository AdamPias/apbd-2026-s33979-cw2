// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World !!!!!!!");

int a = 5;

static double CalculateAvg67(int[] values)
{
    return values.Sum()/ values.Length;
}

int[] tab = new[] { a, 5, 5 };

Console.WriteLine(CalculateAvg67(tab));
Console.WriteLine("YOoooooo to jest main commit");



static double CalculateMax67(int[] values)
    {
    return values.Max();
    }

static double CalculateMin(int[] values)
{
    double min = values[0];
    for (int i = 0; i < values.Length; i++)
    {
        if (min > values[i])
        {
            min = values[i];
        }
    }

    return min;
}

Console.WriteLine("TO JEST COMMIT MAINA POTRZEBNY DO ZADANIA 6 Z REBASE");
