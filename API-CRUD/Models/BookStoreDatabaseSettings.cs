﻿namespace API_CRUD.Models
{
    public class BookStoreDatabaseSettings
    {
        public string? ConnectionString { get; set; }

        public string? DatabaseName { get; set; }

        public string? BooksCollectionName { get; set; }
    }
}
