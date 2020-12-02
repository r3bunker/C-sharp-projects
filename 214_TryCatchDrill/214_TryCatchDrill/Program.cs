using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        // Set list
        List<int> divideList = new List<int>() { 20, 40, 60, 80, 100 };


        try
        {
            // Ask user for number
            Console.WriteLine("Enter a number to divide the list by: ");
            int divideNum = Convert.ToInt32(Console.ReadLine());

            // Divide each number in list by user input
            foreach (var i in divideList)
            {
                int total = i / divideNum;
                Console.WriteLine(i + " / " + divideNum + " = " + total);
            }
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Please enter a number.");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Can't divide by zero.");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
        Console.ReadLine();
        }
        
    }
}

