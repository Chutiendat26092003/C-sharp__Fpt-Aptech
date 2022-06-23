Console.WriteLine("Even numbers in the range of 1 - 10");
for (int i = 1; i <= 10; i++)
{
    if (i % 2 != 0)
    {
        continue;
    }
    Console.Write(i + " ");
}
