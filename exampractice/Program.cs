
Console.WriteLine("Hello, please enter a number from 0-9 as zero,one,two....");
string a1 = Console.ReadLine();

double num = 0;

if (a1 == "Zero")
{
    num = 0;
}
else if (a1 == "One") 
{ 
    num = 1; 
}
else if (a1 == "Two") 
{
    num = 2; 
}
else if (a1 == "Three")
{
    num = 3;
}
else if (a1 == "Four")
{
    num = 4;
}
else if (a1 == "Five")
{
    num = 5;
}
else if (a1 == "Six")
{
    num = 6;
}
else if (a1 == "Seven")
{
    num = 7;
}
else if (a1 == "Eight")
{
    num = 8;
}
else if (a1 == "Nine")
{
    num = 9;
}
else
{
    Console.WriteLine($"your input for {a1} is incorecct please try agian.");
    Environment.Exit(-1);
}


Console.WriteLine("Hello, please enter a number from 0-9 as zero,one,two....");
string a2 = Console.ReadLine();

double num2 = 0;

if (a2 == "Zero")
{
    num2 = 0;
}
else if (a2 == "One")
{
    num2 = 1;
}
else if (a2 == "Two")
{
    num2 = 2;
}
else if (a2 == "Three")
{
    num2 = 3;
}
else if (a2 == "Four")
{
    num2 = 4;
}
else if (a2 == "Five")
{
    num2 = 5;
}
else if (a2 == "Six")
{
    num2 = 6;
}
else if (a2 == "Seven")
{
    num2 = 7;
}
else if (a2 == "Eight")
{
    num2 = 8;
}
else if (a2 == "Nine")
{
    num2 = 9;
}
else
{
    Console.WriteLine($"your input for {a2} is incorecct please try agian.");
    Environment.Exit(-1);
}

double sum = num + num2;


Console.WriteLine($"your total is {sum.ToString("N1")}");