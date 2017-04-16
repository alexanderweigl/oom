using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            var tasks = new List<Task<double>>();

            var source = new Subject<SensorCube>();

             source.Sample(TimeSpan.FromMilliseconds(250)).Subscribe(x => Console.WriteLine($"{x.Type}: {x.Value}"));

            source.Subscribe(x =>
            {
                var task = Task.Run(() =>
                {
                    return x.Value;
                });
                tasks.Add(task);
            });

             source.Sample(TimeSpan.FromMilliseconds(250)).Subscribe(x =>
             {
                 if (x.Type == Sensor.Speed)
                     if(Warning(x,250))
                         Console.WriteLine("Speed Warning!");

             });

             source.Sample(TimeSpan.FromMilliseconds(250)).Subscribe(x =>
             {
                 if (x.Type == Sensor.Temperature)
                     if (!Warning(x, 7))
                         Console.WriteLine("Slippery Ice!");

             });

             var speed = new Thread(() =>
             {
                 while (true)
                 {
                     source.OnNext(new SensorCube(Sensor.Speed));
                 }
             });

             var temperature = new Thread(() =>
             {
                 while (true)
                 {
                     source.OnNext(new SensorCube(Sensor.Temperature));
                 }
             });

             speed.Start();
             temperature.Start();

            var tasks2 = new List<Task<double>>();
            foreach (var task in tasks.ToArray())
            {
                tasks2.Add(
                    task.ContinueWith(t => { Console.WriteLine($"result is {t.Result}"); return t.Result; })
                );
            }

        }

        public static bool Warning(SensorCube sensor, int warning)
        {
            if (sensor.Value > warning)
                return true;

            return false;
        }
        

        public static IEnumerable<SensorCube> SensorData()
        {
            while (true)
            {
                Thread.Sleep(1000);
        
                if (StaticRandom.Rand()%2 == 0)
                    yield return new SensorCube(Sensor.Speed);
                else
                    yield return new SensorCube(Sensor.Temperature);
            }
        }
    }
}
