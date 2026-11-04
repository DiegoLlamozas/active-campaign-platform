using ActiveCampaignPlatform.API.Domain.Model.ValueObjects;

namespace ActiveCampaignPlatform.API.Domain.Model.Commands;

public record CreateLeadCommand(string FirstName, string LastName, string Email, int Status, AssignedSalesAgentId? AssignedSalesAgentId, DateTime? ContactedAt, DateTime? ApprovedAt, DateTime? ReportedAt);