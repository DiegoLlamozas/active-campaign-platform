using ActiveCampaignPlatform.API.Shared.Domain.Repositories;
using ActiveCampaignPlatform.API.Shared.Infrastructure.Persistence.EntityFrameworkCore.Configuration;

namespace ActiveCampaignPlatform.API.Shared.Infrastructure.Repositories;

public class UnitOfWork(AppDbContext context) : IUnitOfWork
{
    public async Task CompleteAsync(CancellationToken cancellationToken = default)
    {
        await context.SaveChangesAsync(cancellationToken);
    }
}