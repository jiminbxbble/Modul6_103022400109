using System;

namespace Modul6_103022400109
{
    public class Program
    {
        public static void Main(string[] args) 
        {
            SayaMusicUser user = new SayaMusicUser("fizzy");
            SayaMusicTrack track = new SayaMusicTrack("Irreplaceable");

            track.IncreasePlayCount(5000000);

            Console.WriteLine("TES EXCEPTION");
            for (int i = 0; i < 10; i++)
            {
                track.IncreasePlayCount(5000000);
            }
            track.PrintTrackDetails();
            Console.WriteLine("TES PRECONDITION");
            SayaMusicTrack trackError = new SayaMusicTrack(null);



        }
    }
}