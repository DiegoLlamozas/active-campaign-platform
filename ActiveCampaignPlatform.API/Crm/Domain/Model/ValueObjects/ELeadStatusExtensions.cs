namespace ActiveCampaignPlatform.API.Crm.Domain.Model.ValueObjects;

/// <summary>
///     Business rules that depend on the lead status.
/// </summary>
public static class ELeadStatusExtensions
{
    /// <summary>Statuses that require an assigned sales agent and contact date.</summary>
    public static bool RequiresContact(this ELeadStatus status) => status != ELeadStatus.Open;

    /// <summary>Statuses that require an approval date.</summary>
    public static bool RequiresApproval(this ELeadStatus status) =>
        status is ELeadStatus.Qualified or ELeadStatus.Customer or ELeadStatus.OpportunityLost
            or ELeadStatus.Unqualified or ELeadStatus.InactiveCustomer;

    /// <summary>Statuses that require a report date.</summary>
    public static bool RequiresReport(this ELeadStatus status) => status == ELeadStatus.Unqualified;
}