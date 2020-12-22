using System;
using Pierre.Models;
using System.Collections.Generic;

namespace Pierre
{
  class Program
  {
    public static string[] breadMenu = { "Pita", "French" };
    public static string[] pastryMenu = { "Biscuits", "Croissants" };

    public static void Main()
    {
      Console.WriteLine("Would you like to order some of our fine Breads? ['Y' for yes, 'Enter' for no]");
      string breadYesOrNo = Console.ReadLine().ToLower();
      if (breadYesOrNo == "y")
      {
        Console.WriteLine("What type of bread do you want?['french' or 'pita']");
        string breadSelection = Console.ReadLine();
        Console.WriteLine("How many?");
        int breadQuant = int.Parse(Console.ReadLine());
        Bread breadOrder = new Bread(breadSelection, breadQuant);
        int breadGt = breadOrder.GetSaleCost();
        Console.WriteLine("Your Sale Price: " + breadGt);
        Main();
      }

      else
      {
        Console.WriteLine("Would you like to order some of our fine Pastries? ['Y' for yes, 'Enter' for no]");
        string pastryYesOrNo = Console.ReadLine().ToLower();
        if (pastryYesOrNo == "y")
        {
          // return pastryOrder;
        }
        else
        {
          Console.WriteLine("Press enter to check out");
        }
      }
      // Console.WriteLine(BreadTotal);
      // Console.WriteLine(PastryTotal);
    }

  }
}