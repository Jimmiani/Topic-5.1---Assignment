namespace Topic_5._1___Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Emmett Cornies
            string multAnswer, textAnswer, trueFalseAns;
            int planetNumber, secretNumber, score = 0, numberAnswer;
            double weight, venWeight, marWeight, jupWeight, satWeight, uraWeight, nepWeight;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Clear();
            Console.Write("Hello Mr. Cesar, please enter your current earth weight (lbs): ");
            Double.TryParse(Console.ReadLine(), out weight);
            Console.WriteLine("Thank you, now please select which planet you are visiting today.");
            Console.WriteLine();
            Console.WriteLine("\t1. Venus \t2. Mars \t3. Jupiter");
            Console.WriteLine("\t4. Saturn \t5. Uranus \t6. Neptune");
            venWeight = Math.Round(weight * 0.78, 2);
            marWeight = Math.Round(weight * 0.39, 2);
            jupWeight = Math.Round(weight * 2.65, 2);
            satWeight = Math.Round(weight * 1.17, 2);
            uraWeight = Math.Round(weight * 1.05, 2);
            nepWeight = Math.Round(weight * 1.23, 2);
            Console.WriteLine();
            Console.Write("Enter planet number: ");
            Int32.TryParse(Console.ReadLine(), out planetNumber);
            Console.WriteLine();
            if (planetNumber == 1)
                Console.WriteLine("Your weight would be " + venWeight + " pounds. Try not to get burnt alive on that planet!");
            else if (planetNumber == 2)
                Console.WriteLine("Your weight would be " + marWeight + " pounds. Make sure to remember your spacesuit!");
            else if (planetNumber == 3)
                Console.WriteLine("Your weight would be " + jupWeight + " pounds. Don't get crushed under its gravity!");
            else if (planetNumber == 4)
                Console.WriteLine("Your weight would be " + satWeight + " pounds. Don't get sliced by its ring!");
            else if (planetNumber == 5)
                Console.WriteLine("Your weight would be " + uraWeight + " pounds. Watch out for the diamond rain!");
            else if (planetNumber == 6)
                Console.WriteLine("Your weight would be " + nepWeight + " pounds. Don't get caught in those rough storms!");
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
            Console.WriteLine("Time for a quiz! If you score a 100%, there's a special surprise at the end!");
            Console.WriteLine();
            Console.WriteLine("Question 1) 27 - 3x = 21");
            Console.Write("Solve for X: ");
            Int32.TryParse(Console.ReadLine(), out numberAnswer);
            Console.WriteLine();
            if (numberAnswer == 2)
            {
                Console.WriteLine("That's correct! Press Enter to continue to next question.");
                score += 1;
            }
            else
                Console.WriteLine("That's incorrect. The correct answer was 2. Press Enter to continue to next question.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Question 2) True or False: A tablespoon of a neutron star weighs as much as a blue whale.");
            Console.WriteLine();
            Console.Write("Enter your answer (true/false): ");
            trueFalseAns = Console.ReadLine();
            Console.WriteLine();
            if (trueFalseAns.ToLower() == "false")
            {
                Console.WriteLine("That's correct! A tablespoon of a neutron star actually weighs roughly as much as Mount Everest.");
                Console.WriteLine();
                Console.WriteLine("Press Enter to continue.");
                score += 1;
            }
            else if (trueFalseAns.ToLower() == "true")
                Console.WriteLine("That's incorrect. It actually weighs more! Press Enter to continue to next question.");
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
            if (multAnswer.ToUpper() == "A")
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
            Console.Write("Enter your answer: ");
            textAnswer = Console.ReadLine();
            Console.WriteLine();
            if (textAnswer.ToLower() == "gold")
            {
                Console.WriteLine("That's correct! The chemical symbol 'Au' stands for Gold. Press Enter see your results.");
                score += 1;
            }
            else
                Console.WriteLine("That's incorrect. The correct answer was gold. Press Enter to see your results.");
            Console.ReadLine();
            Console.Clear();
            if (score == 4)
            {
                Console.WriteLine("WOW! You got a perfect score! You somehow managed to get all 4 questions right! Here's a certification for your effort!");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("\t\t\t\t ____________________________________________________");
                Console.WriteLine("\t\t\t\t|Certification of Honour; awarded to Steven Aldworth!|");
                Console.WriteLine("\t\t\t\t|                                                    |");
                Console.WriteLine("\t\t\t\t|This certification is only awarded to those capable |");
                Console.WriteLine("\t\t\t\t|of accomplishing the impossible. You are a freak of |");
                Console.WriteLine("\t\t\t\t|nature, and I wish you well on your journey.        |");
                Console.WriteLine("\t\t\t\t|                                                    |");
                Console.WriteLine("\t\t\t\t|Signed by: Emmett Cornies                           |");
                Console.WriteLine("\t\t\t\t|____________________________________________________|");
            }
            else if (score == 3)
                Console.WriteLine("Well done! You scored 3 out of 4 questions! That's a 75%. Congratulations!");
            else if (score == 2)
                Console.WriteLine("Good effort. Only 2 out of 4 questions answered correctly. I know you can do better...");
            else if (score == 1)
                Console.WriteLine("Wow! You weren't even close! You only got 1 out of 4 questions right... That's pathetic!");
            else
                Console.WriteLine("You didn't even get a single question right? You're either dumb, or just skipping through the questions... Try again!");
            Console.ReadLine();
        }
    }
}
