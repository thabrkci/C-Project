using System.Reflection.Metadata;

namespace Area
{
    class CalculateArea
    {
        public static void Main(string[] args)
        {
            // Kullanıcıya sürekli olarak şekil seçme şansı tanınan bir döngü başlatılır.
            // Start an infinite loop to continuously allow the user to choose a shape.
            while (true)
            {
                // Kullanıcıya programın ana menüsü gösterilir.
                // Display the main menu to the user.
                Console.WriteLine("-------------------------\n|---->Calculate Area<----|\n-------------------------");
                Console.WriteLine("|-------------|Lütfen hesaplamak istediğiniz şekli seçin|-------------|\n|-------------[1]|>Daire\n|-------------[2]|>Üçgen\n|-------------[3]|>Kare\n|-------------[4]|>Dikdörtgen\n|-------------[5]|>Çıkış");
                Console.Write("|-------------|>>>");

                // Kullanıcının girişi alınır.
                // Get user input.
                string userInput = Console.ReadLine();

                // Kullanıcının girişi kontrol edilir. Geçerli bir sayı mı değil mi kontrol edilir.
                // Check if the user input is valid, i.e., a valid number.
                if (controlInput(userInput))
                {
                    // Geçerli bir giriş yapıldığında, kullanıcının seçimine göre ilgili hesaplama sınıfı çağrılır.
                    // If a valid input is made, the appropriate calculation class is called based on the user's choice.
                    switch (userInput)
                    {
                        case "1":
                            CalculateCircle.CalculatingCircle();
                            break;
                        case "2":
                            CalculateTriangle.CalculatingTriangle();
                            break;
                        case "3":
                            CalculateSquare.CalculatingSquare();
                            break;
                        case "4":
                            CalculateRectangle.CalculatingRectangle();
                            break;
                        case "5":
                            // Çıkış seçeneği seçildiğinde program sonlandırılır.
                            // Exit the program when the user chooses the exit option.
                            Console.WriteLine("|------->See You Later :()");
                            return;
                        default:
                            // Geçerli bir seçenek dışında bir giriş yapıldığında kullanıcıya hata mesajı gösterilir.
                            // Display an error message to the user when an invalid option is entered.
                            Console.WriteLine("|------->Lütfen geçerli bir sayı girin ve tekrar deneyin!");
                            break;
                    }
                }
                else
                {
                    // Geçerli bir sayı dışında bir giriş yapıldığında kullanıcıya hata mesajı gösterilir.
                    // Display an error message to the user when an input other than a valid number is entered.
                    Console.WriteLine("|------->Geçersiz giriş, lütfen geçerli bir sayı girin");
                }
            }
        }

        // Kullanıcının girişinin bir sayı olup olmadığını kontrol eden metot.
        // Method to check if the user's input is a number.
        static bool controlInput(string UserInput)
        {
            return int.TryParse(UserInput, out _);
        }

    }
}
