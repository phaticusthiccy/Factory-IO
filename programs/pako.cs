using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        boolean boolin0, boolin1, boolout0, boolout1, boolout2, boolout3, boolout4, boolout14, boolout15;
        
        boolin0 = (boolean) readValue();
        boolin1 = (boolean) readValue();
        boolout0 = (boolean) readValue();
        boolout1 = (boolean) readValue();
        boolout2 = (boolean) readValue();
        boolout3 = (boolean) readValue();
        boolout4 = (boolean) readValue();
        boolout14 = (boolean) readValue();
        boolout15 = (boolean) readValue();
        if (boolin1)
        {
            Console.WriteLine("Stopped");
            do
            {
                Reset();
            }
            while (boolin1);
        }
        else
        {
            boolin0 = true;
            Console.WriteLine("Running");
            while (true)
            {
                boolin1 = (boolean) readValue();
                while (!boolin1)
                {
                    Console.WriteLine("Stopped");
                    do
                    {
                        Reset();
                    }
                    while (boolin1);
                }
            }
        }
    }
    
    public static boolean Reset()
    {
        Reset();
        
        return ;
    }

    private static double readValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result));
        return result;
    }
}
