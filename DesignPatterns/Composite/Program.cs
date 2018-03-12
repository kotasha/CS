using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            SongComponent sc1 = new SongGroup("SongGroup1", "   RockMusic");
            SongComponent sc2 = new SongGroup("SongGroup2", "   ClassicalMusic");
            SongComponent sc3 = new SongGroup("SongGroup3", "   PopMusic");

            SongComponent Everysong = new SongGroup("Song list ", "EverySong available");
            Everysong.add(sc1);
            sc1.add(new Song("Song1OfSongGroup1", "Rock1", 2013));
            sc1.add(new Song("Song2OfSongGroup1", "Rock2", 2013));
            Everysong.add(sc2);
            sc2.add(new Song("Song1OfSongGroup2", "Classical1", 2013));
            sc2.add(new Song("Song2OfSongGroup2", "Classical2", 2013));
            Everysong.add(sc3);
            sc3.add(new Song("Song1OfSongGroup3", "Pop1", 2013));
            sc3.add(new Song("Song2OfSongGroup3", "Pop2", 2013));

            DiskJockey dj = new DiskJockey(Everysong);
            dj.getsonglist();

            Console.ReadLine();
        }
    }
}
