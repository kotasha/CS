using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Composite
{
        public abstract class SongComponent
        {
            //public string getbandname()
            //    {

            //        return string;

            //    }

            public abstract void displayInfo();
            //{ 
            //}
            public abstract void add(SongComponent sc);
            //{

            //}
            public abstract void remove(SongComponent sc);
            //{

            //}

        }
        public class SongGroup : SongComponent
        {
            ArrayList al = new ArrayList();
            string name, description;
            public SongGroup(string name, string description)
            {
                this.name = name;
                this.description = description;
            }
            public override void add(SongComponent sc) { al.Add(sc); }
            public override void remove(SongComponent sc) { al.Remove(sc); }
            public override void displayInfo()
            {
                Console.WriteLine("" + this.name + "" + this.description);
                foreach (SongComponent sc in al)
                    sc.displayInfo();

            }
            //public override add()
            //{
            //}


        }
        public class Song : SongComponent
        {
            //ArrayList al = new ArrayList();
            string songname, songdescription;
            int yearreleased;
            public Song(string name, string description, int yearreleased)
            {
                this.songname = name;
                this.songdescription = description;
                this.yearreleased = yearreleased;
            }
            //public void add(SongComponent sc) { al.Add(sc); }
            //public void remove(SongComponent sc) { al.Remove(sc); }
            public override void add(SongComponent sc) { }
            public override void remove(SongComponent sc) { }
            public override void displayInfo()
            {
                Console.WriteLine("" + this.songname + "" + this.songdescription + "song released in" + this.yearreleased);
                //foreach (SongComponent sc in al)
                //    sc.displayInfo();

            }

        }

        public class DiskJockey
        {
            SongComponent sc;
            public DiskJockey(SongComponent sc)
            {
                this.sc = sc;
            }
            public void getsonglist()
            {
                sc.displayInfo();
            }

        }
    }
