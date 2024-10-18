using System;
using tech_bytes_demo.Dtos.Books;
using tech_bytes_demo.Entities;
using tech_bytes_demo.Interfaces;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace tech_bytes_demo.Services;

public class BookAppService : CrudAppService<
                Book,
                BookResponse,
                Guid,
                PagedAndSortedResultRequestDto,
                CreateUpdateBookRequest>, IBookAppService
{
    public BookAppService(IRepository<Book, Guid> repository) : base(repository)
    {
    }
}
