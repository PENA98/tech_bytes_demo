using System;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace tech_bytes_demo.Entities;

public class Book : AuditedAggregateRoot<Guid>, IMultiTenant
{  public Guid? TenantId { get; set; }

    public required string Title { get; set; }
    public required string Author { get; set; }
    public required string ISBN { get; set; }
    public DateTime? PublishedDate { get; set; }
    public int? Pages { get; set; }

    public Book()
    {
    }

      public Book(Guid id, Guid? tenantId)
    {
        Id = id;
        TenantId = tenantId;
    }
}
