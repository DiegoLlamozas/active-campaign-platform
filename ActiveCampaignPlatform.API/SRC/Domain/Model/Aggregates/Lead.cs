using ActiveCampaignPlatform.API.Domain.Model.Commands;
using ActiveCampaignPlatform.API.Domain.Model.ValueObjects;

namespace ActiveCampaignPlatform.API.Domain.Model.Aggregates;

public partial class Lead
{
    public int ActiveCampaignLeadId { get; private set; }
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public int Status { get; private set; }
    public AssignedSalesAgentId AssignedSalesAgentId { get; private set; }
    public DateTime? ContactedAt { get; private set; }
    public DateTime? ApprovedAt { get; private set; }
    public DateTime? ReportedAt { get; private set; }

    protected Lead()
    {
        ActiveCampaignLeadId = 0;
        FirstName = string.Empty;
        LastName = string.Empty;
        Status = 0;
        AssignedSalesAgentId = null!;
        ContactedAt = null;
        ApprovedAt = null;
        ReportedAt = null;
    }
    
    public Lead(CreateLeadCommand command)
    {
        ArgumentNullException.ThrowIfNull(command);;
        
        FirstName = command.FirstName;
        LastName = command.LastName;
        Status = command.Status;
        AssignedSalesAgentId = command.AssignedSalesAgentId ?? null!;
        ContactedAt = command.ContactedAt;
        ApprovedAt = command.ApprovedAt;
        ReportedAt = command.ReportedAt;
    }
}