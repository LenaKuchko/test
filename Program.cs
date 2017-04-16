using System;
using System.Collections.Generic;

namespace Animals
{
  public class Animal
  {
    public string Name;
    public int age;
    public string sex;
    public string spicies;
    public bool adopted;

    public Animal(string name, int Age, string Sex, string Spicies, bool Adopted=false)
    {
      Name = name;
      age = Age;
      sex = Sex;
      spicies = Spicies;
      
    }

    public bool IsCat()
    {
      if (spicies=="cat") {
        return true;
      }
      else {
        return false;
      }
    }

    public void Adopt()
    {
      adopted = true;
    }

  }
    class Program
    {
        static void Main(string[] args)
        {
          Animal cat1 = new Animal("Marty", 2, "male", "cat");
          Animal dog1 = new Animal("Nayda", 5, "male", "dog");
          Animal cat2 = new Animal("Leo", 4, "male", "cat");
          Animal cat3 = new Animal("Timon", 1, "male", "cat");
          Animal dog2 = new Animal("Dina", 8, "male", "dog");
          Animal dog3 = new Animal("Rex", 7, "male", "dog");


          List<Animal>  animals = new List<Animal>(){cat1, cat2, cat3, dog1, dog2};
          animals.Add(dog3);

          Console.WriteLine("Enter preffered age:");
          int prefAge = int.Parse(Console.ReadLine());

          List<Animal> prefAnimals = new List<Animal>();
          prefAnimals = SortAnimal(prefAge, animals);

          foreach (Animal item in prefAnimals)
          {
            Console.WriteLine(item.Name + item.adopted);
          }

          Console.WriteLine("There are our cats:");
          foreach (Animal item in animals) {
            if (item.IsCat()) {
              Console.WriteLine(item.Name);
            }
          }
          Console.WriteLine("Enter adopted pet's name:");
          string adoptedPetName = Console.ReadLine();

          if (adoptedPetName!="") {
            AdoptPet(adoptedPetName, animals);
          }
        }


        public static List<Animal> SortAnimal(int agePref, List<Animal> anim)
        {
          List<Animal> sortedAnimals = new List<Animal>();
          foreach (Animal item in anim) {
            if (item.age<agePref) {
              sortedAnimals.Add(item);
            }
          }
          return sortedAnimals;
        }

        public static void AdoptPet (string name, List<Animal> pets)
        {
          for (int i=0; i<pets.Count; i++) {
            if (pets[i].Name==name) {
              pets[i].Adopt();
              Console.WriteLine(pets[i].Name + pets[i].adopted);

            }
          }
        }

    }
}
