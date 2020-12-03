using System;
using System.Collections.Generic;
using System.Text;

using SQLite;

using DataPersistence.Sqlite.Database.Private;
using DataPersistence.Sqlite.Models;
using System.Linq;
using System.Diagnostics;

namespace DataPersistence.Sqlite.Database
{
    public class MovieRepository : IMovieRepository
    {
        #region Properties

        #region - Interfaces

        private readonly IDatabaseAccess _databaseAccess;

        #endregion - Interfaces

        #region - SQLite Properties

        private SQLiteConnection _connection;

        #endregion - SQLite Properties

        #region - Class Properties

        private string _className;

        #endregion - Class Properties

        #endregion Properties

        public MovieRepository()
        {
            _className = this.GetType().Name;

            _databaseAccess = new DatabaseAccess();
            _connection = _databaseAccess.GetConnection();

            _connection.CreateTable<Movie>();
        }

        #region Methods

        #region - Interface Methods

        /// <summary>
        /// Get all movies.
        /// </summary>
        /// <returns></returns>
        public List<Movie> GetAllMovies()
        {
            try
            {
                return (from t in _connection.Table<Movie>()
                        select t).ToList();
            }
            catch (Exception ex)
            {
                PrintException("GetAllMovies", ex);
                return null;
            }
        }

        /// <summary>
        /// Get movie.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Movie GetMovie(long id)
        {
            try
            {
                return (from t in _connection.Table<Movie>()
                        select t).ToList().Where(ci => ci.Id == id).First();
            }
            catch (Exception ex)
            {
                PrintException("GetMovie", ex);
                return null;
            }
        }

        /// <summary>
        /// Add movie.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool AddMovie(Movie item)
        {
            try
            {
                _connection.Insert(item);

                return true;
            }
            catch (Exception ex)
            {
                PrintException("AddMovie", ex);
                return false;
            }
        }

        /// <summary>
        /// Add movies.
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public bool AddMovies(List<Movie> items)
        {
            try
            {
                foreach (Movie item in items)
                {
                    _connection.Insert(item);
                }

                return true;
            }
            catch (Exception ex)
            {
                PrintException("AddMovies", ex);
                return false;
            }
        }

        /// <summary>
        /// Update movie.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool UpdateMovie(Movie item)
        {
            try
            {
                _connection.Update(item);

                return true;
            }
            catch (Exception ex)
            {
                PrintException("UpdateMovie", ex);
                return false;
            }
        }

        /// <summary>
        /// Delete movie.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool DeleteMovie(Movie item)
        {
            try
            {
                _connection.Delete(item);

                return true;
            }
            catch (Exception ex)
            {
                PrintException("DeleteMovie", ex);
                return false;
            }
        }

        #endregion - Interface Methods

        #region - Helper Methods

        private void PrintException(string methodName, Exception ex)
        {
            Debug.WriteLine($"{_className} - {methodName} - Error: {ex.Message}");
        }

        #endregion - Helper Methods

        #endregion Methods
    }
}