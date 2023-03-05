using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Pendergast_PE13
{
    class Pets
    {
        List<Pet> petList = new List<Pet>();
        public Pet this[int nPetEl]
        {
            get
            {
                Pet returnVal;
                try
                {
                    returnVal = (Pet)petList[nPetEl];
                }
                catch
                {
                    returnVal = null;
                }
                return (returnVal);
            }

            set
            {
                // if index is less than number od listed elements
                if (nPetEl < petList.Count)
                {
                    // update the existing value at taht point on the index
                    petList[nPetEl] = value;
                }
                else
                {
                    // add value to list
                    petList.Add(value);
                }
            }
        }

        public int Count
        {
            get
            {
                return petList.Count;
            }
        }

        public void Add(Pet pet)
        {
            petList.Add(pet);
        }

        public void Remove(Pet pet)
        {
            petList.Remove(pet);
        }

        public void RemoveAt(int nPetEl)
        {
            petList.RemoveAt(nPetEl);
        }
    }



    public abstract class Pet
    {
        public string name;
        public int age;
        public Pet()
        {

        }

        public Pet(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public abstract void Eat();

        // play method
        public abstract void Play();

        // vet method
        public abstract void GoToVet();

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

    }
    public class Cat : Pet, ICat
    {

        public Cat(string name, int age) : base(name, age)
        {

        }

        public void Purr()
        {
            Console.WriteLine(name + " purrrrrr");
        }

        public void Scratch()
        {
            Console.WriteLine(name + " hissssss");
        }

        public override void Eat()
        {
            Console.WriteLine(name + " noms on some cat food");
        }

        public override void Play()
        {
            Console.WriteLine(name + " is playing with a cat toy");
        }

        public override void GoToVet()
        {
            Console.WriteLine(name + " is feeling sick, take them to the vet");
        }
    }

    public interface ICat
    {
        void Scratch();
        void Eat();
        void Play();
        void Purr();
    }

    public interface IDog
    {
        void GoToVet();
        void Eat();
        void Play();
        void NeedWalk();
        void Bark();
    }

    public class Dog : Pet, IDog
    {
        public string License { get; set; }

        public Dog(string szLicense, string szName, int nAge) : base(szName, nAge)
        {
            License = szLicense;
        }

        public void NeedWalk()
        {
            Console.WriteLine(name + " wiggles impatiently by the door");
        }

        public void Bark()
        {
            Console.WriteLine(name + " barks viciously. borf borf");
        }
        public override void Eat()
        {
            Console.WriteLine(name + " sits, then stays, and then finally can eat some food");
        }

        public override void Play()
        {
            Console.WriteLine(name + " fetches ye olde stick");
        }

        public override void GoToVet()
        {
            Console.WriteLine(name + " is feeling sick, take them to the vet");
        }
    }

    class main
    {
        static public void Main(String[] args)
        {
            Pet thisPet = null;
            Dog dog = null;
            Cat cat = null;
            IDog iDog = null;
            ICat iCat = null;

            Pets pets = new Pets();
            Random rando = new Random();

            for (int i = 0; i < 50; i++)
            {
                // 1 in 10 chance to add an animal
                if(rando.Next(1, 11) == 1)
                {
                    if (rando.Next(0, 2) == 00)
                    {
                        // add dawg
                        Console.WriteLine("a wild puppy appears!");
                        Console.WriteLine("dog's name => ");
                        string stName = Console.ReadLine();
                        Console.WriteLine("age =>") ;
                        int nAge = (int)Convert.ToInt64(Console.ReadLine());
                        Console.WriteLine("license => ");
                        string stLicense = Console.ReadLine();
                        dog = new Dog(stLicense, stName, nAge);
                        pets.Add(dog);
                    }
                    else
                    {
                        // add kat
                        Console.WriteLine("a wild kitty appears!");
                        Console.WriteLine("cat's name => ");
                        string stName = Console.ReadLine();
                        Console.WriteLine("age => ");
                        int nAge = (int)Convert.ToInt64(Console.ReadLine());
                        cat = new Cat(stName, nAge);
                        pets.Add(cat);

                    }
                }
                else
                {
                    // choose a random pet from pets and choose random activity
                    thisPet = pets[rando.Next(0, pets.Count)];
                    if(thisPet == null)
                    {
                        continue;
                    }
                    else if (thisPet.GetType() == typeof(Dog))
                    {
                        int action = rando.Next(0, 4);
                        iDog = (IDog)thisPet;
                        if (action == 0)
                        {
                            iDog.Eat();
                        }
                        else if (action == 1)
                        {
                            iDog.GoToVet();
                        }
                        else if (action == 2)
                        {
                            iDog.Play();
                        }
                        else if (action == 3)
                        {
                            iDog.Bark();
                        }
                        else if (action == 4)
                        {
                            iDog.NeedWalk();
                        }
                    }
                    else if (thisPet.GetType() == typeof(Cat))
                    {
                        int action = rando.Next(0, 3);
                        iCat = (Cat)thisPet;
                        if (action == 0)
                        {
                            iCat.Eat();
                        }
                        else if (action == 1)
                        {
                            iCat.Play();
                        }
                        else if (action == 2)
                        {
                            iCat.Purr();
                        }
                        else if (action == 3)
                        {
                            iCat.Scratch();
                        }
                    }
                }
            }
        }
    }
}


