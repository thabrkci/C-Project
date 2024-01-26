namespace Calculate
{
    class CalculateAvarage
    {
        // Main methodu, kullanıcının sayıları girmesini ve ortalamayı hesaplamayı yönetir.
        // The Main method manages user input of numbers and calculates the average.
        public static void Main(string[] args)
        {
            Console.WriteLine("---|>Calculate Avarage<|---");
            Console.WriteLine("<><>Please Enter A Number<><>");
            int userInput;
            Console.Write("----:>");

            // Kullanıcıdan geçerli bir pozitif tam sayı girişi alınana kadar döngü devam eder.
            // Loop continues until a valid positive integer input is received from the user.
            while (!int.TryParse(Console.ReadLine(), out userInput) || userInput <= 0)
            {
                Console.WriteLine("<><>Try Again!. Please Enter A Number<><>");
                Console.Write("-----:>");
            }

            int[] userInputs = new int[userInput];
            for (var i = 0; i < userInput; i++)
            {
                Console.Write($"|Enter {i + 1}th number|:");

                // Kullanıcıdan geçerli bir pozitif tam sayı girişi alınana kadar döngü devam eder.
                // Loop continues until a valid positive integer input is received from the user.
                while (!int.TryParse(Console.ReadLine(), out userInputs[i]) || userInputs[i] <= 0)
                {
                    Console.WriteLine($"|--Please Enter The Number--|");
                    Console.Write("----:>");
                }
            }

            // Girilen sayıların ortalamasını hesapla ve ekrana yazdır.
            // Calculate the average of entered numbers and print it to the console.
            double average = CalculatingAvarage.Calculating(userInputs);
            Console.WriteLine($"----|>Average Of Entered Numbers: {average} <|----");
        }
    }

    class CalculatingAvarage
    {
        // Verilen bir dizi sayının ortalamasını hesaplar.
        // Calculates the average of a given array of numbers.
        public static double Calculating(int[] Numbers)
        {
            // Eğer dizi boşsa, 0 döndür.
            // If the array is empty, return 0.
            if (Numbers.Length == 0)
                return 0;

            int sum = 0;
            foreach (var number in Numbers)
            {
                // Dizideki her bir sayıyı topla.
                // Sum each number in the array.
                sum += number;
            }

            // Ortalamayı hesapla ve döndür.
            // Calculate and return the average.
            return (double)sum / Numbers.Length;
        }
    }
}
