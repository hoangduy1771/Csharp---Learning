using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLesson11_StaticAttribute
{
    class Song
    {
        public string title;
        public string artist;
        public int duration;
        public static int songCount = 0;

        public Song(string sTitle, string sArtist, int sDuration)
        {
            title = sTitle;
            artist = sArtist;
            duration = sDuration;
            songCount++;
        }

        public int getSongCount()
        {
            return songCount;
        }

    }
}
