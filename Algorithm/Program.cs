using System;

namespace Algorithm
{
    class PlayAlgorithm
    {
        // Display a welcome message for the algorithm.
        // Algoritma için hoş geldiniz mesajını gösterir.
        public static void Main(string[] args)
        {
            // Prompt the user to enter a valid number.
            // Kullanıcıdan geçerli bir sayı girmesini isteyin.
            Console.WriteLine("------------------------\n|<><>Algorithm<><>|\n------------------------");

            // Prompt the user to enter a valid number.
            // Kullanıcıdan geçerli bir sayı girmesini isteyin.
            Console.WriteLine("|<><>Please Enter Valid Number<><>|");
            Console.Write("|>>>");

            // Read the user input as an integer until a valid positive number is entered.
            // Kullanıcının girişini bir tamsayı olarak okuyun; geçerli bir pozitif sayı girilene kadar devam eder.
            int userInputNumber;
            while (!int.TryParse(Console.ReadLine(), out userInputNumber) || userInputNumber <= 0)
            {
                // Display an error message for invalid input.
                // Geçersiz giriş için bir hata mesajı gösterir.
                Console.WriteLine("|<><>Invalid Value! Please Enter Valid Number<><>|");
                Console.Write("|>>>");
            }

            // Prompt the user to enter a valid word.
            // Kullanıcıdan geçerli bir kelime girmesini ister
            Console.WriteLine("|<><>Please Enter Valid Word<><>|");
            Console.Write("|>>>");

            // Read the user input as a string until a valid string is entered.
            // Kullanıcının girişini bir dize olarak okuyun; geçerli bir dize girilene kadar devam eder.
            string? userInputString;
            do
            {
                userInputString = Console.ReadLine();

                // Check if the entered string is valid (consists only of letters).
                // Girilen dizenin geçerli olup olmadığını kontrol eder (sadece harflerden oluşuyor mu?).
                if (controlNull.controlString(userInputString))
                {
                    // Display a thank you message for valid input and exit the loop.
                    // Geçerli bir giriş için teşekkür mesajı gösterir ve döngüden çıkar.
                    Console.WriteLine("<>Thank you :)");
                    break;
                }
                else
                {
                    // Display an error message for invalid input.
                    // Geçersiz giriş için bir hata mesajı gösterir.
                    Console.WriteLine("<>Invalid value! Please Try Again<>");
                    Console.Write("|>>>");
                }

            } while (true);

            // Remove the character at the specified index and display the entered values.
            // Belirtilen dizindeki karakteri çıkarın ve girilen değerleri gösterir.
            string controlAndRemove = removeIndex.removeStringIndex(userInputString, userInputNumber - 1);
            Console.WriteLine($"The values you have entered: |{controlAndRemove}|");
        }
    }

    public class controlNull
    {
        // Check if the input string is null, empty, or consists only of letters.
        // Giriş dizesinin null, boş veya sadece harflerden oluşup oluşmadığını kontrol eder.
        public static bool controlString(string input)
        {
            return !string.IsNullOrWhiteSpace(input) && input.All(char.IsLetter);
        }
    }

    public class removeIndex
    {
        // Remove the character at the specified index in the input string.
        // Giriş dizisinde belirtilen dizindeki karakteri çıkarır.
        public static string removeStringIndex(string input, int index)
        {
            if (input == null || index < 0 || index >= input.Length)
            {
                return input;
            }
            return input.Remove(index, 1);
        }
    }
}
