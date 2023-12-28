using AutoMapper;
using Cohorts_Hw4.Entities.DbSets;
using Cohorts_Hw4.Entities.Enums;
using static Cohorts_Hw4.Api.BookOperations.GetByIdQuery;
using static Cohorts_Hw4.Api.BookOperations.UpdateBookCommand;

namespace Cohorts_Hw4.Api.Mapping
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Book, BooksViewModel>().ForMember(dest => dest.GenreId, opt => opt.MapFrom(src => (Genre)src.GenreId)).ToString();
            CreateMap<UpdateBookModel, Book>();
        }
    }
}
