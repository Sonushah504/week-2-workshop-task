namespace Task_4;

class Program
{
    static void Main(string[] args)
    {
        //creating single dimensional array and storing favroute number
        int[] favNum = { 3,4,5,6,7 };
        
        // Sort the array in ascending order
        Array.Sort(favNum);

        //print each sorted array element
        Console.WriteLine("Sorted Array:");
        for (int i = 0; i < favNum.Length; i++)
        {
            Console.WriteLine(favNum[i]);
        }
        
        // Reverse the sorted array
        Array.Reverse(favNum);
        
        //print each reverse array element
        Console.WriteLine("\nReversed Array:");
        for (int i = 0; i < favNum.Length; i++)
        {
            Console.WriteLine(favNum[i]);
        }
        
        // Find the position of a specific number
        int searchNumber = 5;
        int position = Array.IndexOf(favNum, searchNumber);

        Console.WriteLine("\nPosition of " + searchNumber + ": " + position);
    }
}