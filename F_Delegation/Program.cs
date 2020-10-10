using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Threading.Channels;
using System.Timers;

namespace F_Delegation
{
    class Program
    {
        private static Car car;


        static void Main(string[] args)
        {
            // DisplayLargestFilesWithoutLinq(@"C:\personal");
            // DisplayLargestFilesWithLinq(@"C:\personal");
            
            MinMaxSumAverage(@"C:\test_projects\dot-net\fofanov\FofanovTestProject\F_Delegation\Top100ChessPlayers.csv");
        }

        static void MinMaxSumAverage(string file)
        {
            List<ChessPlayer> list = File.ReadAllLines(file)
                .Skip(1)
                .Select(x => ChessPlayer.ParseFideCsv(x))
                .Where(player => player.BirthYear < 1988)
                .OrderByDescending(p => p.Rating)
                .Take(10)
                .ToList();

            Console.WriteLine($"The lowest rating in TOP 10 is: {list.Min(p => p.Rating)}");
            Console.WriteLine($"The highest rating in TOP 10 is: {list.Max(p => p.Rating)}");
            Console.WriteLine($"The average rating in TOP 10 is: {list.Average(p => p.Rating)}");
        }

        private static void DisplayLargestFilesWithLinq(string pathToDir)
        {
            new DirectoryInfo(pathToDir)
                .GetFiles()
                // .OrderBy(KeySelector)
                .OrderByDescending(file => file.Length)
                .Take(5)
                .ForEach(file => Console.WriteLine($"{file.Name} weights {file.Length}"));
        }

        private static void DisplayLargestFilesWithoutLinq(string pathToDir)
        {
            var dirInfo = new DirectoryInfo(pathToDir);
            FileInfo[] files = dirInfo.GetFiles();

            Array.Sort(files, FilesComparison);

            for (int i = 0; i < 4; i++)
            {
                FileInfo file = files[i];
                Console.WriteLine($"{file.FullName} weights {file.Length}");
            }
        }


        static long KeySelector(FileInfo file)
        {
            return file.Length;
        }

        static int FilesComparison(FileInfo x, FileInfo y)
        {
            if (x.Length == y.Length)
                return 0;

            if (x.Length > y.Length)
                return -1;

            return 1;
        }

        public class Car
        {
            private int speed = 0;

            // public delegate void TooFast(int speed);
            //
            // private TooFast tooFast;

            // public event TooFast TooFastDriving;
            public Action<int> TooFastDriving;
            // public delegate void TooFast(int speed);

            public void Start()
            {
                speed = 10;
            }

            public void Accelerate()
            {
                speed += 10;
                if (speed > 30)
                {
                    if (TooFastDriving != null)
                    {
                        TooFastDriving(speed);
                    }
                }
            }

            public void Stop()
            {
                speed = 0;
            }

            // public void RegisterOnTooFast(TooFast tooFast)
            // {
            //     this.tooFast += tooFast;
            // }
            //
            // public void UnregisterOnTooFast(TooFast tooFast)
            // {
            //     this.tooFast -= tooFast;
            // }
        }

        public void Delegation()
        {
            car = new Car();
            car.TooFastDriving += HandleOnTooFast;
            car.TooFastDriving += HandleOnTooFast;

            car.TooFastDriving -= HandleOnTooFast;

            Timer timer = new Timer();
            timer.Elapsed += (sender, eventArgs) => Console.WriteLine($"Sender {sender.GetType()}");

            var interval = 5000;
            timer.Interval = interval;

            timer.Start();

            Console.ReadLine();

            car.Start();

            car.Accelerate();
            car.Accelerate();
            car.Accelerate();
            car.Accelerate();
        }

        static void HandleOnTooFast(int speed)
        {
            Console.WriteLine($"Current speed: {speed}");
            car.Stop();
        }
    }
}