using System;
using System.Collections.Generic;

namespace Park.Models
{
  public class Animal
  {
    private string Species;
    private string Name;
    private string Diet;
    private int Age;
    private bool Danger;
    public static List<Animal> myAnimals = new List<Animal>(){};

    public Animal()
    {
      Species = "";
      Name = "";
      Diet = "";
      Age = 0;
      Danger = false;
    }
    //Setters
    public void SetSpecies(string species)
    {
      Species = species;
    }
    public void SetName(string name)
    {
      Name = name;
    }
    public void SetDiet(string diet)
    {
      Diet = diet;
    }
    public void SetAge(int age)
    {
      Age = age;
    }
    public void SetDanger(string danger)
    {
        if (danger == "yes")
        {
          Danger = true;
        }
    }

    //Getters
     public string GetSpecies()
    {
     return Species;
    }
    public string GetName()
    {
      return Name;
    }
    public string GetDiet()
    {
     return Diet;
    }
    public int GetAge()
    {
      return Age;
    }
    public bool GetDanger()
    {
     return Danger;
    }
   public static void GetAnimalDetails(string input)
   {
     foreach(Animal animal in myAnimals)
     {
       if(input == animal.Name)
       {
          Console.WriteLine("-------------------------------");
          Console.WriteLine($"Name: {animal.Name}");
          Console.WriteLine($"Species: {animal.Species}");
          Console.WriteLine($"Diet: {animal.Diet}");
          Console.WriteLine($"Age: {animal.Age}");
          Console.WriteLine($"Dangerous: {animal.Danger}");
          Console.WriteLine("-------------------------------");
       }
     }
   }
  }
}
