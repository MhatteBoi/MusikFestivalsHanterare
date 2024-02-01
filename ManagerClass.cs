using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusikFestivalsHanterare
{
    //sätt upp alla metoder som ska finnas
    internal class ManagerClass
    {
        //gör en dynamisk lista av alla sub-classer så man kan lägga till och ta bort
        private List<Artist> artists;
        private List<Schedule> schedules;
        private List<Stage> stages;

        public ManagerClass()
        {
            artists = new List<Artist>();
            schedules = new List<Schedule>();
            stages = new List<Stage>();

        }

        // Artist metoder
        public void AddArtist(string artist)
        {
            artists.Add(new Artist(artist));
        }

        public void RemoveArtist(string artistRemove)
        { 
            // kolla om namnet man anget finns i systemet så man kan ta bort det
            Artist artist = artists.Find(a  => a.Name == artistRemove);
            if (artist != null)
            {
                artists.Remove(artist);
            }
            else
            {
                Console.WriteLine("Kunde inte hitta artist!");
            }
            
        }

        public void AddSongToSetList(string artistName, List<string> songs)
        {
            Artist artist = artists.Find(a => a.Name == artistName);

            if (artist != null)
            {
                artist.Songs.AddRange(songs);
                Console.WriteLine("låtar inlaggda i artistens setlist");
            }
            else
            {
                Console.WriteLine($"kunde inte hitta {artistName}");
            }
        }



        //stage metoder 
        public void AddStageNameAndCap(int cap,string stageName) 
        {
            stages.Add(new Stage(cap ,stageName));

        }

        public void AddArtistToStage(string artistName, string stageName, DateTime startTime)
        {
            //kolla om artist finns och om där finns ledig scen
            Stage stage = stages.Find(s => s.Name == stageName);
            Artist artist = artists.Find(a => a.Name == artistName);

            if(artist != null && stage != null)
            {
                if(stage.Capacity > stage.Schedules.Count)
                {
                    stage.Schedules.Add(new Schedule(artist, stage, startTime));
                    Console.WriteLine($"{artistName} har blivit tillagd i scen: {stageName} och de börjar spela: {startTime}");
                }
                else
                {
                    Console.WriteLine($"{stageName}: scenen är full!");
                }

            }
            else
            {
                Console.WriteLine("artisten eller scenen kunde inte hittas!");
            }
        }
        public void RemoveArtistFromStage(string artistName, string stageName)
        {
            Stage stage = stages.Find(s => s.Name == stageName);
            Artist artist = artists.Find(a => a.Name == artistName);

            if (artist != null && stage != null)
            {
                stage.Artists.Remove(artist);
            }
            else 
            {
                Console.WriteLine("kunde inte hitta artist!");
            }



        }


        //schedule/show metoder
        public void ShowScheduleAll()
        {
            foreach (var stage in stages)
            {
                foreach (var schedule in stage.Schedules)
                {
                    Console.WriteLine($"scen: {schedule.Stage.Name}, Artist: {schedule.Artist.Name}, Tid: {schedule.StartTime}");
                }
            }
        }
        public void ShowStage()
        {
            foreach (var stage in stages) 
            {
                Console.WriteLine($"Scen: {stage.Name} kapacitet: {stage.Capacity}");
            }

        }
        public void ShowArtist()
        {
            int inc = 1;
            foreach (var artist in artists)
            {
                Console.WriteLine($"Artist: {artist.Name}");
                Console.WriteLine("Songs:");
                foreach (var song in artist.Songs)
                {
                    
                    Console.Write($"{inc}: {song} \n");
                    inc++;
                    
                }
                Console.WriteLine("\n");
            }

        }

    }
}
