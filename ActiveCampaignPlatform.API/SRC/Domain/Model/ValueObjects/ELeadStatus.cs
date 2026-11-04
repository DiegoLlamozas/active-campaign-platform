namespace ActiveCampaignPlatform.API.Domain.Model.ValueObjects;

/// <summary>
/// Represents the status of a lead in the system.
/// </summary>


public enum ELeadStatus
{
    Open,
    Contacted,
    MeetingSet,
    Qualified,
    Customer,
    OpportunityLost,
    Unqualified,
    InactiveCustomer,
}