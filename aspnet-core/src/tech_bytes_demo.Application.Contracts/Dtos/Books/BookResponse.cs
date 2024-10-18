using System;
using Volo.Abp.Application.Dtos;

namespace tech_bytes_demo.Dtos.Books;

public class BookResponse : AuditedEntityDto<Guid>
{
    public required string Title { get; set; }
    public required string Author { get; set; }
    public required string ISBN { get; set; }
    public DateTime? PublishedDate { get; set; }
    public int? Pages { get; set; }
}
