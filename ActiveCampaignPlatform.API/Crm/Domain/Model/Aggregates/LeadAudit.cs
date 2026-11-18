using ActiveCampaignPlatform.API.Shared.Domain.Model.Entities;

namespace ActiveCampaignPlatform.API.Crm.Domain.Model.Aggregates;

public partial class Lead : IAuditableEntity
{
    public DateTimeOffset? CreatedAt { get; set; }
    public DateTimeOffset? UpdatedAt { get; set; }
}