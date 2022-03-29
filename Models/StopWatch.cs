public static class StopWatch
{
    const int MULTIPLIER = 60;
    const int CURRENTTIME = 0;

    public static void Menu()
    {
        Console.WriteLine("Input how many you want count:");
        string? input = Console.ReadLine();

        string timeType = input.Substring(input.Length - 1);
        int time = int.Parse(input.Substring(0, input.Length - 1));

        PreStart();

        Start(timeType, time);

        Console.Clear();

        Console.WriteLine("Stopwatch finished.");

    }

    public static void PreStart()
    {
        Console.Clear();
        Console.WriteLine("Ready...");
        Thread.Sleep(1000);
        Console.Clear();
        Console.WriteLine("Set...");
        Thread.Sleep(1000);
        Console.Clear();
        Console.WriteLine("Go...");
        Thread.Sleep(1000);
        Console.Clear();
    }
    public static void Start(string type, int time)
    {
        if (type.ToUpper() == "S")
        {
            Timer(time);
        }

        if (type.ToUpper() == "M")
        {
            Timer(time * MULTIPLIER);
        }

        else
        {
            Console.WriteLine("Invalid input.");
        }
    }

    public static void Timer(int time)
    {
        if (time < 60)
        {
            for (int i = CURRENTTIME; i <= time; i++)
            {
                Console.Clear();
                Console.WriteLine("0" + ":" + i);
                Thread.Sleep(1000);
            }
        }

        else
        {
            var minute = time / MULTIPLIER;

            for (int j = CURRENTTIME; j <= minute; j++)
            {
                for (int i = CURRENTTIME; i < MULTIPLIER; i++)
                {
                    Console.Clear();
                    Console.WriteLine(j + ":" + i);
                    Thread.Sleep(1000);
                }
            }
        }
    }

}