using ActiveCampaignPlatform.API.Shared.Domain.Model;

namespace ActiveCampaignPlatform.API.Domain.Model.Aggregates;

public partial class LeadAudit : IAuditableEntity
{
    public DateTimeOffset? CreatedAt { get; set; }
    public DateTimeOffset? UpdatedAt { get; set; }
}