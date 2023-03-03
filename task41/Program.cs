Console.WriteLine(ReadArrayOfInts().Count(x => x > 0));
int[] ReadArrayOfInts()
{
    return Console.ReadLine()?
        .Split(",")
        .Select(x => Convert.ToInt32(x))
        .ToArray() ?? Array.Empty<int>();
}