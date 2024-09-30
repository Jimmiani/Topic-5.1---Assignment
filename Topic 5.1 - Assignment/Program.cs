namespace Topic_5._1___Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Emmett Cornies
            int planetNumber;
            double weight, venWeight, marWeight, jupWeight, satWeight, uraWeight, nepWeight;
            Console.Write("Hello Mr. Cesar, please enter your current earth weight: ");
            Double.TryParse(Console.ReadLine(), out weight);
            Console.WriteLine("Thank you, now please select which planet you are visiting today.");
            Console.WriteLine();
            Console.WriteLine("\t1. Venus \t2. Mars \t3. Jupiter");
            Console.WriteLine("\t4. Saturn \t5. Uranus \t6. Neptune");
            venWeight = weight * 0.78;
            marWeight = weight * 0.39;
            jupWeight = weight * 2.65;
            satWeight = weight * 1.17;
            uraWeight = weight * 1.05;
            nepWeight = weight * 1.23;
            Console.WriteLine();
            Console.Write("Enter planet number: ");
            Int32.TryParse(Console.ReadLine(), out planetNumber);
            Console.WriteLine();
            if (planetNumber == 1)
                Console.WriteLine("Your weight would be " + venWeight + ". Try not to get burnt alive on that planet!");
            else if (planetNumber == 2)
                Console.WriteLine("Your weight would be " + marWeight + ". Make sure to remember your spacesuit!");
            else if (planetNumber == 3)
                Console.WriteLine("Your weight would be " + jupWeight + ". Don't get crushed under its gravity!");
            else if (planetNumber == 4)
                Console.WriteLine("Your weight would be " + satWeight + ". Don't get sliced by its ring!");
            else if (planetNumber == 5)
                Console.WriteLine("Your weight would be " + uraWeight + ". Watch out for the diamond rain!");
            else if (planetNumber == 6)
                Console.WriteLine("Your weight would be " + nepWeight + ". Don't get caught in those rough storms!");
            else
                Console.WriteLine("Invalid Input.");
            Console.WriteLine();
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
            Console.Clear();

        }
    }
}
