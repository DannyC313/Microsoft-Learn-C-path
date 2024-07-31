﻿Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0; 

if (daysUntilExpiration <= 0)
{
    Console.WriteLine("Your subscription has expired.");
}

else if (daysUntilExpiration <= 1)
{
    Console.WriteLine("Your subscription expires within a day!");
    discountPercentage = 20;
    Console.Write($"\nRenew now and save {discountPercentage} %.");
}

else if (daysUntilExpiration <= 5)
{
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration}  days. ");
    discountPercentage = 10;
    Console.Write($"\nRenew now and save {discountPercentage} %.");
}

else if (daysUntilExpiration <= 10)
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}
