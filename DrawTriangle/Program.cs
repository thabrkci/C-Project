using System;

namespace Triangle
{
    class DrawTriangle
    {
        public static void Main(string[] args)
        {
            // Displaying program header in the console / Program başlığını konsolda görüntüleme
            Console.WriteLine("-------------------------\n---> |/|Draw Triangle|/| <---\n-------------------------");

            // Prompting the user to enter the radius of the triangle / Kullanıcıdan üçgenin yarıçapını girmesini isteme
            Console.WriteLine("-------------------------------------------------------------------------\n<--| Please enter the radius of the triangle you want to draw |--> \n-------------------------------------------------------------------------");
            Console.Write("|---->: ");

            int userInput;

            // Validating user input to ensure a positive integer is entered
            // Kullanıcının geçerli bir tam sayı girene kadar girişi kontrol etme
            while (!int.TryParse(Console.ReadLine(), out userInput) || userInput <= 0)
            {
                // Displaying an error message for invalid input / Geçersiz giriş için bir hata mesajı görüntüleme
                Console.WriteLine("<><> Invalid Value ! Please enter a valid value. <><>");
                Console.Write("|---->: ");
            }
            Console.WriteLine($"||| The triangle with radius {userInput} that you entered is drawn |||");
            // Drawing the triangle based on the user input / Kullanıcının girdiği değere göre üçgeni çizme
            DrawingTriangle.DrawWithUserInput(userInput);
        }
    }

    public class DrawingTriangle
    {
        public static void DrawWithUserInput(int userInput)
        {
            // Creating each row of the triangle / Üçgenin her satırını oluşturma
            for (int i = 1; i <= userInput; i++)
            {
                // Printing spaces for left indentation / Sol girinti için boşluk yazdırma
                for (int j = 1; j <= userInput - i; j++)
                {
                    Console.Write(" ");
                }

                // Printing '*' characters for the triangle / Üçgen için '*' karakterlerini yazdırma
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }

                // Moving to the next line for the next row / Bir sonraki satıra geçme
                Console.WriteLine();
            }
        }
    }
}
