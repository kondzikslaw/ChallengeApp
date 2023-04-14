int number = 3744;
string numberInString = number.ToString();
char[] numbers = numberInString.ToArray();

int[] counters = new int[10];

for (int i = 0; i < counters.Length; i++)
{
    counters[i] = 0;
}

foreach (char c in numbers)
{
    if (c == '0')
    {
        counters[0]++;
    }
    else if (c == '1')
    {
        counters[1]++;
    }
    else if (c == '2')
    {
        counters[2]++;
    }
    else if (c == '3')
    {
        counters[3]++;
    }
    else if (c == '4')
    {
        counters[4]++;
    }
    else if (c == '5')
    {
        counters[5]++;
    }
    else if (c == '6')
    {
        counters[6]++;
    }
    else if (c == '7')
    {
        counters[7]++;
    }
    else if (c == '8')
    {
        counters[8]++;
    }
    else if (c == '9')
    {
        counters[9]++;
    }
}

for (int i = 0; i < counters.Length; i++)
{
    Console.WriteLine(i + "=>" +counters[i]);
}
