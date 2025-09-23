using System;
using System.Text;

namespace PasswordGenerator
{
    class Program
    {
        // Character sets for password generation
        const string UPPERCASE = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        const string LOWERCASE = "abcdefghijklmnopqrstuvwxyz";
        const string NUMBERS = "0123456789";
        const string SYMBOLS = "!@#$%^&*()_+-=[]{}|;:,.<>?";
        
        static Random random = new Random();

        static void Main(string[] args)
        {
            Console.WriteLine("=== Password Generator ===");
            Console.WriteLine();

            bool continueRunning = true;

            while (continueRunning)
            {
                // Display menu
                Console.WriteLine("Password Types:");
                Console.WriteLine("1. Simple Password (letters only)");
                Console.WriteLine("2. Standard Password (letters + numbers)");
                Console.WriteLine("3. Strong Password (letters + numbers + symbols)");
                Console.WriteLine("4. Custom Password (choose character sets)");
                Console.WriteLine("5. Memorable Password (pronounceable)");
                Console.WriteLine("6. PIN Generator (numbers only)");
                Console.WriteLine("7. Exit");
                Console.WriteLine();

                Console.Write("Choose password type (1-7): ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        HandleSimplePassword();
                        break;

                    case "2":
                        HandleStandardPassword();
                        break;

                    case "3":
                        HandleStrongPassword();
                        break;

                    case "4":
                        HandleCustomPassword();
                        break;

                    case "5":
                        HandleMemorablePassword();
                        break;

                    case "6":
                        HandlePINGenerator();
                        break;

                    case "7":
                        continueRunning = false;
                        Console.WriteLine("Thank you for using Password Generator!");
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please choose 1-7.");
                        break;
                }

                Console.WriteLine();
            }
        }

        // TODO: Implement password generation handlers
        static void HandleSimplePassword()
        {
            Console.WriteLine("Simple Password - Not implemented yet");
            // TODO: Ask for length, generate simple password
        }

        static void HandleStandardPassword()
        {
            Console.WriteLine("Standard Password - Not implemented yet");
        }

        static void HandleStrongPassword()
        {
            Console.WriteLine("Strong Password - Not implemented yet");
        }

        static void HandleCustomPassword()
        {
            Console.WriteLine("Custom Password - Not implemented yet");
        }

        static void HandleMemorablePassword()
        {
            Console.WriteLine("Memorable Password - Not implemented yet");
        }

        static void HandlePINGenerator()
        {
            Console.WriteLine("PIN Generator - Not implemented yet");
        }

        // TODO: Implement password generation functions
        // Example function signatures:
        // static string GenerateSimplePassword(int length)
        // static string GenerateStandardPassword(int length)
        // static string GenerateStrongPassword(int length)
        // static char GetRandomCharacter(string characterSet)
        // static int CalculatePasswordStrength(string password)
        // static bool IsValidLength(int length, int min, int max)
    }
}