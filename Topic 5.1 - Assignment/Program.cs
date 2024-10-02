namespace Topic_5._1___Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Emmett Cornies
            string multAnswer;
            int planetNumber, secretNumber, score = 0;
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
            Console.WriteLine("Hello! Try to guess my secret number! I'll give you one guess, and if you get it, I'll give you my super yacht!");
            Console.WriteLine();
            Console.Write("Guess secret number (1-10): ");
            Int32.TryParse(Console.ReadLine(), out secretNumber);
            Console.WriteLine();
            if (secretNumber == 4)
            {
                Console.WriteLine("WOW! You guessed it! I guess I gotta give you the super yacht my grandpa left me before he died! Oh well!");
                Console.WriteLine();
                Console.WriteLine("SUPER YACHT added to inventory!");
            }
            else if (secretNumber >= 1 && secretNumber <= 10)
            {
                Console.WriteLine("Ah! Nice try! The right number was 4! I guess I get to keep my super yacht!");
            }
            else
                Console.WriteLine("That's not a number from 1-10! DISQUALIFIED!!");
            Console.WriteLine();
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Time for a quiz! If you score a 100%, I'll give you a penny!");
            Console.WriteLine();
            Console.WriteLine("Question 1: What is the only food that cannot go bad?");
            Console.WriteLine();
            Console.WriteLine("\tA) Peanut Butter");
            Console.WriteLine("\tB) Dark chocolate");
            Console.WriteLine("\tC) Canned tuna");
            Console.WriteLine("\tD) Honey");
            Console.WriteLine();
            Console.Write("Enter your answer (A-D): ");
            multAnswer = Console.ReadLine();
            Console.WriteLine();
            if (multAnswer.ToUpper() == "D")
            {
                Console.WriteLine("That's correct! Press Enter to continue to next question.");
                score += 1;
            }
            else if (multAnswer.ToUpper() == "A" || multAnswer.ToUpper() == "B" || multAnswer.ToUpper() == "C")
                Console.WriteLine("That's incorrect. The correct answer was honey. Press Enter to continue to next question.");
            else
                Console.WriteLine("Invalid input. Answer treated as if it was incorrect. Press Enter to continue to next question");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Question 2: Which of these is the most visited attraction in the world?");
            Console.WriteLine();
            Console.WriteLine("\tA) Eiffel Tower");
            Console.WriteLine("\tB) Statue of Liberty");
            Console.WriteLine("\tC) Forbidden City");
            Console.WriteLine("\tD) Colosseum");
            Console.WriteLine();
            Console.Write("Enter your answer (A-D): ");
            multAnswer = Console.ReadLine();
            Console.WriteLine();
            if (multAnswer.ToUpper() == "C")
            {
                Console.WriteLine("That's correct! The Forbidden City in China is the #1 most visited attraction in the world. Press Enter to continue.");
                score += 1;
            }
            else if (multAnswer.ToUpper() == "A" || multAnswer.ToUpper() == "B" || multAnswer.ToUpper() == "D")
                Console.WriteLine("That's incorrect. The correct answer was The Forbidden City. Press Enter to continue to next question.");
            else
                Console.WriteLine("Invalid input. Answer treated as if it was incorrect. Press Enter to continue to next question");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Question 3: What is the name of Hagrid’s pet spider?");
            Console.WriteLine();
            Console.WriteLine("\tA) Aragog");
            Console.WriteLine("\tB) Crookshank");
            Console.WriteLine("\tC) Nigini");
            Console.WriteLine("\tD) Mosag");
            Console.WriteLine();
            Console.Write("Enter your answer (A-D): ");
            multAnswer = Console.ReadLine();
            Console.WriteLine();
            if (multAnswer == "A")
            {
                Console.WriteLine("That's correct! Aragog is Hagrid's pet spider. Press Enter to continue.");
                score += 1;
            }
            else if (multAnswer.ToUpper() == "B" || multAnswer.ToUpper() == "C" || multAnswer.ToUpper() == "D")
                Console.WriteLine("That's incorrect. The correct answer was Aragog. Press Enter to continue to next question.");
            else
                Console.WriteLine("Invalid input. Answer treated as if it was incorrect. Press Enter to continue to next question");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Question 4: What element does the chemical symbol Au stand for?");
            Console.WriteLine();
            Console.WriteLine("\tA) Mercury");
            Console.WriteLine("\tB) Magnesium");
            Console.WriteLine("\tC) Silver");
            Console.WriteLine("\tD) Gold");
            Console.WriteLine();
            Console.Write("Enter your answer (A-D): ");
            multAnswer = Console.ReadLine();
            Console.WriteLine();
            if (multAnswer.ToUpper() == "D")
            {
                Console.WriteLine("That's correct! The chemicAu stands Press Enter to continue to next question.");
                score += 1;
            }
            else if (multAnswer.ToUpper() == "A" || multAnswer.ToUpper() == "B" || multAnswer.ToUpper() == "C")
                Console.WriteLine("That's incorrect. The correct answer was gold. Press Enter to continue to next question.");
            else
                Console.WriteLine("Invalid input. Answer treated as if it was incorrect. Press Enter to continue to next question");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
