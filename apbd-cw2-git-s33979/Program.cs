// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World !!!!!!!");

int a = 5;

static double CalculateAvgFeature(int[] values)
{
    return values.Sum()/ values.Length;
}

int[] tabFeature = new[] { a, 5, 5 };

Console.WriteLine(CalculateAvgFeature(tabFeature));

