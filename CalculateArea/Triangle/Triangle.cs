namespace Area
{
    public class CalculateTriangle
    {
        public static void CalculatingTriangle()
        {
            // Kullanıcıdan üçgenin a kenarı uzunluğunu girmesini isteyen bir mesaj gösterilir.
            // Prompt the user to enter the length of side a of the triangle.
            Console.WriteLine("|-------->Enter the length of side a: ");

            // Kullanıcının girişi alınır ve geçerli bir sayı olup olmadığı kontrol edilir.
            // Get user input for side a and check if it is a valid positive number.
            if (double.TryParse(Console.ReadLine(), out double sideA) && sideA > 0)
            {
                // Kullanıcıdan üçgenin b kenarı uzunluğunu girmesini isteyen bir mesaj gösterilir.
                // Prompt the user to enter the length of side b of the triangle.
                Console.WriteLine("|-------->Enter the length of side b: ");

                // Kullanıcının girişi alınır ve geçerli bir sayı olup olmadığı kontrol edilir.
                // Get user input for side b and check if it is a valid positive number.
                if (double.TryParse(Console.ReadLine(), out double sideB) && sideB > 0)
                {
                    // Kullanıcıdan üçgenin c kenarı uzunluğunu girmesini isteyen bir mesaj gösterilir.
                    // Prompt the user to enter the length of side c of the triangle.
                    Console.WriteLine("|-------->Enter the length of side c: ");

                    // Kullanıcının girişi alınır ve geçerli bir sayı olup olmadığı kontrol edilir.
                    // Get user input for side c and check if it is a valid positive number.
                    if (double.TryParse(Console.ReadLine(), out double sideC) && sideC > 0)
                    {
                        // Üçgenin geçerli olup olmadığı kontrol edilir.
                        // Check if the triangle is valid.
                        if (IsTriangleValid(sideA, sideB, sideC))
                        {
                            // Üçgenin çevresi ve alanı hesaplanır.
                            // Calculate the perimeter and area of the triangle.
                            double perimeter = sideA + sideB + sideC;
                            double s = perimeter / 2;
                            double area = Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));

                            // Sonuçlar kullanıcıya anlaşılır bir şekilde gösterilir.
                            // Display the results to the user in a clear format.
                            Console.WriteLine($"*******************************************************\n|----->Perimeter of the triangle: {perimeter}");
                            Console.WriteLine($"|----->Area of the triangle: {area}\n*******************************************************");
                        }
                        else
                        {
                            // Geçerli bir üçgen oluşturulamadığında hata mesajı gösterilir.
                            // Display an error message when a valid triangle cannot be formed.
                            Console.WriteLine("|----->Invalid triangle sides. The sum of any two sides must be greater than the third side.");
                        }
                    }
                    else
                    {
                        // Geçerli bir c kenarı değeri girilmediğinde hata mesajı gösterilir.
                        // Display an error message when a valid side c value is not entered.
                        Console.WriteLine("|----->Invalid side c value. Please enter a positive number.");
                    }
                }
                else
                {
                    // Geçerli bir b kenarı değeri girilmediğinde hata mesajı gösterilir.
                    // Display an error message when a valid side b value is not entered.
                    Console.WriteLine("|----->Invalid side b value. Please enter a positive number.");
                }
            }
            else
            {
                // Geçerli bir a kenarı değeri girilmediğinde hata mesajı gösterilir.
                // Display an error message when a valid side a value is not entered.
                Console.WriteLine("|----->Invalid side a value. Please enter a positive number.");
            }
        }

        // Üçgenin geçerli olup olmadığını kontrol eden metot.
        // Method to check if the triangle is valid.
        static bool IsTriangleValid(double a, double b, double c)
        {
            return a + b > c && a + c > b && b + c > a;
        }

    }
}
