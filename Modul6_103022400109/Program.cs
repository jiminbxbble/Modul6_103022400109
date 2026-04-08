using System;

namespace Modul6_103022400109
{
    public class Program
    {
        public static void Main(string[] args) 
        {
            SayaMusicUser user = new SayaMusicUser("fizzy");
            SayaMusicTrack track = new SayaMusicTrack("Irreplaceable");
            SayaMusicTrack track2 = new SayaMusicTrack("Hello Future");
            SayaMusicTrack track3 = new SayaMusicTrack("Rainbow");
            SayaMusicTrack track4 = new SayaMusicTrack("Candle Light");
            SayaMusicTrack track5 = new SayaMusicTrack("Be There For U");
            SayaMusicTrack track6 = new SayaMusicTrack("Breathing");
            SayaMusicTrack track7 = new SayaMusicTrack("BOX");
            SayaMusicTrack track8 = new SayaMusicTrack("Poison");
            SayaMusicTrack track9 = new SayaMusicTrack("S.O.S");
            SayaMusicTrack track10 = new SayaMusicTrack("Track 10");
            track.PrintTrackDetails();
            track2.PrintTrackDetails();
            track3.PrintTrackDetails();
            track4.PrintTrackDetails();
            track5.PrintTrackDetails();
            track6.PrintTrackDetails();
            track7.PrintTrackDetails();
            track8.PrintTrackDetails();
            track9.PrintTrackDetails();
            track10.PrintTrackDetails();



        }
    }
}