using System;
using System.Collections.Generic;
using System.Text;

using DataPersistence.Sqlite.Models;

namespace DataPersistence.Sqlite.Database
{
    public interface IMovieRepository
    {
        /// <summary>
        /// Get all movies.
        /// </summary>
        /// <returns></returns>
        List<Movie> GetAllMovies();

        /// <summary>
        /// Get movie.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Movie GetMovie(long id);

        /// <summary>
        /// Add movie.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        bool AddMovie(Movie item);

        /// <summary>
        /// Add movies.
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        bool AddMovies(List<Movie> items);

        /// <summary>
        /// Update movie.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        bool UpdateMovie(Movie item);

        /// <summary>
        /// Delete movie.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        bool DeleteMovie(Movie item);
    }
}
