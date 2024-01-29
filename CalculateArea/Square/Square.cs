namespace Area
{
    public class CalculateSquare
    {
        public static void CalculatingSquare()
        {
            // Kullanıcıdan karenin bir kenar uzunluğunu girmesini isteyen bir mesaj gösterilir.
            // Prompt the user to enter the length of a side of the square.
            Console.WriteLine("|------->Enter the length of a side of the square");

            // Kullanıcının girişi alınır ve geçerli bir sayı olup olmadığı kontrol edilir.
            // Get user input for side length and check if it is a valid positive number.
            if (double.TryParse(Console.ReadLine(), out double sideLength) && sideLength > 0)
            {
                // Karenin alanı ve çevresi hesaplanır.
                // Calculate the area and perimeter of the square.
                double area = Math.Pow(sideLength, 2);
                double perimeter = 4 * sideLength;

                // Sonuçlar kullanıcıya anlaşılır bir şekilde gösterilir.
                // Display the results to the user in a clear format.
                Console.WriteLine($"*******************************************************\n|------->Area of the square: {area}");
                Console.WriteLine($"|------->Perimeter of the square: {perimeter}\n*******************************************************");
            }
            else
            {
                // Geçerli bir kenar uzunluğu değeri girilmediğinde hata mesajı gösterilir.
                // Display an error message when a valid side length value is not entered.
                Console.WriteLine("|------->Invalid side length. Please enter a positive number.");
            }
        }
    }
}
