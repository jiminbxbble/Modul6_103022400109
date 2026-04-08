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
            Debug.Assert(title != null, "Precondition gagal: Judul lagu tidak boleh null");
            Debug.Assert(title.Length <= 100 "Precondition gagal: Judul lagu maksimal 100 karakter");
            
            this.title = title;
            this.playCount = 0;

            Random rnd = new Random();
            this.id = rnd.Next(10000, 999999);
        }
        public void IncreasePlayCount(int count)
        {
            Debug.Assert(count <= 1000000, "Precondition gagal: playcount maksimal 1.000.000");
            try
            {
                checked
                {
                    this.playCount += count;
                }
            }
            catch (OverflowException) 
            {
                Console.WriteLine("Error Exception: Penambahan gagal karena overflow");
            }
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

