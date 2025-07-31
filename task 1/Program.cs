System.Console.WriteLine("Welcome to Islam's Carpet Cleaning Service!");
System.Console.WriteLine("Charges:");
System.Console.WriteLine("per small carpet $25 ");
System.Console.WriteLine("per large carpet  $35 ");
System.Console.WriteLine("Sales tax rate is 6%");
System.Console.WriteLine("Estimates are valid for 30 days");

double pricePerSmall = 25;
double pricePerLarge = 35;
double taxRate = 0.06;

Console.Write("Enter number of small carpets (press Enter to skip): ");
string inputSmall = Console.ReadLine();
int numSmall = string.IsNullOrWhiteSpace(inputSmall) ? 0 : Convert.ToInt32(inputSmall);

Console.Write("Enter number of large carpets (press Enter to skip): ");
string inputLarge = Console.ReadLine();
int numLarge = string.IsNullOrWhiteSpace(inputLarge) ? 0 : Convert.ToInt32(inputLarge);

double cost = (numSmall * pricePerSmall) + (numLarge * pricePerLarge);
double tax = cost * taxRate;
double total = cost + tax;


Console.WriteLine($"Cost: ${cost}");
Console.WriteLine($"Tax: ${tax}");
Console.WriteLine($"Total estimate: ${total}");
