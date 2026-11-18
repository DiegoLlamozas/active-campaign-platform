using Microsoft.EntityFrameworkCore;

namespace ActiveCampaignPlatform.API.Shared.Infrastructure.Interfaces.Persistence.EntityFrameworkCore.Configuration;


/// <summary>
///     Application database context for the Learning Center Platform
/// </summary>
/// <param name="options">
///     The options for the database context
/// </param>
public class AppDbContext(DbContextOptions options) : DbContext(options)
{
    
}