
Console.WriteLine("Oddiy calculator");
Console.WriteLine("Kiritish mumkin bo'lgan amallar: + - * / %");
Console.WriteLine("----------------------------------");
Console.Write("1-sonni kiriting: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Amal: ");
string action = Console.ReadLine();
Console.Write("2-sonni kiriting: ");
int b = int.Parse(Console.ReadLine());
bool exit = false;
int result = 0;
if (action == "+")
{
    result = a + b;
} else if (action == "-")
{
    result = a - b;
} else if (action == "*")
{
    result = a * b;
} else if (action == "/")
{
    result = a / b;
} else if (action == "%")
{
    result = a % b;
} else
{
    Console.WriteLine("Noto'g'ri amal kiritdingiz!");
    exit =  true;
}

if (!exit)
{
    Console.WriteLine($"Natija: {a} {action} {b} = {result}");
}