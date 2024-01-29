namespace Area
{
    public class CalculateCircle
    {
        public static void CalculatingCircle()
        {
            // Kullanıcıdan dairenin yarıçapını girmesini isteyen bir mesaj gösterilir.
            // Prompt the user to enter the radius of the circle.
            Console.WriteLine("|------------->Enter the radius of the circle");

            // Kullanıcının girişi alınır ve geçerli bir sayı olup olmadığı kontrol edilir.
            // Get user input and check if it is a valid positive number.
            if (double.TryParse(Console.ReadLine(), out double radius) && radius > 0)
            {
                // Dairenin alanı ve çevresi hesaplanır.
                // Calculate the area and perimeter of the circle.
                double area = Math.PI * Math.Pow(radius, 2);
                double perimeter = 2 * Math.PI * radius;

                // Sonuçlar kullanıcıya anlaşılır bir şekilde gösterilir.
                // Display the results to the user in a clear format.
                Console.WriteLine($"*******************************************************\n|------->Area of the circle: {area}");
                Console.WriteLine($"|------->Perimeter of the circle: {perimeter}\n*******************************************************");
            }
            else
            {
                // Geçerli bir yarıçap değeri girilmediğinde hata mesajı gösterilir.
                // Display an error message when a valid radius value is not entered.
                Console.WriteLine($"|------->Invalid radius value. Please enter a valid positive number.");
            }
        }
    }
}
