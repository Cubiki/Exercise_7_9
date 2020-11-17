//Author: JOSE CUBÍ ALBERT

using System;

class digits
{
    static void Main()
    {
        int unit = 0, ten = 0, hundred = 0, thousand = 0;
        
        Console.WriteLine("Insert a number (\"end\" for finish): ");
        string dateEntered = Console.ReadLine();
        
        while(dateEntered != "end")
        {
            int input = Convert.ToInt32(dateEntered);
            
            if(input != 0)
            {
                if(input/10 == 0)
                    unit++;  
                else if (input/100 == 0)
                    ten++; 
                else if (input/1000 == 0)
                    hundred++;  
                else
                    thousand++;  
            }
            dateEntered = Console.ReadLine();
        }

        Console.WriteLine("one: {0} two: {1} three: {2} more: {3}", unit, 
        ten, hundred, thousand); 
    }
}

