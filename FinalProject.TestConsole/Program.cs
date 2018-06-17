using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace FinalProject.TestConsole
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Task<int> task = Task.Run((Func<int>) Action);
//            task.Wait();
            Console.WriteLine(task.Result);

            Console.WriteLine(1000);
            return;
            
            Game.Instance.Started += InstanceOnStarted;
            Game.Instance.HorseSelecting += InstanceOnHorseSelecting;  
            Game.Instance.HorseMoved += InstanceOnHorseMoved;
		
            Game.Instance.Run();
            
//            Game.Instance.MoveHorse();
        }

        private static int Action()
        {
            Thread.Sleep(1000);
            return 4;
        }

        private static void InstanceOnHorseMoved(object sender, Game.HorseMovedEventArgs e)
        {
            switch (e.Point.Type)
            {
            }
        }

        private static void InstanceOnHorseSelecting(object sender, Game.HorseSelectingEventArgs e)
        {
            Console.WriteLine("select horse");
            
//            Game.Instance.MoveHorse(HorseType.Defensive);
        }

        private static void InstanceOnStarted(object sender, Game.StartedEventArgs e)
        {
            Console.WriteLine("started");
        }
    }
}