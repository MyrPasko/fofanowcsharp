using System;

namespace E_Features
{
    public class Car
    {
        private int speed = 0;

        public delegate void TooFast(int speed);

        private TooFast tooFast;

        public void Start()
        {
            speed = 10;
        }

        public void Accelerate()
        {
            speed += 10;
            if (speed > 30)
            {
                tooFast(speed);
            }
        }

        public void Stop()
        {
            speed = 0;
        }

        public void RegisterOnTooFast(TooFast tooFast)
        {
            this.tooFast = tooFast;
        }
    }
    
    class Program
    {
        private static Car car;
        static void Main(string[] args)
        { 
            car = new Car();
            car.RegisterOnTooFast(HandleOnTooFast);
            
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