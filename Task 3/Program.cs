namespace Task_3;

class Program
{
    static void Main(string[] args)
    {
        byte Byte = 20;
        short Short = 22500;
        int Int = 42;
        long Long = 684125120;
        float Float = 3.14f;
        double Double = 3.14655656581;
        decimal Decimal = 3.1542154488m;
        char Char = 'A';
        bool Bool = true;
        
        //converting the integer value to string
        String Integer = Int.ToString();
        
        //converting string value into double and storing in a new variable
        double String = Double.Parse("3.14");
        
        
        //printing the variable and their types
        Console.WriteLine("Byte"+Byte);
        Console.WriteLine("Short"+Short);
        Console.WriteLine("Int"+Int);
        Console.WriteLine("Long"+Long);
        Console.WriteLine("float"+Float);
        Console.WriteLine("Double"+Double);
        Console.WriteLine("Decimal"+Decimal);
        Console.WriteLine("Char"+Char);
        Console.WriteLine("Bool"+Bool);
    }
}