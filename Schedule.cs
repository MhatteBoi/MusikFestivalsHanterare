using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusikFestivalsHanterare
{
    internal class Schedule
    {
        public Artist Artist { get; set; }
        public Stage Stage { get; set; }
        public DateTime StartTime { get; set; }

        public Schedule(Artist artist, Stage stage, DateTime startTime)
        {
            Artist = artist;
            Stage = stage;
            StartTime = startTime;
        }
    }
}
