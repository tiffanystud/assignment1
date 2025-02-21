using System;

namespace Review
{
    class Pet
    {
        private string name;
        private int age;
        private bool isFemale;

        public Pet()
        {
            this.name = "Unknown";
            this.age = 0;
            this.isFemale = false;
        }

        public void Start()
        {
            ReadAndSavePetData();
            DisplayPetInfo();
        }
        private void ReadAndSavePetData()
        {
            Console.Write("What's your pets name? ");
            name = Console.ReadLine();

            Console.Write("What age is your pet? ");
            age = int.Parse(Console.ReadLine());

            Console.Write("Is your pet a female (y/n)? ");
            string userInputGender = Console.ReadLine();
            isFemale = userInputGender == "y";
        }

        private void DisplayPetInfo()
        {
            Console.WriteLine("                   ");
            Console.WriteLine("-------------------");
            Console.WriteLine("                   ");

            Console.WriteLine($"Name: {name} Age: {age} ");
            string petGender;
            if (isFemale)
            {
                petGender = "girl";
            }
            else
            {
                petGender = "boy";
            }
            Console.WriteLine($"{name} is a good {petGender}! ");

            Console.WriteLine("                   ");
            Console.WriteLine("-------------------");
            Console.WriteLine("                   ");

        }

    }
}
