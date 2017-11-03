using System;
using System.Diagnostics;

public class Program
{
	public static void Main()
	{
        //create a new instance of the class Timer
        //create an object  
        Timer myTimer = new Timer();
        bool continueAsking = true;
       
        do
        {
            Console.WriteLine("0 to start, 1 to stop, x to Exit");
            Console.WriteLine("What do you want to do?");

            var input = Console.ReadLine();

            if (input == "0")
            {
                //try catch

                try
                {
                    myTimer.Start();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            if (input == "1")
            {
                myTimer.Stop();
                Console.WriteLine($"The time was {myTimer.StopWatch.Elapsed}");
            }

            if (input == "x")
            {
                //end the program
                continueAsking = false;

            }
        } while (continueAsking == true);

	}
    
}

public class Timer
{
    // define properties
    public bool IsTimerWorking { get; set; }
    public Stopwatch StopWatch { get; set; }



    // define method - this is what the class does

    public void Start()
    {
        if(IsTimerWorking)
        {
            // prevent it from starting again
            throw new InvalidOperationException("You can't do that!");
        }
        else
        {
            // kick off the timer
            StopWatch = Stopwatch.StartNew();

            IsTimerWorking = true;
        }
        

    }

    public void Stop()
    {
        // actually stop the watch

        StopWatch.Stop();

        //toggle the flag back to false
        IsTimerWorking = false;
    }
}
