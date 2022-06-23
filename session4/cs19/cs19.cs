int numOne = 17;
int numTwo = 2;
while (numTwo <= numOne - 1)
{
    if (numOne % numTwo == 0)
    {
        Console.WriteLine("Not a Prime Number");
        break;
    }
    numTwo++;
}
if (numTwo == numOne)
{
    Console.WriteLine("Prime Number");
}