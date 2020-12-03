using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

using System.Linq;

using DataPersistence.Sqlite.Database;
using DataPersistence.Sqlite.Models;

namespace DataPersistence.Sqlite.ViewModels
{
    public class ListPageViewModel : INotifyPropertyChanged
    {
        #region Properties

        #region - Interface Properties

        private readonly IMovieRepository _contentRepository;

        #endregion - Interface Properties

        #region - Class Properties

        ObservableCollection<Movie> _contentItems;
        ObservableCollection<Movie> ContentItems
        {
            get { return _contentItems; }
        }

        #endregion - Class Properties

        #endregion Properties

        public ListPageViewModel()
        {
            _contentRepository = new MovieRepository();

            _contentItems = new ObservableCollection<Movie>(
                _contentRepository
                .GetAllMovies()
                .AsEnumerable());
        }

        #region Methods

        #region - Dummy Data Methods

        private void CreateSampleData()
        {
            if (_contentItems.Count > 0)
                return;

            List<Movie> sampleData = new List<Movie>();

            sampleData.Add(new Movie() { Title = "Rogue One: A Star Wars Story", Directors = new string[] { "Gareth Edwards" }, Rating = 7.8, Released = new DateTime(2016, 12, 16) });
            sampleData.Add(new Movie() { Title = "Titanic", Directors = new string[] { "James Cameron" }, Rating = 7.8, Released = new DateTime(1998, 01, 23) });
            sampleData.Add(new Movie() { Title = "Finding Nemo", Directors = new string[] { "Andrew Stanton", "Lee Unkrich" }, Rating = 8.1, Released = new DateTime(2003, 10, 10) });
            sampleData.Add(new Movie() { Title = "Avatar", Directors = new string[] { "James Cameron" }, Rating = 7.8, Released = new DateTime(2009, 12, 17) });
            sampleData.Add(new Movie() { Title = "Shrek", Directors = new string[] { "Andrew Adamson", "Vicky Jenson" }, Rating = 7.9, Released = new DateTime(2001, 06, 29) });
            sampleData.Add(new Movie() { Title = "Avengers: Infinity War", Directors = new string[] { "Joe Russo", "Antony Russo" }, Rating = 8.6, Released = new DateTime(2018, 04, 26) });
            sampleData.Add(new Movie() { Title = "Mamma Mia!", Directors = new string[] { "Phyllida Lloyd" }, Rating = 6.4, Released = new DateTime(2008, 07, 10) });

            _contentRepository.AddMovies(sampleData);

            _contentItems = new ObservableCollection<Movie>(sampleData.AsEnumerable());

            OnPropertyChanged(nameof(ContentItems));
        }

        #endregion - Dummy Data Methods

        #region - PropertyChanged Methods

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion - PropertyChanged Methods

        #endregion Methods
    }
}
