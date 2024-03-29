﻿namespace Mission11.Models.ViewModels
{
    public class BooksListViewModel
    {
        internal IQueryable<Book> Projects;

        public IQueryable<Book> Books { get; set; }
        public PaginationInfo PaginationInfo { get; set; } = new PaginationInfo();
    }
}
