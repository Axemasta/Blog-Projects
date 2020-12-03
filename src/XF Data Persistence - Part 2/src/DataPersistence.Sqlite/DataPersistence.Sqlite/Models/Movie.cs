using System;
using System.Collections.Generic;
using System.Text;

using SQLite;

using DataPersistence.Sqlite.Enums;

namespace DataPersistence.Sqlite.Models
{
    public class Movie
    {
        [PrimaryKey]
        [AutoIncrement]
        public long Id { get; set; }

        public Guid? ServerId { get; set; }

        public string Title { get; set; }

        public Genre Genre { get; set; }

        public double Rating { get; set; }

        public string[] Directors { get; set; }

        public DateTime Released { get; set; }       
    }
}
