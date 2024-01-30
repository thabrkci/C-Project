using System;

namespace ConsonantLetter
{
    class ShowConsonantLetter
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                // User is prompted to enter a word.
                // Kullanıcıya bir kelime girmesi istenir.
                Console.Write("*******************************\n||Please enter any word||\n*******************************\n|>");

                // User's input is taken.
                // Kullanıcının girişi alınır.
                string? userInput = Console.ReadLine();

                // Splits the entered sentence into words.
                // Girilen cümleyi kelimelere ayırır.
                string[] words = userInput.Split(' ');

                foreach (var word in words)
                {
                    // Calls the ControlWords function to check for consecutive consonant letters.
                    // Ardışık ünlü harfleri kontrol etmek için ControlWords fonksiyonu çağrılır.
                    if (Control.ControlWords(word))
                        Console.WriteLine("-----------\n|<True>|\n-----------");
                    else
                        Console.WriteLine("-----------\n|<False>|\n-----------");
                }

                // Adds a line break for better readability.
                // Daha iyi okunabilirlik için bir satır boşluk eklenir.
                Console.WriteLine();

                // Asks the user if they want to try again.
                // Kullanıcıya tekrar denemek isteyip istemediği sorulur.
                Console.WriteLine("*******************************\nDo you want to try again?\n*******************************\n[[1]Y [2]N]]\n*******************************");

                // Takes the user's choice.
                // Kullanıcının seçimini alır.
                string? userChoose = Console.ReadLine();

                // Performs actions based on the user's choice.
                // Kullanıcının seçimine göre işlem yapılır.
                if (userChoose == "1" || userChoose == "2")
                {
                    switch (userChoose)
                    {
                        // If the user chooses "1".
                        // Kullanıcı "1"i seçerse.
                        case "1":
                            Console.WriteLine("|You are being directed|");
                            break;

                        // If the user chooses "2".
                        // Kullanıcı "2"yi seçerse.
                        case "2":
                            Console.WriteLine("-----------------\n||See you later||\n-----------------");
                            return;

                        // If an invalid option is entered.
                        // Geçersiz bir seçenek girilirse.
                        default:
                            Console.WriteLine("||Please enter a valid option||");
                            break;
                    }
                }
            }
        }
    }

    public class Control
    {
        // Function that checks for consecutive consonant letters.
        // Ardışık ünlü harfleri kontrol eden fonksiyon.
        public static bool ControlWords(string word)
        {
            int consecutiveConsonantCount = 0; // Keep track of consecutive consonant count.
            string consonantLetters = "bcçdfghjklmnpqrstvwxyz";

            for (var i = 0; i < word.Length - 1; i++)
            {
                // Check if both the current and next characters are consonants.
                // Eğer hem mevcut hem de bir sonraki karakter ünlü harf ise kontrol et.
                if (IsConsonant(word[i]) && IsConsonant(word[i + 1]))
                {
                    consecutiveConsonantCount += 1; // Increment the consecutive consonant count.
                }
            }

            // Return true if there are consecutive consonants, otherwise false.
            // Ardışık ünlü harfler varsa true, aksi halde false döndür.
            return consecutiveConsonantCount > 0;
        }

        // Helper function to check if a character is a consonant.
        // Bir karakterin ünlü harf olup olmadığını kontrol etmek için yardımcı fonksiyon.
        private static bool IsConsonant(char character)
        {
            // Define consonant letters in a case-insensitive manner.
            // Ünlü harfleri büyük-küçük harf duyarsız bir şekilde tanımla.
            string consonantLetters = "bcçdfghjklmnpqrstvwxyz";

            // Check if the character is a consonant.
            // Karakterin ünlü harf olup olmadığını kontrol et.
            return consonantLetters.Contains(character.ToString(), StringComparison.OrdinalIgnoreCase);
        }
    }
}
