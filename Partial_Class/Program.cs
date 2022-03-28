using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace Partial_Class
{
    //class Worker
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }

    //    static Worker()
    //    {
    //        Console.WriteLine("Static constructor");
    //    }
    //    public Worker()
    //    {
    //        Console.WriteLine("Default Constructor");
    //    }

    //    public Worker(int id, string name)
    //    {
    //        Console.WriteLine("Parametric Constructor");
    //        Id = id;
    //        Name = name;
    //    }

    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Worker wokrer = new Worker();
    //        Worker worker1 = new Worker(1,"Shabnam");
    //        Worker worker2 = new Worker();
            
    //    }
    //}

    class Car
    {
        public int Id { get; set; }
        public static DateTime globalStartTime;
        static Car()
        {
            globalStartTime = DateTime.Now;
            Console.WriteLine($@"Static constructor called
                       Global Start Time: {globalStartTime.ToLongTimeString()}");
        }
        public Car(int id)
        {
            Thread.Sleep(700);
            Id = id;
        }
        public void Drive()
        {
            TimeSpan elapsedTime = DateTime.Now - globalStartTime;

            Console.WriteLine($@"
                Car Id : {Id} is starting its works
                {elapsedTime.Seconds} seconds
                after global start time
                {globalStartTime.ToLongTimeString()}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(1);
            car.Drive();
            Thread.Sleep(1200);
            Car car1 = new Car(7);
            car1.Drive();
        }
    }

}

