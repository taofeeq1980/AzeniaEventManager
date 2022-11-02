using Azenia.EventManager.Data.Models;

namespace Azenia.EventManager.Helpers;

public static class EmailSender
{
    // You do not need to know how these methods work
    internal static void AddToEmail(Customer c, Event e, int? price = null)
    {
        var distance = GeolocationCalculation.GetDistance(c.City, e.City);
        Console.Out.WriteLine($"{c.Name}: {e.Name} in {e.City}"
        + (distance > 0 ? $" ({distance} miles away)" : "")
        + (price.HasValue ? $" for ${price}" : ""));
    }
}

