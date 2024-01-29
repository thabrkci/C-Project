namespace WritingReverse;

class Program
{
    static void Main(string[] args)
    {
        do
        {
            // Başlık ve giriş bilgilerini ekrana yazdırır.
            // Display a welcome message and prompt for user input.
            Console.WriteLine("------------------\n|/CharacterChance/|\n------------------");
            Console.WriteLine(" ");
            Console.Write("*************************\n|Please Enter Any Word|\n*************************\n|----->");
            // Kullanıcıdan giriş alınır.
            // Receive input from the user.
            string? userInput;
            do
            {
                userInput = Console.ReadLine();
                // Kullanıcının girişin geçerli olup olmadığını kontrol eder.
                // Check if the user input is valid.
                if (ControlNull.ControlString(userInput))
                {
                    // Girişi onay mesajı ile gösterir.
                    // Display a confirmation message with the entered word.
                    Console.WriteLine($"*************************\n||Thank you! The word you entered: {userInput}||\n*************************");
                    break;
                }
                else
                {
                    // Geçersiz giriş için hata mesajı gösterir ve tekrar isteği yapar.
                    // Display an error message for invalid input and prompt again.
                    Console.WriteLine("||Invalid word! Please Try Again!||");
                    Console.Write("*************************\n||Please Enter Any Word||----->\n*************************");
                }

            } while (true);
            // Karakterleri yer değiştiren Swap metodunu kullanarak çıktı oluşturulur.
            // Generate the output by swapping characters using the Swap method.
            string output = Swap.SwapFirstAndLastCharacters(userInput);
            Console.WriteLine($"***************************\n||After the relocation: {output} \n***************************");
            //We ask the user a question to take action again
            //Kullanıcıya tekrar işlem yapması için soru soruyoruz
            Console.WriteLine("----------------------------\n||Do you want to try again or exit ? |Y/N|\n----------------------------");
            string? userChoice = Console.ReadLine();
            if (userChoice.ToUpper() != "Y")
            {
                Console.WriteLine("-----------------\n||See you later||\n-----------------");
                break;
            }
        } while (true);
    }
}
// controlNull sınıfı, girişin null, boş veya sadece harflerden oluşup oluşmadığını kontrol eder.
// ControlNull class checks if the input string is null, empty, or consists only of letters.
public class ControlNull
{
    // Giriş dizesinin null, boş veya sadece harflerden oluşup oluşmadığını kontrol eden metot.
    // Check if the input string is null, empty, or consists only of letters.
    public static bool ControlString(string input)
    {
        return !string.IsNullOrWhiteSpace(input) && input.All(char.IsLetter);
    }
}

public class Swap
{
    // Giriş dizesindeki sadece ilk ve son karakterleri değiştirir.
    // Swap only the first and last characters in the input string.
    public static string SwapFirstAndLastCharacters(string input)
    {
        // Convert the input string to a character array to make it mutable.
        // Giriş dizesini değiştirilebilir yapmak için karakter dizisine çevirir.
        char[] charArray = input.ToCharArray();
        // Sadece birinci ve sonuncu karakterleri değiştirir.
        // Replaces only the first and last characters.
        if (charArray.Length >= 2)
        {
            char temp = charArray[0];
            charArray[0] = charArray[charArray.Length - 1];
            charArray[charArray.Length - 1] = temp;

        }
        // Convert the character array back to a string and return the result.
        // Karakter dizisini tekrar bir dizeye çevirir ve sonucu döndürür.
        return new string(charArray);
    }
}