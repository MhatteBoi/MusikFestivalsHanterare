using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusikFestivalsHanterare
{
    internal class Stage
    {
        public string Name { get; set; }
        public int Capacity { get; set; }
        public List<Artist> Artists { get; set; }
        public List<Schedule> Schedules { get; set; }

        public Stage(int cap, string name)
        {
            this.Capacity = cap;
            this.Name = name;
            Artists = new List<Artist>();
            Schedules = new List<Schedule>();
        }


    }
}
