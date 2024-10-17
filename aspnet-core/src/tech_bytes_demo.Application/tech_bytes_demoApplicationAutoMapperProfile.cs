using AutoMapper;
using tech_bytes_demo.Dtos.Books;
using tech_bytes_demo.Entities;

namespace tech_bytes_demo;

public class tech_bytes_demoApplicationAutoMapperProfile : Profile
{
    public tech_bytes_demoApplicationAutoMapperProfile()
    {
       CreateMap<Book, BookResponse>();
       CreateMap<CreateUpdateBookRequest, Book>();
    }
}
