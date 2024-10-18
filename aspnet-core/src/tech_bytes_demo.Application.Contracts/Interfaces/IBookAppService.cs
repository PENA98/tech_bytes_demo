using System;
using tech_bytes_demo.Dtos.Books;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace tech_bytes_demo.Interfaces;

public interface IBookAppService : ICrudAppService
<BookResponse,
    Guid,
    PagedAndSortedResultRequestDto,
    CreateUpdateBookRequest>
{

}
