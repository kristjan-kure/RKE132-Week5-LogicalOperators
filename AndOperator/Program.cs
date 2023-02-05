//Math >= 90; Biology >= 90; Chemistry >= 90

int mathResult, biologyResult, chemistryResult;

Console.WriteLine("Enter your Math result:");
mathResult = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your Biology result:");
biologyResult = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your Chemistry result:");
chemistryResult = Int32.Parse(Console.ReadLine());

if (mathResult >= 90 && biologyResult >= 90 && chemistryResult >= 90)
{
    Console.WriteLine("Congratulations! You are approved!");
}
else
{
    Console.WriteLine("Sorry, your application cannot be approved.");
}

