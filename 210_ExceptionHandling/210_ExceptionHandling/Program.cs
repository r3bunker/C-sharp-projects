using System;



class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Pick a number");
            int numOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pick a second number");
            int numTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dividing the two...");
            int numThree = numOne / numTwo;
            Console.WriteLine(numThree);
            Console.ReadLine();
        }
        catch(FormatException ex)
        {
            Console.WriteLine("Please type a whole number");          
        }
        catch(DivideByZeroException ex)
        {
            Console.WriteLine("Can't divide by zero");
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {          
            Console.ReadLine();
        }

    }
}
