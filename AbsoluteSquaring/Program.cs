using System;

namespace AbsoluteSquaring
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("********************\n|AbsolutesSquaring|\n********************");

                // Ask the user how many numbers they want to enter
                // Kullanıcıya kaç adet sayı girmek istediğini sor
                Console.WriteLine("**********************\n|How many numbers do you want to enter?|\n**********************");

                // Get the user input for the number of entries
                // Giriş sayısı için kullanıcı girişini al
                int userInput;
                Console.Write("------\n|<>>>>");

                // Validate and ensure a valid positive integer is entered
                // Geçerli ve pozitif bir tam sayı girildiğinden emin ol
                while (!int.TryParse(Console.ReadLine(), out userInput) || userInput <= 0)
                {
                    // Display an error message for invalid input
                    // Geçersiz giriş için hata mesajını göster
                    Console.WriteLine("<|Invalid entry. Please enter a valid number|>");
                    Console.Write("------\n|<>>>>\n");
                }

                // Create an array to store the numbers entered by the user
                // Kullanıcının girdiği sayıları tutmak için bir dizi oluştur
                int[] userEnter = new int[userInput];

                // Ensure the user enters the specified number of numbers
                // Kullanıcının belirtilen sayıda sayı girmesini sağla
                for (var i = 0; i < userInput; i++)
                {
                    Console.Write($"------\n{i + 1}th.|<>>>>:");

                    // Validate and ensure a valid positive integer is entered for each number
                    // Her bir sayı için geçerli ve pozitif bir tam sayı girildiğinden emin ol
                    while (!int.TryParse(Console.ReadLine(), out userEnter[i]) || userEnter[i] <= 0)
                    {
                        // Display an error message for invalid input
                        // Geçersiz giriş için hata mesajını göster
                        Console.WriteLine("<|Invalid entry. Please enter a valid number|>");
                        Console.Write("------\n|<>>>>");
                    }
                }

                // Calculate the sum of differences based on whether the numbers are less or greater than 67
                // Sayıların 67'den küçük veya büyük olma durumlarına göre farkların toplamını hesapla
                int sumOfDifferences = 0;
                for (var i = 0; i < userInput; i++)
                {
                    int difference = userEnter[i] - 67;
                    if (difference < 0)
                    {
                        // Sum the squares of differences for numbers less than 67
                        // 67'den küçük olanların farklarının karelerini topla
                        sumOfDifferences += Math.Abs(difference * difference);
                    }
                    else
                    {
                        // Sum the differences for numbers greater than 67
                        // 67'den büyük olanların farklarını topla
                        sumOfDifferences += difference;
                    }
                }

                // Display the sum of differences.
                // Farkların toplamını göster.
                Console.WriteLine($"********************************************\n||Sum of Differences||\n********************************************");
                Console.WriteLine($"|-->|{sumOfDifferences}|");
                Console.WriteLine("********************************************");
                // Kullanıcının tekrar denemek isteyip istemediğini sormak için bir döngü ekleyin.
                // Add a loop to ask if the user wants to try again.
                while (true)
                {
                    Console.WriteLine("***************************************\n|-----Do you want to try again?-----|\n***************************************\n***************************************\n[1]-->Yes\n[2]-->No\n***************************************");

                    string? userChoice = Console.ReadLine();

                    // Kullanıcının geçerli bir seçenek girmesini sağlar.
                    // Ensure the user enters a valid choice.
                    if (!string.IsNullOrWhiteSpace(userChoice) && !string.IsNullOrEmpty(userChoice))
                    {
                        if (userChoice == "1" || userChoice == "2")
                        {


                            switch (userChoice)
                            {
                                case "1":
                                    break;
                                case "2":
                                    Console.WriteLine("|****See you later :)****|");
                                    return;
                                default:
                                    Console.WriteLine("|/Invalid choice, please enter a valid number./|");
                                    break;
                            }
                            break; // Seçim doğruysa programı sonlandır
                                   //The terminate the program if the choice is correct
                        }
                        else
                        {
                            // Geçerli bir seçenek girilmediyse hata mesajı gösterin.
                            // Display an error message if a valid choice is not entered.
                            Console.WriteLine("|/Invalid choice, please enter a valid number./|");

                        }
                    }
                    else
                    {
                        // Geçerli bir seçenek girilmediyse hata mesajı gösterin.
                        // Display an error message if a valid choice is not entered.
                        Console.WriteLine("|/Invalid choice, please enter a valid number./|");
                    }
                }
            }
        }
    }
}
