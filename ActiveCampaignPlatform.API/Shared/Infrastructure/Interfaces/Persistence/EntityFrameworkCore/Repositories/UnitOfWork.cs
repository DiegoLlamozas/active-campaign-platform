using ActiveCampaignPlatform.API.Shared.Domain.Repositories;
using ActiveCampaignPlatform.API.Shared.Infrastructure.Interfaces.Persistence.EntityFrameworkCore.Configuration;

namespace ActiveCampaignPlatform.API.Shared.Infrastructure.Interfaces.Persistence.EntityFrameworkCore.Repositories;


/// <summary>
///     Unit of work for the application.
/// </summary>
/// <remarks>
///     This class is used to save changes to the database context.
///     It implements the IUnitOfWork interface.
/// </remarks>
/// <param name="context">
///     The database context for the application
/// </param>
public class UnitOfWork(AppDbContext context) : IUnitOfWork
{
    // inheritedDoc
    public async Task CompleteAsync(CancellationToken cancellationToken = default)
    {
        await context.SaveChangesAsync(cancellationToken);
    }
}