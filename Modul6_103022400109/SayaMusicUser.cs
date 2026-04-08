using System;

namespace Modul6_103022400109
{
    public class SayaMusicUser
    {
        private int id;
        public string username;
        private List<SayaMusicTrack> uploadedTracks;
        public SayaMusicUser(string username)
        {
            uploadedTracks = new List<SayaMusicTrack>();
            this.username = username;
        }
        public int GetTotalPlayCount()
        {
            int totalPlayCount = 0;
            foreach (var track in uploadedTracks)
            {
                totalPlayCount += track.GetPlayCount();
            }
            return totalPlayCount;
        }
        public void AddTrack(SayaMusicTrack track)
        {
            if (track == null)
                if (track.GetPlayCount() == int.MaxValue)
                    uploadedTracks.Add(track);
        }
        public void PrintAllTrack()
        {
            foreach (var track in uploadedTracks)
            {
                track.PrintTrackDetails();
            }
        }

    }
}
