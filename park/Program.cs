using System;
using System.Collections.Generic;
using Park.Models;

namespace Park
{
  public class Program
  {
    
    public static void Main()
    {
      string title = @"              
              X XX                               XX XX
             XX   XX                             X    X
             X      X                           X     XX
             X       XX                         X      X
             X        XX                        X       X
            X          XXX                      X       X
            X            XX                    X         X
            X          X X XX X X XXX        X X         X
            X      XX X             XXXXXXXX X           X
            X    XX     XXXX         XXXX     X         XX
            XX  X     XXX  XXX     XXX  XXX   XXX      XX
               X      XXX    X     XXX    X      XXX   X
             XX       XXXXXXXX     XXXXXXXX        XX  X
            X         XXXXXXXX     XXXXXXXX          X
            X                                        XX
                                XX                    XX
XX XXXXXXXXX  X  XXXX         XXXXX             X X XXXXXxXXXXX
           X                 XXXXXXXX   XXX X X       X
           X        X                    XXXX         X
            XX X XXX            X            XXXXXXXXXX
           X XX        XX       X        X            XXXXXXXXX
        XX    XXX       XX     XXX       X           XX
                XX       XXXXXXX XXXXXXXXX         XXX
                  XX                            XXX
                    XXX                    XX X
                       X X X X XX X X X XX
";

      Console.WriteLine(title);
      Console.WriteLine("Welcome to the wildlife park! Would you like to add an animal or view the current list of animals? (Type add or view)");
      string response = Console.ReadLine();
      if (response == "add")
      {
        Console.Write("Enter this animal's name: ");
        string input = Console.ReadLine();
        Animal animal = new Animal();
        animal.SetName(input);
        Console.Write("Enter this animal's species: ");
        string species = Console.ReadLine();
        animal.SetSpecies(species);
        Console.Write("Enter this animal's diet: ");
        string diet = Console.ReadLine();
        animal.SetDiet(diet);
        Console.Write("Enter this animal's age: ");
        string ageStr = Console.ReadLine();
        int age = int.Parse(ageStr);
        animal.SetAge(age);
        Console.Write("Is this animal dangerous? yes or no: ");
        string dangerStr = Console.ReadLine();
        animal.SetDanger(dangerStr);
        Animal.myAnimals.Add(animal);
        Main();
      }
      else if (response == "view")
      {
        foreach (Animal animal in Animal.myAnimals)
        {
          Console.WriteLine(animal.GetName());
        }
        Console.Write("Enter an animal's name to see more info: ");
        string name = Console.ReadLine();
        Animal.GetAnimalDetails(name);
        Main();
      }
    }
  }
}