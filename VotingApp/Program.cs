namespace VotingApp; // VotingApp namespace'ini kullanıyoruz. (We are using the VotingApp namespace.)

class Program
{
    static void Main(string[] args)
    {
        // VotingApp sınıfından bir nesne oluşturuyoruz.
        // Creating an instance of the VotingApp class.
        VotingApp votingApp = new();

        while (true)
        {
            Console.WriteLine("-----------------------\n||Welcome To Voting App||\n-----------------------");
            Console.WriteLine("----------------------------------------\n||Which action would you like to take?||\n----------------------------------------");
            Console.WriteLine("**********************\n|MENU|\n**********************\n|[1]-Register User\n|[2]-Use Vote\n|[3]-Exit\n**********************");
            Console.Write("|--->");

            // Kullanıcının girişini alıyoruz.
            // Getting user input.
            string? userInput = Console.ReadLine();

            if (userInput == "1" || userInput == "2" || userInput == "3")
            {
                switch (userInput)
                {
                    case "1":
                        // Kullanıcıdan bir kullanıcı adı alıp, VotingApp sınıfındaki RegisterUser metodunu çağırıyoruz.
                        // Getting a username from the user and calling the RegisterUser method in the VotingApp class.
                        Console.WriteLine("|User-Name|>>");
                        string? username = Console.ReadLine();
                        votingApp.RegisterUser(username);
                        break;

                    case "2":
                        // VotingApp sınıfındaki StartVoting metodunu çağırıyoruz.
                        // Calling the StartVoting method in the VotingApp class.
                        votingApp.StartVoting();
                        break;

                    case "3":
                        // Uygulamadan çıkış yapılıyor.
                        // Exiting the application.
                        Console.WriteLine("<>|Thank you. See you later :)|<>");
                        return;
                    default:
                        Console.WriteLine("<|>Invalid choose. Please Try Again<|>");
                        break;
                }
            }
            else
            {
                Console.WriteLine("<|>Invalid choose. Please Try Again<|>");
            }
        }
    }
}
