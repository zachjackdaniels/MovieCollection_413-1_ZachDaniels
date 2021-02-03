using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieCollection_413_1_ZachDaniels.Models
{
    public class TempStorage
    {
        private static List<AddMovie> addMovies = new List<AddMovie>();
        public static IEnumerable<AddMovie> AddMovies => addMovies;

        public static void NewMovies(AddMovie addMovie)
        {
            addMovies.Add(addMovie);
        }
    }
}
