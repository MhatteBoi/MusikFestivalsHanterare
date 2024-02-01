using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// artist ska ha namn på artisten och deras låtar de ska spela

namespace MusikFestivalsHanterare
{
    internal class Artist
    {
        public string Name {  get; set; }
        public List<string> Songs {  get; set; }
        public List<Schedule> Schedules { get; set; }

        public Artist(string name)
        {
            Songs = new List<string>();
            this.Name = name; 
            Schedules = new List<Schedule>();
        }
    }
}
