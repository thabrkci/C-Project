using System;

namespace SumInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                // Integer Toplam programına hoş geldiniz. Hem türkçe hem ingilizce açıklamaları içerir.
                // Welcome to the Integer Sum program. Includes comments in both Turkish and English.
                Console.WriteLine("*******************************\n|-------Integer Sum-------|\n*******************************");

                // Kaç adet sayı çifti girmek istediğinizi belirtin.
                // Specify how many pairs of numbers you want to enter.
                Console.WriteLine("*******************************\n|How many numbers you want to enter|\n*******************************");

                // Kullanıcıdan ikili sayıları girmesini isteyin.
                // Prompt the user to enter the pairs of numbers.
                Console.Write("|----->>>");
                int userInput;

                // Kullanıcının girdiği sayı adedini alır, geçerli bir pozitif sayı olduğunu kontrol eder.
                // Take the user's input for the number of pairs, ensuring it is a valid positive number.
                while (!int.TryParse(Console.ReadLine(), out userInput) || userInput <= 0)
                {
                    // Girilen sayı geçersizse hata mesajı göster.
                    // Display an error message if the entered number is invalid.
                    Console.WriteLine("|----->>>Invalid number. Please enter a valid number.");
                    Console.Write("|----->>>");
                }

                // Kullanıcının gireceği ikili sayıları tutan dizi.
                // Array to store pairs of numbers entered by the user.
                int[] userEnter = new int[userInput * 2];

                //  Kullanıcının ikili sayıları girmesini sağlar.
                //  Allow the user to enter pairs of numbers.
                for (var i = 0; i < userInput * 2; i++)
                {
                    //  Her bir ikili sayı girişini sağlar.
                    //  Prompt for each pair of numbers.
                    Console.Write($"Enter |{i + 1}|th.|----->>>");

                    // Kullanıcının geçerli bir sayı girmesini sağlar.
                    // Ensure the user enters a valid number.
                    while (!int.TryParse(Console.ReadLine(), out userEnter[i]))
                    {
                        //  Girilen sayı geçersizse hata mesajı göster.
                        //  Display an error message if the entered number is invalid.
                        Console.WriteLine("|----->>>Invalid number. Please enter a valid number.");
                        Console.Write("|----->>>");
                    }
                }

                // Toplamı ve koşullara göre işlemleri yapar.
                // Perform calculations based on the sum and conditions.
                for (var i = 0; i < userInput; i++)
                {
                    int sum = userEnter[2 * i] + userEnter[2 * i + 1];

                    //  Sayılar birbirinden farklıysa toplamı yazdırır.
                    //  Display the sum if the numbers are different.
                    if (userEnter[2 * i] != userEnter[2 * i + 1])
                    {
                        Console.Write($"{sum} ");
                    }
                    else
                    {
                        // Türkçe: Sayılar aynıysa toplamın karesini yazdırır.
                        // English: Display the square of the sum if the numbers are the same.
                        Console.Write($"{sum * sum} ");
                        Console.WriteLine(" ");
                    }
                }

                // Kullanıcının tekrar denemek isteyip istemediğini sormak için bir döngü ekleyin.
                // Add a loop to ask if the user wants to try again.
                while (true)
                {
                    Console.WriteLine("***************************************\n|-----Do you want to try again?-----|\n***************************************\n***************************************\n[1]-->Yes\n[2]-->No\n***************************************");

                    string userChoice = Console.ReadLine();

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
