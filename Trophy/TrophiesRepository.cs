using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trophy
{
    public class TrophiesRepository
    {
        private List<Trophy> trophies;
        private int nextId; // Holder styr på det næste ledige ID

        public TrophiesRepository()
        {
            trophies = new List<Trophy>
            {
                new Trophy { Id = 1, Competition = "Champions League", Year = 2020 },
                new Trophy { Id = 2, Competition = "Premier League", Year = 2019 },
                new Trophy { Id = 3, Competition = "World Cup", Year = 2018 },
                new Trophy { Id = 4, Competition = "La Liga", Year = 2021 },
                new Trophy { Id = 5, Competition = "Europa League", Year = 2017 }
            };
            nextId = trophies.Max(t => t.Id) + 1; // Sætter næste ID baseret på højeste eksisterende ID
        }

        public List<Trophy> Get(int? year = null, string? sortBy = null)
        {
            //Returnerer en kopi af listen
            var result = new List<Trophy>(trophies);

            //Filtrerer på år
            if (year.HasValue)
            {
                result = result.FindAll(t => t.Year == year);
            }

            //Sorterer listen
            if (!string.IsNullOrEmpty(sortBy))
            {
                //Sortering baseret på Competition
                if (sortBy == "Competition")
                {
                    result.Sort((t1, t2) => t1.Competition.CompareTo(t2.Competition));
                }
                //Sortering baseret på Year
                else if (sortBy == "Year")
                {
                    result.Sort((t1, t2) => t1.Year.CompareTo(t2.Year));
                }
            }
            return result;
        }

        public Trophy? GetById(int id)
        {
            return trophies.Find(t => t.Id == id);
        }

        public Trophy Add(Trophy trophy)
        {
            trophy.Id = nextId++;
            trophies.Add(trophy);
            return trophy;
        }

        public Trophy? Remove(int id)
        {
            var trophy = GetById(id);
            if (trophy != null)
            {
                trophies.Remove(trophy);
            }
            return trophy;
        }

        public Trophy? Update(int id, Trophy trophy)
        {
            var existingTrophy = GetById(id);
            if (existingTrophy != null)
            {
                existingTrophy.Competition = trophy.Competition;
                existingTrophy.Year = trophy.Year;
            }
            return existingTrophy;
        }
    }
}
