using System;
using System.Diagnostics;

namespace FinalProject.TestConsole
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Game.Instance.Started += InstanceOnStarted;
            Game.Instance.HorseSelecting += InstanceOnHorseSelecting;  
            Game.Instance.HorseMoved += InstanceOnHorseMoved;
		
            Game.Instance.Run();
            
//            Game.Instance.MoveHorse();
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
            
            Game.Instance.MoveHorse(HorseType.Defensive);
        }

        private static void InstanceOnStarted(object sender, Game.StartedEventArgs e)
        {
            Console.WriteLine("started");
        }
    }
}