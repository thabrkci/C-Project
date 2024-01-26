using System;

namespace Circle
{
    class DrawCircle
    {
        public static void Main(string[] args)
        {
            // Başlık yazdırma - Print the title
            Console.WriteLine("-------------------------\n---> Draw A Circle <---\n-------------------------");

            // Kullanıcıdan yarıçap girişi isteme - Ask for the radius input from the user
            Console.WriteLine("-------------------------------------------------------------------------\n<--| Please enter the radius of the circle you want to draw |--> \n-------------------------------------------------------------------------");
            Console.Write("|---->: ");

            // Kullanıcının girişini kontrol etme - Check the user's input
            int userInput;
            while (!int.TryParse(Console.ReadLine(), out userInput) || userInput <= 0)
            {
                Console.WriteLine("<><> Invalid Value ! Please enter valid value. <><>");
                Console.Write("|---->: ");
            }

            // Girilen yarıçap ile bir daire çizildiğini kullanıcıya bildirme - Inform the user that a circle with the entered radius is drawn
            Console.WriteLine($"||| The circle with radius {userInput} that you entered is drawn |||");

            // DrawingCircle sınıfındaki DrawedCircle metodu çağrılıyor - Calling the DrawedCircle method in the DrawingCircle class
            DrawingCircle.DrawedCircle(userInput);
        }
    }

    public class DrawingCircle
    {
        // DrawedCircle metodu, kullanıcının girdiği yarıçapa göre bir daire çizer - The DrawedCircle method draws a circle based on the user's entered radius
        public static void DrawedCircle(int Draw)
        {
            for (int i = -Draw; i <= Draw; i++)
            {
                for (int j = -Draw; j <= Draw; j++)
                {
                    // Belirli bir konumun dairenin içinde olup olmadığını kontrol etme - Check if a specific position is inside the circle
                    if (i * i + j * j <= Draw * Draw)
                    {
                        // Eğer konum dairenin içindeyse yıldız yazdırma - Print an asterisk if the position is inside the circle
                        Console.Write("*");
                    }
                    else
                    {
                        // Eğer konum dairenin dışındaysa boşluk yazdırma - Print a space if the position is outside the circle
                        Console.Write(" ");
                    }
                }
                // Her satırın sonunda bir sonraki satıra geçme - Move to the next line at the end of each row
                Console.WriteLine();
            }
        }
    }
}





