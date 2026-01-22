// See https://aka.ms/new-console-template for more information
Console.WriteLine("How many days are remaining on your current Subscription?");
int daysRemaining = int.Parse(Console.ReadLine());
GetSubscriptionMessage(daysRemaining);

void GetSubscriptionMessage(int daysRemaining)
{
    // logic goes here
    if (daysRemaining < 0)
    {
        System.Console.WriteLine("your subscription has expired, please renew now.");
    }

    else if (daysRemaining <= 2)
    {
        System.Console.WriteLine("you have very little time left on your subscription, renew now and save 30%");
    }

    else if (daysRemaining <= 7)
    {
        System.Console.WriteLine($"you have {daysRemaining} days left in your subscription, kindly renew and earn a 20% discount on your renewal! ");
    }

    else if (daysRemaining > 7)
    {
        System.Console.WriteLine($"No action needed:\tyou have {daysRemaining} days left in your subscription");
    }
}
