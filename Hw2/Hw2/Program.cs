
Console.Write("Enter the celcius value to convert it : ");

double cel = double.Parse(Console.ReadLine());
double fah = (cel * 1.8) + 32;
double kel = cel + 273.15;

Console.WriteLine($"\n{cel} Celcius = {fah} Fahrenheit");
Console.WriteLine($"{cel} Celcius = {kel} Kelvin");








Console.Write("Enter the 1st grade : ");
int first = int.Parse(Console.ReadLine());

Console.Write("\nEnter the 2nd grade : ");
int second = int.Parse(Console.ReadLine());

Console.Write("\nEnter the 3rd grade : ");
int third = int.Parse(Console.ReadLine());

int avg = (first  + second + third)/3;

if (avg >= 60)
{
    Console.WriteLine($"Average is {avg} and passed");
}

else
{
    Console.WriteLine($"Average is {avg} and fail");
}








Console.Write("Enter a 3-digit number : ");
int num = int.Parse(Console.ReadLine());

int hundred = num / 100;
int ten = (num % 100) / 10;
int one = (num % 100) % 10;

Console.WriteLine($"\nNumber is {num}\n");
Console.WriteLine($"Hunreds is {hundred}, tens is {ten}, ones is {one}.");