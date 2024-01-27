using System;

// Change sınıfı, uygulamanın ana giriş noktasını içerir.
class Change
{
    // The main entry point of the application.
    public static void Main(string[] args)
    {
        // Başlık ve giriş bilgilerini ekrana yazdırır.
        // Display a welcome message and prompt for user input.
        Console.WriteLine("------------------\n|/CharacterChance/|\n------------------");
        Console.Write("/|Please Enter Any Word|/\n|/|----->");

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
                Console.WriteLine($"|/|Thank you! The word you entered: {userInput} |/|");
                break;
            }
            else
            {
                // Geçersiz giriş için hata mesajı gösterir ve tekrar isteği yapar.
                // Display an error message for invalid input and prompt again.
                Console.WriteLine("||Invalid word! Please Try Again!||");
                Console.Write("/|Please Enter Any Word|/\n|/|----->");
            }
        } while (true);

        // Karakterleri yer değiştiren Swap metodunu kullanarak çıktı oluşturulur.
        // Generate the output by swapping characters using the Swap method.
        string output = Swap.SwapCharacters(userInput);
        Console.WriteLine("||After the relocation: " + output);
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

// Swap sınıfı, karakterleri bir önceki karakterleri ile değiştirir.
// Swap class swaps characters in the input string with their preceding characters.
public class Swap
{
    // Giriş dizesindeki karakterleri bir önceki karakterleri ile değiştirir.
    // Swap characters in the input string with their preceding characters.
    // This method takes a string as input and swaps adjacent characters at even indices with those at odd indices.
    // Bu metod, bir giriş olarak bir dize alır ve çift indislerdeki karakterleri tek indislerdeki karakterlerle değiştirir.
    public static string SwapCharacters(string Input)
    {
        // Convert the input string to a character array to make it mutable.
        // Giriş dizesini değiştirilebilir yapmak için karakter dizisine çevirir.
        char[] charArray = Input.ToCharArray();
        // Iterate through the character array with a step of 2, starting from index 1.
        // İndeks 1'den başlayarak 2'şer adımlarla karakter dizisini döngüye alır.
        for (int i = 1; i < charArray.Length; i += 2)
        {
            // Swap the characters at even and odd indices.
            // Çift ve tek indislerdeki karakterleri değiştirir.
            char temp = charArray[i];
            charArray[i] = charArray[i - 1];
            charArray[i - 1] = temp;
        }
        // Convert the character array back to a string and return the result.
        // Karakter dizisini tekrar bir dizeye çevirir ve sonucu döndürür.
        return new string(charArray);
    }

}
