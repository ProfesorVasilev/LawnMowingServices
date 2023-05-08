/*

Console.WriteLine("Whats the length of your lawn?");
int length = int.Parse(Console.ReadLine());
Console.WriteLine("Whats the width of your lawn?");
int width = int.Parse(Console.ReadLine());
int area = width * length;
Console.WriteLine($"The area of your lawn is {area}.");
if (area >= 1 && area < 400)
{
    Console.WriteLine("Your weekly mowing fee is 25$.");
    Console.WriteLine("The total for the season would be 500$");
}
else if (area >= 400 && area < 600)                                                 Version 1
{
    Console.WriteLine("Your weekly mowing fee is 35$.");
    Console.WriteLine("The total for the season would be 700$");
}
else if (area > 600)
{
    Console.WriteLine("Your weekly mowing fee is 50$.");
    Console.WriteLine("The total for the season would be 1000$");
}
else
    Console.WriteLine("The area of your lawn isnt valid.");

*/

using System.Runtime.CompilerServices;

Console.WriteLine("Whats the length of your lawn?");
int length = int.Parse(Console.ReadLine());
Console.WriteLine("Whats the width of your lawn?");
int width = int.Parse(Console.ReadLine());
int area = width * length;
Console.WriteLine($"The area of your lawn is {area}.");
int weeklyPrice;
if (area <= 0)
{ 
    Console.WriteLine($"{area} is not a valid area!");                                    //Version 2
}
if (area >= 1 && area < 400)
{
    weeklyPrice = 25;
    int total = weeklyPrice * 20;
    Console.WriteLine($"Your weekly price is {weeklyPrice} and your total for the season would be {total}.");
}
else if (area >= 400 && area < 600)
{
    weeklyPrice = 35;
    int total = weeklyPrice * 20;
    Console.WriteLine($"Your weekly price is {weeklyPrice} and your total for the season would be {total}.");
}
else if (area > 600)
{
    weeklyPrice = 50;
    int total = weeklyPrice * 20;
    Console.WriteLine($"Your weekly price is {weeklyPrice} and your total for the season would be {total}.");
}


