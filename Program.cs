class Program
{
    static void Main(string[] args)
    {
        double inputNumber;
        string inputString;

        while (true) {
            Console.Write("Enter a number or type 'End' to stop: ");
            inputString = Console.ReadLine();

            //Check if user entered 'End'
            if (inputString == "End") {
                break;
            }

            //Parse user input as a number
            if (double.TryParse(inputString, out inputNumber)) {
                Console.WriteLine("You entered: " + inputNumber);
            } else {
                Console.WriteLine("Invalid input");
            }
        }
        Console.WriteLine("Ended");
    }
}