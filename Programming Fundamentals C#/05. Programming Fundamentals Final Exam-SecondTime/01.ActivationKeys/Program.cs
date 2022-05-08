using System;

namespace _01.ActivationKeys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string rawActivationKey = Console.ReadLine();
            string command = Console.ReadLine();

            while (command != "Generate")
            {
                string[] cmdArgs = command
                    .Split(">>>", StringSplitOptions.RemoveEmptyEntries);

                string action = cmdArgs[0];

                if (action == "Contains")
                {
                    string substring = cmdArgs[1];
                    if (rawActivationKey.Contains(substring))
                    {
                        Console.WriteLine($"{rawActivationKey} contains {substring}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }

                }
                else if (action == "Flip")
                {
                    string upperOrLower = cmdArgs[1];
                    int startIndex = int.Parse(cmdArgs[2]);
                    int endIndex = int.Parse(cmdArgs[3]);

                    string textToFlip = rawActivationKey.Substring(startIndex, endIndex - startIndex);

                    if (upperOrLower == "Upper")
                    {
                        textToFlip = textToFlip.ToUpper();
                    }
                    else if (upperOrLower == "Lower")
                    {
                        textToFlip = textToFlip.ToLower();
                    }

                    rawActivationKey = rawActivationKey.Remove(startIndex, endIndex - startIndex);
                    rawActivationKey = rawActivationKey.Insert(startIndex, textToFlip);

                    Console.WriteLine(rawActivationKey);
                }
                else if (action == "Slice")
                {
                    int startIndex = int.Parse(cmdArgs[1]);
                    int endIndex = int.Parse(cmdArgs[2]);
                    rawActivationKey = rawActivationKey.Remove(startIndex, endIndex - startIndex);

                    Console.WriteLine(rawActivationKey);
                }



                command = Console.ReadLine();
            }
            Console.WriteLine($"Your activation key is: {rawActivationKey}");
        }
    }
}
