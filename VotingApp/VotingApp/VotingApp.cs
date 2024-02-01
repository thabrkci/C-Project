using System.Security.Cryptography.X509Certificates;
using System;
using System.Collections.Generic;
using System.Xml.XPath;

namespace VotingApp
{
    // Bu sınıf, bir oy kullanma uygulamasını temsil eder.
    // This class represents a voting application.
    public class VotingApp
    {
        // Kayıtlı kullanıcıları içeren sözlük.
        // A dictionary containing registered users.
        private Dictionary<string, User> registeredUser { get; set; }

        // Oy uygulaması başlatıldığında yapılacak ilk işlemleri gerçekleştiren constructor.
        // Constructor that performs initial operations when the voting application is started.
        public VotingApp()
        {
            registeredUser = new Dictionary<string, User>();
        }

        // Oy kategorilerini içeren bir liste döndüren metot.
        // Method that returns a list containing voting categories.
        public List<Category> GetCategories()
        {
            return new List<Category> { Category.Film, Category.Life, Category.Spor, Category.Technology };
        }

        // Kullanıcıdan oy isteyen ve alınan cevaba göre true veya false döndüren metot.
        // Method that asks the user for a vote and returns true or false based on the response.
        private bool AskForVote(User user, Category category)
        {
            Console.WriteLine($"|<<>>|[{user.userName}] Do you want to vote for the category {category}?|<<>>|\n|<<>>|Please Enter [Yes] or [No]||<<>>|");
            string? input = Console.ReadLine().ToLower();
            return input == "yes";
        }

        // Oy sonuçlarını hesaplayan metot.
        // Method that calculates the voting results.
        private VotingResult CalculateResults()
        {
            VotingResult votingResult = new VotingResult();
            foreach (var user in registeredUser.Values)
            {
                foreach (var category in GetCategories())
                {
                    if (AskForVote(user, category))
                    {
                        votingResult.TotalVotes++;
                        if (!votingResult.CategoryVotes.ContainsKey(category))
                        {
                            votingResult.CategoryVotes.Add(category, 1);
                        }
                        else
                        {
                            votingResult.CategoryVotes[category]++;
                        }
                    }
                }
            }
            return votingResult;
        }

        // Oy kullanma işlemini başlatan metot.
        // Method that initiates the voting process.
        public void StartVoting()
        {
            Console.WriteLine("-----------\n|Started the voting|\n-----------");

            // Kullanıcı adını al.
            // Get the username.
            string enterUserName = AskForUsername();

            // Eğer kullanıcı kayıtlı değilse, kayıt yap veya ana menüye geri dön.
            // If the user is not registered, either register or return to the main menu.
            if (!registeredUser.ContainsKey(enterUserName))
            {
                Console.WriteLine($"||Mr. or Mrs. {enterUserName} this person is not registered. Would you like to register?\nPlease Enter [Yes] or [No]||");
                string? yesOrNo = Console.ReadLine().ToLower();
                if (yesOrNo == "yes")
                {
                    RegisterUser(enterUserName);
                }
                else
                {
                    Console.WriteLine($"||Mr. or Mrs. {enterUserName} you are redirected to the main menu||");
                    return;
                }
            }

            // Kayıtlı kullanıcı ise oy kullanma işlemlerini gerçekleştir.
            // If the user is registered, perform the voting process.
            Console.WriteLine($"||Mr. Or Mrs. {enterUserName} do you want the voting to start?||\n||Please Enter [Yes] or [No]||");
            string? userEnterVoting = Console.ReadLine().ToLower();
            if (userEnterVoting == "yes")
            {
                foreach (var category in GetCategories())
                {
                    Console.WriteLine($"Category: {category}");

                    if (AskForVote(registeredUser[enterUserName], category))
                    {
                        Console.WriteLine($"|<<>>|Mr or Mrs. {enterUserName} is voted!|<<>>|");
                    }
                    else
                    {
                        Console.WriteLine($"|<<>>|Mr or Mrs. {enterUserName} did not vote|<<>>|");
                    }
                }
                DisplayVotingResults();
            }
            else
            {
                Console.WriteLine($"||Mr. or Mrs. {enterUserName} you are redirected to the main menu||");
                return;
            }
        }

        // Kullanıcıdan bir kullanıcı adı isteyen metot.
        // Method that asks the user for a username.
        private string AskForUsername()
        {
            Console.Write("Username : ");
            return Console.ReadLine();
        }

        // Oy sonuçlarını görüntüleyen metot.
        // Method that displays the voting results.
        public void DisplayVotingResults()
        {
            VotingResult result = CalculateResults();
            Console.WriteLine("<|Voting results|>");
            foreach (var category in result.CategoryVotes)
            {
                double percentage = (double)category.Value / result.TotalVotes * 100;
                Console.WriteLine($"{category.Key}: {category.Value} voting ({percentage:F2}%)");
            }
            Console.WriteLine($"|Total Voting|: {result.TotalVotes}");
        }

        // Kullanıcıyı kayıt eden metot.
        // Method that registers the user.
        public void RegisterUser(string username)
        {
            Console.WriteLine($"----------------------\nMr or Mrs. <|{username}|> do you want your username to be registered?\n----------------------");
            string? userInputSave = Console.ReadLine().ToLower();
            if (userInputSave == "yes")
            {
                if (!registeredUser.ContainsKey(username))
                {
                    registeredUser.Add(username, new User(username));
                    Console.WriteLine($"|<>|Mr or Mrs. {username} your username has been registered.|<>|");
                }
                else
                {
                    Console.WriteLine($"|<>|Mr or Mrs. {username} is already registered|<>|");
                }
            }
            else
            {
                Console.WriteLine($"||Mr. or Mrs. {username} you are redirected to the main menu||");
                return;
            }
        }
    }
}
