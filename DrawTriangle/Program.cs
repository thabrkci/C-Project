namespace Triangle
{
    class DrawTriangle
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("-------------------------\n---> |/|Draw Triangle|/| <---\n-------------------------");
            Console.WriteLine("-------------------------------------------------------------------------\n<--| Please enter the radius of the triangle you want to draw |--> \n-------------------------------------------------------------------------");
            Console.Write("|---->: ");
            int userInput;
            while (!int.TryParse(Console.ReadLine(), out userInput) || userInput <= 0)
            {
                Console.WriteLine("<><> Invalid Value ! Please enter valid value. <><>");
                Console.Write("|---->: ");
            }

        }
    }
}