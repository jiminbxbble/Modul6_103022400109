using System;
using System.Diagnostics;

namespace Modul6_103022400109
{
    public class SayaMusicTrack
    {
        private int id;
        public string title;
        private int playCount;
        public SayaMusicTrack(string title)
        {
            this.title = title;
            this.playCount = 0;

            Random rnd = new Random();
            this.id = rnd.Next(10000, 999999);
        }
        public void IncreasePlayCount(int count)
        {
            this.playCount += count;
        }
        public void PrintTrackDetails()
        {
            Console.WriteLine($"ID Lagu		: {this.id}");
            Console.WriteLine($"Judul Lagu	: {this.title}");
            Console.WriteLine($"Total Play	: {this.playCount}");
            Console.WriteLine("---------------------------------------");

        }
        public int GetPlayCount()
        {
            return playCount;
        }
    }
}

