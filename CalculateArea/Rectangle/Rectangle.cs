namespace Area
{
    public class CalculateRectangle
    {
        public static void CalculatingRectangle()
        {
            // Kullanıcıdan dikdörtgenin uzunluğunu girmesini isteyen bir mesaj gösterilir.
            // Prompt the user to enter the length of the rectangle.
            Console.WriteLine("|------>Enter the length of the rectangle: ");

            // Kullanıcının girişi alınır ve geçerli bir sayı olup olmadığı kontrol edilir.
            // Get user input for length and check if it is a valid positive number.
            if (double.TryParse(Console.ReadLine(), out double length) && length > 0)
            {
                // Kullanıcıdan dikdörtgenin genişliğini girmesini isteyen bir mesaj gösterilir.
                // Prompt the user to enter the width of the rectangle.
                Console.WriteLine("|------>Enter the width of the rectangle: ");

                // Kullanıcının girişi alınır ve geçerli bir sayı olup olmadığı kontrol edilir.
                // Get user input for width and check if it is a valid positive number.
                if (double.TryParse(Console.ReadLine(), out double width) && width > 0)
                {
                    // Dikdörtgenin alanı ve çevresi hesaplanır.
                    // Calculate the area and perimeter of the rectangle.
                    double area = length * width;
                    double perimeter = 2 * (length + width);

                    // Sonuçlar kullanıcıya anlaşılır bir şekilde gösterilir.
                    // Display the results to the user in a clear format.
                    Console.WriteLine($"*******************************************************\nArea of the rectangle: {area}");
                    Console.WriteLine($"Perimeter of the rectangle: {perimeter}\n*******************************************************");
                }
                else
                {
                    // Geçerli bir genişlik değeri girilmediğinde hata mesajı gösterilir.
                    // Display an error message when a valid width value is not entered.
                    Console.WriteLine("|------>Invalid width value. Please enter a positive number.");
                }
            }
            else
            {
                // Geçerli bir uzunluk değeri girilmediğinde hata mesajı gösterilir.
                // Display an error message when a valid length value is not entered.
                Console.WriteLine("|------>Invalid length value. Please enter a positive number.");
            }
        }
    }
}
