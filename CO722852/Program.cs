using System;

namespace CO722852
{
    class Program
    {
        class Dog
        {
            public int NumberofDogs = 0;
            public Dog()
            {
                Dog.NumberofDogs++;
            }
            String DogName;
            String DogBreed;
            Dog nextDog;
        
        class LinkedList
        {
                public Dog current = new Dog();
                public Dog Head = new Dog();
                public Dog Peanut = new Dog();
                public Dog Fifi = new Dog();
                public Dog Jordan = new Dog();
                public Dog Fido = new Dog();

                public void run()
                {
                    Head = Peanut;
                    Peanut.DogName = "Peanut";
                    Jordan.DogBreed = "Bichon";

                    Peanut.nextDog = Fifi;

                    Fifi.DogName = "Fifi";
                    Fifi.DogBreed = "poodle";

                    Fifi.nextDog = Jordan;
                    Jordan.DogName = "Jordan";
                    Jordan.DogBreed = "German Shepperd";

                    Jordan.nextDog = Fido;
                    Fido.DogName = "Fido";
                    Fido.DogBreed = "Beagle";
                    Fido.nextDog = null;
                }
                public void WalkOvertheList()
                {
                    current = Head;
                    while(current != null)
                    {
                        Console.WriteLine(current.DogName);
                        current = current.nextDog;           
                    }
        }
    }
}
