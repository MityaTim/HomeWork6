Main();
void Main()
{
    float b1 = ReadFloat(nameof(b1));
    float k1 = ReadFloat(nameof(k1));
    float b2 = ReadFloat(nameof(b2));
    float k2 = ReadFloat(nameof(k2));

    float x = (b2 - b1) / (k1 - k2);
    float y = LinearFunction(k1, b1, x);
    Console.WriteLine($"({x}; {y})");
}

float ReadFloat(string nameOfVariable)
{
    Console.Write($"{nameOfVariable} = ");
    return Convert.ToSingle(Console.ReadLine());
}

float LinearFunction(float k, float b, float xArg)
{
    return k * xArg + b;
}
