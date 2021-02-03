using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IS_413_Assignemnt_3.Models
{
    public static class TempStorageClass
    {
        private static List<MovieResponse> movies = new List<MovieResponse>();

        public static IEnumerable<MovieResponse> Movies => movies;

        public static void AddMovie(MovieResponse movie)
        {
            movies.Add(movie);
        }
    }
}
