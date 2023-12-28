using AutoMapper;
using Cohorts_Hw4.DataAccess.Context;

namespace Cohorts_Hw4.Api.BookOperations
{
    public class GetByIdQuery
    {
        public int Id { get; set; }


        private readonly BookStoreDbContext _dbContext;
        private readonly IMapper _mapper;
        public GetByIdQuery(BookStoreDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public BooksViewModel Handle()
        {
            var book = _dbContext.Books.Find(Id);
            if (book == null)
                throw new InvalidOperationException("İlgili id ile bir kitap bulunamadı.");

            BooksViewModel vm = _mapper.Map<BooksViewModel>(book);
            return vm;
        }
        public class BooksViewModel
        {
            public string Title { get; set; }
            public int GenreId { get; set; }
            public int PageCount { get; set; }
            public string PublishDate { get; set; }
        }
    }
}
