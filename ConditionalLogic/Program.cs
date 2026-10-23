/*Console.WriteLine("Write your average mark (%): ");
double mark = double.Parse(Console.ReadLine());

if (mark >= 90)
{
    Console.WriteLine("Admitted and eligible for scholarship.");
}
else if (mark >= 70)
{
    Console.WriteLine("Admitted standart entry");
}
else if (mark >= 60)
{
    Console.WriteLine("Conditional admission");
}
else
{
    Console.WriteLine("Not Admitted");
}

//ternary operator
// syntax:  if statment ? ValueWhenTrue: ValueWhenFalse;
//Ex string label= mark >=50 ? "pass" : "fail";

//switc Satement

Console.WriteLine("Enter the day number 1-7:");

int day=int.Parse(Console.ReadLine());

switch (day)
{
    case 1:
        Console.WriteLine("Monday");
        break;
    case 2:
        Console.WriteLine("Tuesday");
        break;
    case 3:
        Console.WriteLine("Wednesday");
        break;
    case 4:
        Console.WriteLine("Thursday");
        break;
    case 5:
        Console.WriteLine("Friday");
        break;
    case 6:
        Console.WriteLine("Saturday");
        break;
    case 7:
        Console.WriteLine("Sunday");
        break;
    default:
        Console.WriteLine("Select valid number");
        break;
}
*/

//Loops

/*for (int i = 0; i < 20; i++)
{
    Console.WriteLine(i);
    i=++i;
}*/

/*int k=0;
while (k<20)
{
   Console.WriteLine(k);
    k++;
}*/
string p;
do
{
    Console.WriteLine("Enter your password");
    p=Console.ReadLine();
}
while (p !="2000");
Console.WriteLine("Done!");