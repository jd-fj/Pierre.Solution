using System;
using Pierre.Models;
using System.Collections.Generic;

class Program
{
  public static Bread pita = new Bread("pita", 0);
  public static Bread french = new Bread("french", 0);

  public static List<Bread> allBread = new List<Bread>() {pita, french};

  public static Pastry biscuit = new Pastry("biscuit", 0);
  public static Pastry croissant = new Pastry("croissant", 0);

  public static List<Pastry> allPastries = new List<Pastry>() {biscuit, croissant};


  public static void Main()
  {
    Console.WriteLine("Hello ");

    foreach (Bread loaf in allBread)
    {
    Console.WriteLine(allBread);
    }
  }
} 

// I want the console to do things in this order:
// 1. Start screen lists breads and pastries
// 2. Ask what type and quantity of bread
// 3. Ask what type and quantity of pastry
// 4. Ask if they need to add anything else (if so run through main again)
// 5. Once the answer is "no" to needing anything else...
// 6. Print the grand total and what they ordered