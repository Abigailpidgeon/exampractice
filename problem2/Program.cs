Console.WriteLine("Please Input your first number");
string answer = Console.ReadLine();
double loperand;
do
{
    double.TryParse(answer, out loperand);
    Console.WriteLine("Invalid input please try again.");
   
} while (false);

Console.WriteLine("Please Input your second number");
string answer2 = Console.ReadLine();
double roperand;
do
{
    double.TryParse(answer, out roperand);
    Console.WriteLine("Invalid input please try again.");

} while (false);

Console.WriteLine("what do you want to do with the numbers given?");
string operater = Console.ReadLine();

double total = 0;

if (operater == "*")
{
    total = loperand * roperand;
}
else if (operater == "/")
{
    total = loperand / roperand; 
}
else if (operater == "+")
{
    total = loperand + roperand;
}
else if (operater == "-")
{
    total = loperand - roperand;
}
else if (operater == "%")
{
    total = loperand % roperand;
}
else
{
    Console.WriteLine("Your input was invalid please try again");
}

