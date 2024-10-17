using System;
using System.Threading.Tasks;
using tech_bytes_demo.Entities;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace tech_bytes_demo.SeedData;

public class TechByteSeederData: IDataSeedContributor, ITransientDependency
{
    private readonly IRepository<Book, Guid> _bookRepository;
    public TechByteSeederData(IRepository<Book, Guid> bookRepository)
    {
        _bookRepository = bookRepository;
    }
    public async Task SeedAsync(DataSeedContext context)
    {
        if (await _bookRepository.GetCountAsync() <= 0)
        {
          await _bookRepository.InsertAsync(
            new Book(Guid.NewGuid(), context.TenantId)
            {
                TenantId = context.TenantId, // Use the TenantId from the DataSeedContext if available
                Title = "1984",
                Author = "George Orwell",
                ISBN = "978-0451524935",
                PublishedDate = new DateTime(1949, 6, 8),
                Pages = 328
            },
            autoSave: true
        );

        await _bookRepository.InsertAsync(
            new Book(Guid.NewGuid(), context.TenantId)
            {
                TenantId = context.TenantId,
                Title = "Brave New World",
                Author = "Aldous Huxley",
                ISBN = "978-0060850524",
                PublishedDate = new DateTime(1932, 1, 1),
                Pages = 268
            },
            autoSave: true
        );

        await _bookRepository.InsertAsync(
            new Book(Guid.NewGuid(), context.TenantId)
            {
                TenantId = context.TenantId,
                Title = "To Kill a Mockingbird",
                Author = "Harper Lee",
                ISBN = "978-0446310789",
                PublishedDate = new DateTime(1960, 7, 11),
                Pages = 281
            },
            autoSave: true
        );
        }
    }
}
