using Microsoft.AspNetCore.Mvc;
using Mission11.Models;
using Mission11.Models.ViewModels;
using System.Diagnostics;

namespace Mission11.Controllers
{
    public class HomeController : Controller
    {
        private IBookstoreRepository _repo; 

        public HomeController(IBookstoreRepository temp)
        {
            _repo = temp;
        }

        public IActionResult Index(int pageNum)
        {
            int pageSize = 10;

            var blah = new BooksListViewModel
            {
                Books = _repo.Books
                    .OrderBy(x => x.Title)
                    .Take((pageNum - 1) * pageSize), //figure out this take issue. it is displaying all 14 movies and not separating them on separate pages

                PaginationInfo = new PaginationInfo
                {
                    CurrentPage = pageNum,
                    ItemsPerPage = pageSize,
                    TotalItems = _repo.Books.Count()
                }
            };
          

      
            return View(blah);
        }

    }
}
