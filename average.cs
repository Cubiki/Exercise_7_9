using System;

public class Average
{
    public static void Main()
    {
        double sum = 0, number, divider = 0, average;
        string dateEntered;
        
        Console.Write("Insert a mark: ");
        dateEntered = Console.ReadLine();
        
        while (dateEntered != "end")
        {
            number = Convert.ToDouble(dateEntered);
            divider++;   
            sum += number; 
             
            Console.Write("Insert a mark: ");
            dateEntered = Console.ReadLine();
        }
        if(divider!=0)
        {
            average= sum / divider;
              
            Console.WriteLine("The average is {0}.",average);
        }
    }
}
