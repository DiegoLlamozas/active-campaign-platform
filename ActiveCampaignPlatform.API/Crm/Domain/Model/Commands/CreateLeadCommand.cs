namespace ActiveCampaignPlatform.API.Crm.Domain.Model.Commands;

/// <summary>
///     Command to register a new lead in the ActiveCampaign CRM.
/// </summary>
/// <param name="FirstName">The first name of the lead.</param>
/// <param name="LastName">The last name of the lead.</param>
/// <param name="Status">
///     The raw status value (see <c>ELeadStatus</c>). When null, the lead is registered as Open.
/// </param>
/// <param name="AssignedSalesAgentId">The identifier of the assigned sales agent, if any.</param>
/// <param name="ContactedAt">The date the lead was contacted, if any.</param>
/// <param name="ApprovedAt">The date the lead was approved, if any.</param>
/// <param name="ReportedAt">The date the lead was reported, if any.</param>
/// <remarks>Author: Your Full Name</remarks>
public record CreateLeadCommand(
    string FirstName,
    string LastName,
    int? Status,
    int? AssignedSalesAgentId,
    DateTime? ContactedAt,
    DateTime? ApprovedAt,
    DateTime? ReportedAt);