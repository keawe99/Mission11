
namespace Mission11.Models
{
    public class EFBookRespository : IBookstoreRepository
    {
        private BookstoreContext _context;
        public EFBookRespository(BookstoreContext temp) {
            _context = temp;
        }
        public IQueryable<Book> Books => _context.Books;
    }
}
